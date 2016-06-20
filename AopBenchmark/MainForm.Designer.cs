namespace AopBenchmark
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
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelTime1 = new System.Windows.Forms.Label();
            this.labelTime2 = new System.Windows.Forms.Label();
            this.buttonBenchmark = new System.Windows.Forms.Button();
            this.numberBoxLoops = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelRatio = new System.Windows.Forms.Label();
            this.labelTotalTime = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxLoops)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(264, 123);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(53, 13);
            label1.TabIndex = 4;
            label1.Text = "Iterations:";
            // 
            // labelTime1
            // 
            this.labelTime1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTime1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime1.ForeColor = System.Drawing.Color.Maroon;
            this.labelTime1.Location = new System.Drawing.Point(84, 9);
            this.labelTime1.Name = "labelTime1";
            this.labelTime1.Size = new System.Drawing.Size(356, 31);
            this.labelTime1.TabIndex = 0;
            this.labelTime1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTime2
            // 
            this.labelTime2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime2.ForeColor = System.Drawing.Color.Maroon;
            this.labelTime2.Location = new System.Drawing.Point(84, 48);
            this.labelTime2.Name = "labelTime2";
            this.labelTime2.Size = new System.Drawing.Size(356, 30);
            this.labelTime2.TabIndex = 1;
            this.labelTime2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBenchmark
            // 
            this.buttonBenchmark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBenchmark.Location = new System.Drawing.Point(365, 123);
            this.buttonBenchmark.Name = "buttonBenchmark";
            this.buttonBenchmark.Size = new System.Drawing.Size(75, 40);
            this.buttonBenchmark.TabIndex = 2;
            this.buttonBenchmark.Text = "Benchmark";
            this.buttonBenchmark.UseVisualStyleBackColor = true;
            this.buttonBenchmark.Click += new System.EventHandler(this.buttonBenchmark_Click);
            // 
            // numberBoxLoops
            // 
            this.numberBoxLoops.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numberBoxLoops.Location = new System.Drawing.Point(250, 143);
            this.numberBoxLoops.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numberBoxLoops.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numberBoxLoops.Name = "numberBoxLoops";
            this.numberBoxLoops.Size = new System.Drawing.Size(79, 20);
            this.numberBoxLoops.TabIndex = 3;
            this.numberBoxLoops.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "B1 Ticks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "B2 Ticks";
            // 
            // labelRatio
            // 
            this.labelRatio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelRatio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRatio.Location = new System.Drawing.Point(12, 118);
            this.labelRatio.Name = "labelRatio";
            this.labelRatio.Size = new System.Drawing.Size(206, 23);
            this.labelRatio.TabIndex = 8;
            this.labelRatio.Tag = "B1/B2 Ratio: ";
            this.labelRatio.Text = "B1/B2 Ratio: ";
            this.labelRatio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTotalTime
            // 
            this.labelTotalTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTotalTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalTime.Location = new System.Drawing.Point(12, 140);
            this.labelTotalTime.Name = "labelTotalTime";
            this.labelTotalTime.Size = new System.Drawing.Size(206, 23);
            this.labelTotalTime.TabIndex = 9;
            this.labelTotalTime.Tag = "Total Benchmark Time (sec): ";
            this.labelTotalTime.Text = "Total Benchmark Time (sec): ";
            this.labelTotalTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 175);
            this.Controls.Add(this.labelTotalTime);
            this.Controls.Add(this.labelRatio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.numberBoxLoops);
            this.Controls.Add(this.buttonBenchmark);
            this.Controls.Add(this.labelTime2);
            this.Controls.Add(this.labelTime1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "BSF Benchmark";
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxLoops)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime1;
        private System.Windows.Forms.Label labelTime2;
        private System.Windows.Forms.Button buttonBenchmark;
        private System.Windows.Forms.NumericUpDown numberBoxLoops;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelRatio;
        private System.Windows.Forms.Label labelTotalTime;
    }
}

