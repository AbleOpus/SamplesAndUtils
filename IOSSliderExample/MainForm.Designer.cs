namespace IOSSliderExample
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.iosSlider = new IOSSliderExample.IosSlider();
            this.SuspendLayout();
            // 
            // propertyGrid
            // 
            this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Right;
            this.propertyGrid.Location = new System.Drawing.Point(670, 0);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.SelectedObject = this.iosSlider;
            this.propertyGrid.Size = new System.Drawing.Size(361, 460);
            this.propertyGrid.TabIndex = 2;
            // 
            // iosSlider
            // 
            this.iosSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iosSlider.KnobImage = global::IOSSliderExample.Properties.Resources.MetalKnob;
            this.iosSlider.Location = new System.Drawing.Point(12, 12);
            this.iosSlider.Name = "iosSlider";
            this.iosSlider.Size = new System.Drawing.Size(652, 20);
            this.iosSlider.TabIndex = 1;
            this.iosSlider.Text = "iosSlider1";
            this.iosSlider.Value = 1;
            this.iosSlider.ValueChanged += new System.EventHandler(this.iosSlider_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1031, 460);
            this.Controls.Add(this.propertyGrid);
            this.Controls.Add(this.iosSlider);
            this.Name = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private IosSlider iosSlider;
        private System.Windows.Forms.PropertyGrid propertyGrid;
    }
}

