using System;
using System.Windows.Forms;

namespace AboCodeLibrary
{
    /// <summary>
    /// Represents a fading mechanism for <see cref="Form"/>s.
    /// </summary>
    public class FormFader : IDisposable
    {
        private double targetOpacity;
        private readonly Form form;
        private readonly Timer timerFade = new Timer();

        private double fadeInIncrement = 0.05;
        /// <summary>
        /// Gets or sets how much to increment the opacity when fading in.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public double FadeInIncrement 
        {
            get { return fadeInIncrement; }
            set
            {
                fadeInIncrement = value;
                CheckOpacityValue(value, nameof(value));
            }
        }

        private double fadeOutIncrement = 0.05;
        /// <summary>
        /// Gets or sets how much to decrement the opacity when fading out.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public double FadeOutIncrement
        {
            get { return fadeOutIncrement; }
            set
            {
                fadeOutIncrement = value;
                CheckOpacityValue(value, nameof(value));
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormFader"/> class with the 
        /// specified argument.
        /// </summary>
        /// <param name="form">the form to be faded.</param>
        public FormFader(Form form)
        {
            timerFade.Interval = 20;
            timerFade.Tick += Fade_Tick;
            this.form = form;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormFader"/> class with the 
        /// specified arguments.
        /// </summary>
        /// <param name="form">the form to be faded</param>
        /// <param name="fadeInSpeed">The speed at which the form will fade in (timer interval)</param>
        /// <param name="fadeOutSpeed">The speed at which the form will fade out (timer interval)</param>
        public FormFader(Form form, int fadeInSpeed, int fadeOutSpeed) 
            : this(form)
        {
            fadeInIncrement = fadeInSpeed;
            fadeOutIncrement = fadeOutSpeed;
        }

        /// <summary>
        /// Fades the Form to the specified target opacity.
        /// </summary>
        /// <param name="opacity">The opacity to fade the Form to.</param>
        public void FadeTo(double opacity)
        {
            CheckOpacityValue(opacity, nameof(opacity));
            targetOpacity = opacity;
            timerFade.Start();
        }

        /// <summary>
        /// Completely fades out the Form. Effectively making it invisible.
        /// </summary>
        public void FadeOut()
        {
            FadeTo(0);
        }

        /// <summary>
        /// Completely fades in the Form. Effectively making it opaque.
        /// </summary>
        public void FadeIn()
        {
            FadeTo(1);
        }

        private static void CheckOpacityValue(double value, string propertyName)
        {
            if (value < 0 || value > 1)
            {
                throw new ArgumentOutOfRangeException(propertyName, value,
                    "Value must be greater than or equal to 0 and less than or equal to 1.");
            }
        }

        private void Fade_Tick(object sender, EventArgs e)
        {
            if (targetOpacity < form.Opacity)
            {
                if (form.Opacity - fadeOutIncrement < 0)
                {
                    form.Opacity = targetOpacity;
                    timerFade.Stop();
                    return;
                }

                form.Opacity -= fadeOutIncrement;

                if (form.Opacity <= targetOpacity)
                {
                    form.Opacity = targetOpacity;
                    timerFade.Stop();
                    return;
                }
            }
            else if (targetOpacity > form.Opacity)
            {
                if (form.Opacity + fadeInIncrement > 1)
                {
                    form.Opacity = targetOpacity;
                    timerFade.Stop();
                    return;
                }

                form.Opacity += fadeInIncrement;

                if (form.Opacity >= targetOpacity)
                {
                    form.Opacity = targetOpacity;
                    timerFade.Stop();
                    return;
                }
            }
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, 
        /// or resetting unmanaged resources.
        /// </summary>
        /// <filterpriority>2</filterpriority>
        public void Dispose()
        {
            timerFade.Dispose();
        }
    }
}
