namespace Beeper.Forms
{
    partial class ParserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParserForm));
            this.textBoxOutput = new Beeper.Forms.SequenceTextBox();
            this.textBoxSource = new Beeper.Forms.SequenceTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonExport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioMusicSheet = new System.Windows.Forms.RadioButton();
            this.radioCode = new System.Windows.Forms.RadioButton();
            this.radioPowerShell = new System.Windows.Forms.RadioButton();
            this.grouper1 = new Beeper.Forms.Grouper();
            this.radioBash = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.numberBoxDuration = new System.Windows.Forms.NumericUpDown();
            this.grouper2 = new Beeper.Forms.Grouper();
            this.numberBoxPeriodPause = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numberBoxSemicolonPause = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numberBoxComma = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numberBoxPause = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.grouper1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxDuration)).BeginInit();
            this.grouper2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxPeriodPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxSemicolonPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxComma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxPause)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutput.BackColor = System.Drawing.Color.DarkGray;
            this.textBoxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxOutput.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBoxOutput.HideSelection = false;
            this.textBoxOutput.Location = new System.Drawing.Point(12, 190);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(485, 104);
            this.textBoxOutput.TabIndex = 5;
            // 
            // textBoxSource
            // 
            this.textBoxSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSource.BackColor = System.Drawing.Color.DarkGray;
            this.textBoxSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSource.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBoxSource.HideSelection = false;
            this.textBoxSource.Location = new System.Drawing.Point(12, 71);
            this.textBoxSource.Multiline = true;
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.Size = new System.Drawing.Size(485, 95);
            this.textBoxSource.TabIndex = 4;
            this.textBoxSource.Text = resources.GetString("textBoxSource.Text");
            this.textBoxSource.TextChanged += new System.EventHandler(this.UpdateOutputHandler);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(213)))));
            this.label3.Location = new System.Drawing.Point(12, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 34);
            this.label3.TabIndex = 10;
            this.label3.Text = "Parser";
            // 
            // buttonExport
            // 
            this.buttonExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonExport.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExport.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(213)))));
            this.buttonExport.Location = new System.Drawing.Point(410, 440);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(87, 30);
            this.buttonExport.TabIndex = 11;
            this.buttonExport.Text = "Export...";
            this.buttonExport.UseVisualStyleBackColor = false;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Output";
            // 
            // radioMusicSheet
            // 
            this.radioMusicSheet.AutoSize = true;
            this.radioMusicSheet.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMusicSheet.ForeColor = System.Drawing.Color.White;
            this.radioMusicSheet.Location = new System.Drawing.Point(13, 22);
            this.radioMusicSheet.Name = "radioMusicSheet";
            this.radioMusicSheet.Size = new System.Drawing.Size(103, 20);
            this.radioMusicSheet.TabIndex = 7;
            this.radioMusicSheet.Text = "Music Sheet";
            this.radioMusicSheet.UseVisualStyleBackColor = true;
            this.radioMusicSheet.CheckedChanged += new System.EventHandler(this.UpdateOutputHandler);
            // 
            // radioCode
            // 
            this.radioCode.AutoSize = true;
            this.radioCode.Checked = true;
            this.radioCode.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCode.ForeColor = System.Drawing.Color.White;
            this.radioCode.Location = new System.Drawing.Point(13, 48);
            this.radioCode.Name = "radioCode";
            this.radioCode.Size = new System.Drawing.Size(79, 20);
            this.radioCode.TabIndex = 6;
            this.radioCode.TabStop = true;
            this.radioCode.Text = "C# Code";
            this.radioCode.UseVisualStyleBackColor = true;
            this.radioCode.CheckedChanged += new System.EventHandler(this.UpdateOutputHandler);
            // 
            // radioPowerShell
            // 
            this.radioPowerShell.AutoSize = true;
            this.radioPowerShell.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPowerShell.ForeColor = System.Drawing.Color.White;
            this.radioPowerShell.Location = new System.Drawing.Point(118, 22);
            this.radioPowerShell.Name = "radioPowerShell";
            this.radioPowerShell.Size = new System.Drawing.Size(143, 20);
            this.radioPowerShell.TabIndex = 8;
            this.radioPowerShell.Text = "Power Shell Cmds";
            this.radioPowerShell.UseVisualStyleBackColor = true;
            this.radioPowerShell.CheckedChanged += new System.EventHandler(this.UpdateOutputHandler);
            // 
            // grouper1
            // 
            this.grouper1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grouper1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grouper1.CaptionIndent = 20;
            this.grouper1.Controls.Add(this.radioBash);
            this.grouper1.Controls.Add(this.radioPowerShell);
            this.grouper1.Controls.Add(this.radioCode);
            this.grouper1.Controls.Add(this.radioMusicSheet);
            this.grouper1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grouper1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(213)))));
            this.grouper1.Location = new System.Drawing.Point(223, 300);
            this.grouper1.Name = "grouper1";
            this.grouper1.Padding = new System.Windows.Forms.Padding(10, 19, 5, 10);
            this.grouper1.Size = new System.Drawing.Size(274, 79);
            this.grouper1.TabIndex = 14;
            this.grouper1.Text = "Parse From";
            // 
            // radioBash
            // 
            this.radioBash.AutoSize = true;
            this.radioBash.Checked = true;
            this.radioBash.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBash.ForeColor = System.Drawing.Color.White;
            this.radioBash.Location = new System.Drawing.Point(118, 51);
            this.radioBash.Name = "radioBash";
            this.radioBash.Size = new System.Drawing.Size(57, 20);
            this.radioBash.TabIndex = 9;
            this.radioBash.TabStop = true;
            this.radioBash.Text = "Bash";
            this.radioBash.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Duration";
            // 
            // numberBoxDuration
            // 
            this.numberBoxDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.numberBoxDuration.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBoxDuration.ForeColor = System.Drawing.Color.White;
            this.numberBoxDuration.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numberBoxDuration.Location = new System.Drawing.Point(80, 25);
            this.numberBoxDuration.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numberBoxDuration.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numberBoxDuration.Name = "numberBoxDuration";
            this.numberBoxDuration.Size = new System.Drawing.Size(55, 21);
            this.numberBoxDuration.TabIndex = 15;
            this.numberBoxDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numberBoxDuration.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numberBoxDuration.ValueChanged += new System.EventHandler(this.UpdateOutputHandler);
            // 
            // grouper2
            // 
            this.grouper2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grouper2.CaptionIndent = 20;
            this.grouper2.Controls.Add(this.numberBoxPeriodPause);
            this.grouper2.Controls.Add(this.label8);
            this.grouper2.Controls.Add(this.numberBoxSemicolonPause);
            this.grouper2.Controls.Add(this.label7);
            this.grouper2.Controls.Add(this.numberBoxComma);
            this.grouper2.Controls.Add(this.label6);
            this.grouper2.Controls.Add(this.numberBoxPause);
            this.grouper2.Controls.Add(this.label5);
            this.grouper2.Controls.Add(this.numberBoxDuration);
            this.grouper2.Controls.Add(this.label4);
            this.grouper2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grouper2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(213)))));
            this.grouper2.Location = new System.Drawing.Point(12, 300);
            this.grouper2.Name = "grouper2";
            this.grouper2.Padding = new System.Windows.Forms.Padding(10, 19, 5, 10);
            this.grouper2.Size = new System.Drawing.Size(155, 170);
            this.grouper2.TabIndex = 15;
            this.grouper2.Text = "Defaults";
            // 
            // numberBoxPeriodPause
            // 
            this.numberBoxPeriodPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.numberBoxPeriodPause.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBoxPeriodPause.ForeColor = System.Drawing.Color.White;
            this.numberBoxPeriodPause.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numberBoxPeriodPause.Location = new System.Drawing.Point(80, 133);
            this.numberBoxPeriodPause.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numberBoxPeriodPause.Name = "numberBoxPeriodPause";
            this.numberBoxPeriodPause.Size = new System.Drawing.Size(55, 21);
            this.numberBoxPeriodPause.TabIndex = 23;
            this.numberBoxPeriodPause.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numberBoxPeriodPause.ValueChanged += new System.EventHandler(this.UpdateOutputHandler);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(13, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = ". Pause";
            // 
            // numberBoxSemicolonPause
            // 
            this.numberBoxSemicolonPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.numberBoxSemicolonPause.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBoxSemicolonPause.ForeColor = System.Drawing.Color.White;
            this.numberBoxSemicolonPause.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numberBoxSemicolonPause.Location = new System.Drawing.Point(80, 106);
            this.numberBoxSemicolonPause.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numberBoxSemicolonPause.Name = "numberBoxSemicolonPause";
            this.numberBoxSemicolonPause.Size = new System.Drawing.Size(55, 21);
            this.numberBoxSemicolonPause.TabIndex = 21;
            this.numberBoxSemicolonPause.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numberBoxSemicolonPause.ValueChanged += new System.EventHandler(this.UpdateOutputHandler);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(13, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "; Pause";
            // 
            // numberBoxComma
            // 
            this.numberBoxComma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.numberBoxComma.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBoxComma.ForeColor = System.Drawing.Color.White;
            this.numberBoxComma.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numberBoxComma.Location = new System.Drawing.Point(80, 79);
            this.numberBoxComma.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numberBoxComma.Name = "numberBoxComma";
            this.numberBoxComma.Size = new System.Drawing.Size(55, 21);
            this.numberBoxComma.TabIndex = 19;
            this.numberBoxComma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numberBoxComma.ValueChanged += new System.EventHandler(this.UpdateOutputHandler);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = ", Pause";
            // 
            // numberBoxPause
            // 
            this.numberBoxPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.numberBoxPause.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBoxPause.ForeColor = System.Drawing.Color.White;
            this.numberBoxPause.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numberBoxPause.Location = new System.Drawing.Point(80, 52);
            this.numberBoxPause.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numberBoxPause.Name = "numberBoxPause";
            this.numberBoxPause.Size = new System.Drawing.Size(55, 21);
            this.numberBoxPause.TabIndex = 17;
            this.numberBoxPause.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numberBoxPause.ValueChanged += new System.EventHandler(this.UpdateOutputHandler);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Pause";
            // 
            // ParserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(509, 482);
            this.Controls.Add(this.grouper2);
            this.Controls.Add(this.grouper1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxSource);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ParserForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Parser";
            this.Controls.SetChildIndex(this.textBoxSource, 0);
            this.Controls.SetChildIndex(this.textBoxOutput, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.buttonExport, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.grouper1, 0);
            this.Controls.SetChildIndex(this.grouper2, 0);
            this.grouper1.ResumeLayout(false);
            this.grouper1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxDuration)).EndInit();
            this.grouper2.ResumeLayout(false);
            this.grouper2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxPeriodPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxSemicolonPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxComma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxPause)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SequenceTextBox textBoxSource;
        private SequenceTextBox textBoxOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioMusicSheet;
        private System.Windows.Forms.RadioButton radioCode;
        private System.Windows.Forms.RadioButton radioPowerShell;
        private Grouper grouper1;
        private System.Windows.Forms.RadioButton radioBash;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numberBoxDuration;
        private Grouper grouper2;
        private System.Windows.Forms.NumericUpDown numberBoxPeriodPause;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numberBoxSemicolonPause;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numberBoxComma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numberBoxPause;
        private System.Windows.Forms.Label label5;
    }
}