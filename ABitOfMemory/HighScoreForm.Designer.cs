namespace ABitOfMemory
{
    partial class HighScoreForm
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
                pen.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HighScoreForm));
            this.labelScore = new System.Windows.Forms.Label();
            this.tmrAnimate = new System.Windows.Forms.Timer(this.components);
            this.labelSequence = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelScore
            // 
            this.labelScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(202)))), ((int)(((byte)(113)))));
            this.labelScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelScore.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(0, 0);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(313, 50);
            this.labelScore.TabIndex = 0;
            this.labelScore.Text = "New High Score: ";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelScore.Click += new System.EventHandler(this.HighScoreForm_Click);
            this.labelScore.Paint += new System.Windows.Forms.PaintEventHandler(this.labelScore_Paint);
            // 
            // tmrAnimate
            // 
            this.tmrAnimate.Interval = 400;
            this.tmrAnimate.Tick += new System.EventHandler(this.timerAnimate_Tick);
            // 
            // labelSequence
            // 
            this.labelSequence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(202)))), ((int)(((byte)(113)))));
            this.labelSequence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSequence.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelSequence.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSequence.Location = new System.Drawing.Point(0, 48);
            this.labelSequence.Name = "labelSequence";
            this.labelSequence.Size = new System.Drawing.Size(313, 50);
            this.labelSequence.TabIndex = 1;
            this.labelSequence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSequence.Click += new System.EventHandler(this.HighScoreForm_Click);
            this.labelSequence.Paint += new System.Windows.Forms.PaintEventHandler(this.labelSequence_Paint);
            // 
            // HighScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(313, 98);
            this.Controls.Add(this.labelSequence);
            this.Controls.Add(this.labelScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HighScoreForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HighScoreForm";
            this.Click += new System.EventHandler(this.HighScoreForm_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Timer tmrAnimate;
        private System.Windows.Forms.Label labelSequence;
    }
}