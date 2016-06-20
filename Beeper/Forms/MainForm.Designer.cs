namespace Beeper.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonPlay = new System.Windows.Forms.Button();
            this.numberBoxSpeed = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOpenParser = new System.Windows.Forms.Button();
            this.textBoxSequence = new Beeper.Forms.SequenceTextBox();
            this.sequenceMenuStrip = new Beeper.Forms.SequenceMenuStrip();
            this.labelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonPlay.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(213)))));
            this.buttonPlay.Location = new System.Drawing.Point(316, 281);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 30);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // numberBoxSpeed
            // 
            this.numberBoxSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numberBoxSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.numberBoxSpeed.DecimalPlaces = 2;
            this.numberBoxSpeed.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBoxSpeed.ForeColor = System.Drawing.Color.White;
            this.numberBoxSpeed.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numberBoxSpeed.Location = new System.Drawing.Point(128, 286);
            this.numberBoxSpeed.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numberBoxSpeed.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numberBoxSpeed.Name = "numberBoxSpeed";
            this.numberBoxSpeed.Size = new System.Drawing.Size(55, 21);
            this.numberBoxSpeed.TabIndex = 2;
            this.numberBoxSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numberBoxSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberBoxSpeed.ValueChanged += new System.EventHandler(this.numberBoxDuration_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Playback Speed";
            // 
            // buttonOpenParser
            // 
            this.buttonOpenParser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpenParser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonOpenParser.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonOpenParser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenParser.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenParser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(213)))));
            this.buttonOpenParser.Location = new System.Drawing.Point(192, 281);
            this.buttonOpenParser.Name = "buttonOpenParser";
            this.buttonOpenParser.Size = new System.Drawing.Size(118, 30);
            this.buttonOpenParser.TabIndex = 4;
            this.buttonOpenParser.Text = "Open Parser...";
            this.buttonOpenParser.UseVisualStyleBackColor = false;
            this.buttonOpenParser.Click += new System.EventHandler(this.buttonOpenParser_Click);
            // 
            // textBoxSequence
            // 
            this.textBoxSequence.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSequence.BackColor = System.Drawing.Color.DarkGray;
            this.textBoxSequence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSequence.ContextMenuStrip = this.sequenceMenuStrip;
            this.textBoxSequence.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSequence.ForeColor = System.Drawing.Color.Black;
            this.textBoxSequence.HideSelection = false;
            this.textBoxSequence.Location = new System.Drawing.Point(12, 48);
            this.textBoxSequence.Multiline = true;
            this.textBoxSequence.Name = "textBoxSequence";
            this.textBoxSequence.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSequence.Size = new System.Drawing.Size(379, 227);
            this.textBoxSequence.TabIndex = 5;
            this.textBoxSequence.Text = resources.GetString("textBoxSequence.Text");
            // 
            // sequenceMenuStrip
            // 
            this.sequenceMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.sequenceMenuStrip.DropShadowEnabled = false;
            this.sequenceMenuStrip.Name = "sequenceMenuStrip";
            this.sequenceMenuStrip.ShowImageMargin = false;
            this.sequenceMenuStrip.Size = new System.Drawing.Size(36, 4);
            this.sequenceMenuStrip.SequenceLoaded += new System.EventHandler<string>(this.sequenceMenuStrip_SequenceLoaded);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(213)))));
            this.labelTitle.Location = new System.Drawing.Point(12, 11);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(112, 34);
            this.labelTitle.TabIndex = 9;
            this.labelTitle.Text = "Beeper";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(403, 323);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxSequence);
            this.Controls.Add(this.buttonOpenParser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberBoxSpeed);
            this.Controls.Add(this.buttonPlay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beeper";
            this.Controls.SetChildIndex(this.buttonPlay, 0);
            this.Controls.SetChildIndex(this.numberBoxSpeed, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.buttonOpenParser, 0);
            this.Controls.SetChildIndex(this.textBoxSequence, 0);
            this.Controls.SetChildIndex(this.labelTitle, 0);
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.NumericUpDown numberBoxSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOpenParser;
        private SequenceTextBox textBoxSequence;
        private SequenceMenuStrip sequenceMenuStrip;
        private System.Windows.Forms.Label labelTitle;
    }
}

