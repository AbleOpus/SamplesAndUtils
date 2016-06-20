namespace MorseCodeRain
{
    partial class RenderForm
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
            this.components = new System.ComponentModel.Container();
            this.timerInvalidate = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timerInvalidate
            // 
            this.timerInvalidate.Enabled = true;
            this.timerInvalidate.Interval = 20;
            this.timerInvalidate.Tick += new System.EventHandler(this.timerInvalidate_Tick);
            // 
            // RenderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.DoubleBuffered = true;
            this.Name = "RenderForm";
            this.Text = "RenderForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerInvalidate;
    }
}