namespace ParticleGenerator
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.panelColor = new System.Windows.Forms.Panel();
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.checkBoxClear = new System.Windows.Forms.CheckBox();
            this.numberBoxParticleSize = new System.Windows.Forms.NumericUpDown();
            this.numberBoxParticles = new System.Windows.Forms.NumericUpDown();
            this.numberBoxDensity = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxParticleSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxParticles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxDensity)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(24, 62);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(65, 13);
            label3.TabIndex = 6;
            label3.Text = "Particle Size";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(42, 36);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(47, 13);
            label2.TabIndex = 4;
            label2.Text = "Particles";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(86, 13);
            label1.TabIndex = 2;
            label1.Text = "Density Multiplier";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.BackColor = System.Drawing.Color.DarkGray;
            this.buttonGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerate.Location = new System.Drawing.Point(4, 162);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(165, 23);
            this.buttonGenerate.TabIndex = 0;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BackColor = System.Drawing.Color.YellowGreen;
            this.panel.Controls.Add(this.panelColor);
            this.panel.Controls.Add(this.buttonColor);
            this.panel.Controls.Add(this.buttonSave);
            this.panel.Controls.Add(this.buttonClose);
            this.panel.Controls.Add(this.checkBoxClear);
            this.panel.Controls.Add(this.numberBoxParticleSize);
            this.panel.Controls.Add(label3);
            this.panel.Controls.Add(this.numberBoxParticles);
            this.panel.Controls.Add(label2);
            this.panel.Controls.Add(this.numberBoxDensity);
            this.panel.Controls.Add(label1);
            this.panel.Controls.Add(this.buttonGenerate);
            this.panel.Location = new System.Drawing.Point(525, 268);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(172, 192);
            this.panel.TabIndex = 1;
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.Color.White;
            this.panelColor.Location = new System.Drawing.Point(125, 104);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(43, 23);
            this.panelColor.TabIndex = 10;
            // 
            // buttonColor
            // 
            this.buttonColor.BackColor = System.Drawing.Color.DarkGray;
            this.buttonColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColor.Location = new System.Drawing.Point(6, 104);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(116, 23);
            this.buttonColor.TabIndex = 9;
            this.buttonColor.Text = "Particle Color";
            this.buttonColor.UseVisualStyleBackColor = false;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.DarkGray;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Location = new System.Drawing.Point(69, 133);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(99, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save as Image...";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.DarkGray;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(4, 133);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(61, 23);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // checkBoxClear
            // 
            this.checkBoxClear.AutoSize = true;
            this.checkBoxClear.Checked = true;
            this.checkBoxClear.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxClear.Location = new System.Drawing.Point(36, 84);
            this.checkBoxClear.Name = "checkBoxClear";
            this.checkBoxClear.Size = new System.Drawing.Size(114, 17);
            this.checkBoxClear.TabIndex = 2;
            this.checkBoxClear.Text = "Clear On Generate";
            this.checkBoxClear.UseVisualStyleBackColor = true;
            // 
            // numberBoxParticleSize
            // 
            this.numberBoxParticleSize.Location = new System.Drawing.Point(98, 58);
            this.numberBoxParticleSize.Name = "numberBoxParticleSize";
            this.numberBoxParticleSize.Size = new System.Drawing.Size(70, 20);
            this.numberBoxParticleSize.TabIndex = 7;
            this.numberBoxParticleSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numberBoxParticles
            // 
            this.numberBoxParticles.Location = new System.Drawing.Point(98, 32);
            this.numberBoxParticles.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numberBoxParticles.Name = "numberBoxParticles";
            this.numberBoxParticles.Size = new System.Drawing.Size(70, 20);
            this.numberBoxParticles.TabIndex = 5;
            this.numberBoxParticles.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numberBoxDensity
            // 
            this.numberBoxDensity.DecimalPlaces = 2;
            this.numberBoxDensity.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numberBoxDensity.Location = new System.Drawing.Point(98, 6);
            this.numberBoxDensity.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberBoxDensity.Name = "numberBoxDensity";
            this.numberBoxDensity.Size = new System.Drawing.Size(70, 20);
            this.numberBoxDensity.TabIndex = 3;
            this.numberBoxDensity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(709, 472);
            this.Controls.Add(this.panel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxParticleSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxParticles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxDensity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.NumericUpDown numberBoxParticles;
        private System.Windows.Forms.NumericUpDown numberBoxDensity;
        private System.Windows.Forms.NumericUpDown numberBoxParticleSize;
        private System.Windows.Forms.CheckBox checkBoxClear;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Button buttonColor;
    }
}

