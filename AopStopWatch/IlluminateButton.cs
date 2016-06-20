using System;
using System.Diagnostics;
using System.Drawing;
using System.ComponentModel;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace AboStopWatch
{
    /// <summary>
    /// Represents a button configured for displaying an image. The image will illuminate
    /// when the mouse hovers over this control.
    /// </summary>
    class IlluminateButton : Button
    {
        #region Properties

        /// <summary>
        /// Gets or sets a value that indicates whether the control resizes based on its contents.
        /// </summary>
        /// <returns>
        /// true if the control automatically resizes based on its contents; otherwise, false. The default is true.
        /// </returns>
        public override bool AutoSize
        {
            get
            {
                // So it doesn't get all small
                if (Image == null) return false;
                return base.AutoSize;
            }
            set
            {
                base.AutoSize = value;
            }
        }

        /// <returns>
        /// The text associated with this control.
        /// </returns>
        [Browsable(false)]
        public override string Text
        {
            get { return base.Text; }
            set { base.Text = string.Empty; }
        }

        // Hide selection border.

        /// <summary>
        /// Gets a value indicating whether the control should display focus rectangles.
        /// </summary>
        /// <returns>
        /// true if the control should display focus rectangles; otherwise, false.
        /// </returns>
        protected override bool ShowFocusCues => false;

        // This differs from the selection rectangle.
        [DefaultValue(true), Category("Appearance")]
        [Description("If true, the black focus rectangle that appears when the button is the forms accept button, will be hidden.")]
        public bool HideFocusBorder { get; set; } = true;

        [Description("The brightness of the image when the mouse hovers over this button.")]
        [Category("Appearance"), DefaultValue(1)]
        public float HoverBrightness { get; set; } = 1;

        [Description("The contrast of the image when the mouse hovers over this button.")]
        [Category("Appearance"), DefaultValue(1)]
        public float HoverContrast { get; set; } = 1.2f;

        [Description("The gamma of the image when the mouse hovers over this button.")]
        [Category("Appearance"), DefaultValue(1.2f)]
        public float HoverGamma { get; set; } = 1.2f;

        [Description("The brightness of the image when the mouse depresses this button.")]
        [Category("Appearance"), DefaultValue(1)]
        public float DepressBrightness { get; set; } = 1;

        [Description("The contrast of the image when the mouse depresses this button.")]
        [Category("Appearance"), DefaultValue(1)]
        public float DepressConstrast { get; set; } = 1;

        [Description("The gamma of the image when the mouse depresses this button.")]
        [Category("Appearance"), DefaultValue(1.2f)]
        public float DepressGamma { get; set; } = 1;

        private Image defaultImage;
        [Description("The original image to be illuminated.")]
        [Category("Appearance"), DefaultValue(null)]
        public Image DefaultImage
        {
            get { return defaultImage; }
            set
            {
                defaultImage = value;
                Image = value;

                if (Bounds.Contains(PointToClient(Cursor.Position)))
                {
                    Illuminate();
                }
            }
        }
        #endregion

        public IlluminateButton()
        {
            base.Cursor = Cursors.Hand;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            //Disable additional graphics
            FlatAppearance.BorderSize = 0;
            base.BackColor = Color.Transparent;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.MouseDownBackColor = Color.Transparent;
            FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        /// <summary>
        /// Adjusts the brightness, contrast, and gamma of an image.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private static Image AdjustImage(Image image, float brightness, float contrast, float gamma)
        {
            if (gamma <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(gamma), "Value must be greater than 0");
            }

            float adjustedBrightness = brightness - 1.0f;
            // create matrix that will brighten and contrast the image
            float[][] ptsArray =
            {
                new[] {contrast, 0, 0, 0, 0}, // scale red
                new[] {0, contrast, 0, 0, 0}, // scale green
                new[] {0, 0, contrast, 0, 0}, // scale blue
                new[] {0, 0, 0, 1.0f, 0},     // don't scale alpha
                new[] {adjustedBrightness, adjustedBrightness, adjustedBrightness, 0, 1}
            };

            Bitmap adjustedImage = new Bitmap(image);

            using (var imageAttributes = new ImageAttributes())
            {
                imageAttributes.ClearColorMatrix();
                imageAttributes.SetColorMatrix(new ColorMatrix(ptsArray), 
                    ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                imageAttributes.SetGamma(gamma, ColorAdjustType.Bitmap);
       
                using (Graphics graphics = Graphics.FromImage(adjustedImage))
                {
                    Rectangle rect = new Rectangle(Point.Empty, adjustedImage.Size);
                    graphics.DrawImage(image, rect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
                }
            }

            return adjustedImage;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            if (HideFocusBorder && Parent != null)
            {
                ControlPaint.DrawBorder(pevent.Graphics, ClientRectangle,
                    Parent.BackColor, ButtonBorderStyle.Solid);
            }
        }

        private void Illuminate()
        {
            if (defaultImage != null)
            {
                Image = AdjustImage(defaultImage, HoverBrightness, HoverContrast, HoverGamma);
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            Illuminate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseEnter(e);
            Image = defaultImage;
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);

            if (defaultImage != null)
            {
                Image = AdjustImage(defaultImage, DepressBrightness, DepressConstrast, DepressGamma);
            }
        }
        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            Image = defaultImage;
        }
    }
}
