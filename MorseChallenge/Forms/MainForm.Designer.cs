namespace MorseChallenge.Forms
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
            formChart.Dispose();

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
            this.textBoxScrapbook = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numberBoxdDotDuration = new System.Windows.Forms.NumericUpDown();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.labelScore = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelReport = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonOpenChart = new System.Windows.Forms.Button();
            this.numberBoxFreq = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.numberBoxLetterGap = new System.Windows.Forms.NumericUpDown();
            this.picLight = new System.Windows.Forms.PictureBox();
            this.timerCountDown = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxdDotDuration)).BeginInit();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxLetterGap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLight)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxScrapbook
            // 
            this.textBoxScrapbook.AcceptsReturn = true;
            this.textBoxScrapbook.AcceptsTab = true;
            this.textBoxScrapbook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxScrapbook.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxScrapbook.Location = new System.Drawing.Point(12, 38);
            this.textBoxScrapbook.Multiline = true;
            this.textBoxScrapbook.Name = "textBoxScrapbook";
            this.textBoxScrapbook.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxScrapbook.Size = new System.Drawing.Size(642, 281);
            this.textBoxScrapbook.TabIndex = 0;
            this.toolTip.SetToolTip(this.textBoxScrapbook, "For inputting data as you hear it.\r\nYou can use 1 and 2 for dots and dashes repec" +
        "tively.\r\n(Dots are presented as bullets)");
            this.textBoxScrapbook.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxScrapbook_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notes:";
            // 
            // lblAnswer
            // 
            this.lblAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Enabled = false;
            this.lblAnswer.Location = new System.Drawing.Point(322, 330);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(90, 13);
            this.lblAnswer.TabIndex = 2;
            this.lblAnswer.Text = "Answer (in letters)";
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAnswer.Enabled = false;
            this.textBoxAnswer.Location = new System.Drawing.Point(418, 327);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(155, 20);
            this.textBoxAnswer.TabIndex = 3;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSubmit.Enabled = false;
            this.buttonSubmit.Location = new System.Drawing.Point(579, 325);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 4;
            this.buttonSubmit.Text = "Submit";
            this.toolTip.SetToolTip(this.buttonSubmit, "Submit your answer");
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dot Duration (MS)";
            // 
            // numberBoxdDotDuration
            // 
            this.numberBoxdDotDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numberBoxdDotDuration.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numberBoxdDotDuration.Location = new System.Drawing.Point(575, 12);
            this.numberBoxdDotDuration.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numberBoxdDotDuration.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numberBoxdDotDuration.Name = "numberBoxdDotDuration";
            this.numberBoxdDotDuration.Size = new System.Drawing.Size(46, 20);
            this.numberBoxdDotDuration.TabIndex = 6;
            this.toolTip.SetToolTip(this.numberBoxdDotDuration, "The duration of the dot, which will depict the duration of everything else");
            this.numberBoxdDotDuration.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numberBoxdDotDuration.ValueChanged += new System.EventHandler(this.numberBoxDotDuration_ValueChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelScore,
            this.labelReport});
            this.statusStrip.Location = new System.Drawing.Point(0, 351);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(666, 24);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 7;
            this.statusStrip.Text = "statusStrip1";
            // 
            // labelScore
            // 
            this.labelScore.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.labelScore.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(99, 19);
            this.labelScore.Text = "Wrong 0, Right 0";
            // 
            // labelReport
            // 
            this.labelReport.Name = "labelReport";
            this.labelReport.Size = new System.Drawing.Size(67, 19);
            this.labelReport.Text = "Report: Idle";
            // 
            // buttonPlay
            // 
            this.buttonPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPlay.Location = new System.Drawing.Point(12, 325);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay.TabIndex = 8;
            this.buttonPlay.Text = "Play";
            this.toolTip.SetToolTip(this.buttonPlay, "Play the current challenge");
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonOpenChart
            // 
            this.buttonOpenChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOpenChart.Location = new System.Drawing.Point(93, 325);
            this.buttonOpenChart.Name = "buttonOpenChart";
            this.buttonOpenChart.Size = new System.Drawing.Size(74, 23);
            this.buttonOpenChart.TabIndex = 9;
            this.buttonOpenChart.Text = "Chart";
            this.toolTip.SetToolTip(this.buttonOpenChart, "Opens a reference chart for international morse code");
            this.buttonOpenChart.UseVisualStyleBackColor = true;
            this.buttonOpenChart.Click += new System.EventHandler(this.buttonOpenChart_Click);
            // 
            // numberBoxFreq
            // 
            this.numberBoxFreq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numberBoxFreq.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numberBoxFreq.Location = new System.Drawing.Point(412, 12);
            this.numberBoxFreq.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberBoxFreq.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numberBoxFreq.Name = "numberBoxFreq";
            this.numberBoxFreq.Size = new System.Drawing.Size(59, 20);
            this.numberBoxFreq.TabIndex = 11;
            this.toolTip.SetToolTip(this.numberBoxFreq, "The frequency of the beep sound");
            this.numberBoxFreq.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numberBoxFreq.ValueChanged += new System.EventHandler(this.numberBoxFreq_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Freq.";
            // 
            // numberBoxLetterGap
            // 
            this.numberBoxLetterGap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numberBoxLetterGap.Location = new System.Drawing.Point(328, 12);
            this.numberBoxLetterGap.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numberBoxLetterGap.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numberBoxLetterGap.Name = "numberBoxLetterGap";
            this.numberBoxLetterGap.Size = new System.Drawing.Size(41, 20);
            this.numberBoxLetterGap.TabIndex = 14;
            this.toolTip.SetToolTip(this.numberBoxLetterGap, "The pause between letters as a multiple of the dot duration.\r\n(3 is default as it" +
        " is the international amount)");
            this.numberBoxLetterGap.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numberBoxLetterGap.ValueChanged += new System.EventHandler(this.numberBoxLetterGap_ValueChanged);
            // 
            // picLight
            // 
            this.picLight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picLight.Image = global::MorseChallenge.Properties.Resources.Light;
            this.picLight.Location = new System.Drawing.Point(630, 8);
            this.picLight.Name = "picLight";
            this.picLight.Size = new System.Drawing.Size(24, 24);
            this.picLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLight.TabIndex = 12;
            this.picLight.TabStop = false;
            this.picLight.DoubleClick += new System.EventHandler(this.pictureBoxLight_DoubleClick);
            // 
            // timerCountDown
            // 
            this.timerCountDown.Interval = 1000;
            this.timerCountDown.Tick += new System.EventHandler(this.timerCountDown_Tick);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Letter Gap";
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 375);
            this.Controls.Add(this.numberBoxLetterGap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picLight);
            this.Controls.Add(this.numberBoxFreq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonOpenChart);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.numberBoxdDotDuration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxScrapbook);
            this.MinimumSize = new System.Drawing.Size(555, 223);
            this.Name = "MainForm";
            this.Text = "Morse Challenge";
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxdDotDuration)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxLetterGap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxScrapbook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numberBoxdDotDuration;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel labelScore;
        private System.Windows.Forms.ToolStripStatusLabel labelReport;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonOpenChart;
        private System.Windows.Forms.NumericUpDown numberBoxFreq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.PictureBox picLight;
        private System.Windows.Forms.Timer timerCountDown;
        private System.Windows.Forms.NumericUpDown numberBoxLetterGap;
        private System.Windows.Forms.Label label4;
    }
}

