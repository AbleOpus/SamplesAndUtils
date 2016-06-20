namespace WordListProc
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
            this.textBoxWords = new System.Windows.Forms.TextBox();
            this.comboSortMode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboFormat = new System.Windows.Forms.ComboBox();
            this.toolstrip = new System.Windows.Forms.ToolStrip();
            this.buttonRemoveDuplicates = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonToLower = new System.Windows.Forms.ToolStripButton();
            this.buttonToUpper = new System.Windows.Forms.ToolStripButton();
            this.buttonCapFirstLets = new System.Windows.Forms.ToolStripButton();
            this.buttonSort = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonReverse = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.labelWordCount = new System.Windows.Forms.Label();
            this.toolstrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxWords
            // 
            this.textBoxWords.AcceptsReturn = true;
            this.textBoxWords.AcceptsTab = true;
            this.textBoxWords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWords.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWords.Location = new System.Drawing.Point(12, 28);
            this.textBoxWords.Multiline = true;
            this.textBoxWords.Name = "textBoxWords";
            this.textBoxWords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxWords.Size = new System.Drawing.Size(642, 271);
            this.textBoxWords.TabIndex = 0;
            this.textBoxWords.Text = "This is a test.";
            // 
            // comboSortMode
            // 
            this.comboSortMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboSortMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSortMode.FormattingEnabled = true;
            this.comboSortMode.Items.AddRange(new object[] {
            "None",
            "A-Z",
            "Z-A",
            "Length",
            "Length Descending"});
            this.comboSortMode.Location = new System.Drawing.Point(484, 334);
            this.comboSortMode.Name = "comboSortMode";
            this.comboSortMode.Size = new System.Drawing.Size(173, 23);
            this.comboSortMode.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sort Mode";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Format";
            // 
            // comboFormat
            // 
            this.comboFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFormat.FormattingEnabled = true;
            this.comboFormat.Items.AddRange(new object[] {
            "Spaced",
            "Line Separated",
            "Comma Separated"});
            this.comboFormat.Location = new System.Drawing.Point(484, 305);
            this.comboFormat.Name = "comboFormat";
            this.comboFormat.Size = new System.Drawing.Size(173, 23);
            this.comboFormat.TabIndex = 6;
            // 
            // toolstrip
            // 
            this.toolstrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonRemoveDuplicates,
            this.toolStripSeparator1,
            this.buttonCapFirstLets,
            this.toolStripSeparator2,
            this.buttonToLower,
            this.toolStripSeparator3,
            this.buttonToUpper,
            this.toolStripSeparator4,
            this.buttonSort,
            this.toolStripSeparator5,
            this.buttonReverse});
            this.toolstrip.Location = new System.Drawing.Point(0, 0);
            this.toolstrip.Name = "toolstrip";
            this.toolstrip.Padding = new System.Windows.Forms.Padding(6, 0, 1, 0);
            this.toolstrip.Size = new System.Drawing.Size(669, 25);
            this.toolstrip.TabIndex = 11;
            this.toolstrip.Text = "toolstrip";
            // 
            // buttonRemoveDuplicates
            // 
            this.buttonRemoveDuplicates.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonRemoveDuplicates.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoveDuplicates.Image")));
            this.buttonRemoveDuplicates.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonRemoveDuplicates.Name = "buttonRemoveDuplicates";
            this.buttonRemoveDuplicates.Size = new System.Drawing.Size(112, 22);
            this.buttonRemoveDuplicates.Text = "Remove Duplicates";
            this.buttonRemoveDuplicates.Click += new System.EventHandler(this.buttonRemoveDuplicates_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonToLower
            // 
            this.buttonToLower.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonToLower.Image = ((System.Drawing.Image)(resources.GetObject("buttonToLower.Image")));
            this.buttonToLower.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonToLower.Name = "buttonToLower";
            this.buttonToLower.Size = new System.Drawing.Size(59, 22);
            this.buttonToLower.Text = "To Lower";
            this.buttonToLower.Click += new System.EventHandler(this.buttonToLower_Click);
            // 
            // buttonToUpper
            // 
            this.buttonToUpper.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonToUpper.Image = ((System.Drawing.Image)(resources.GetObject("buttonToUpper.Image")));
            this.buttonToUpper.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonToUpper.Name = "buttonToUpper";
            this.buttonToUpper.Size = new System.Drawing.Size(59, 22);
            this.buttonToUpper.Text = "To Upper";
            this.buttonToUpper.Click += new System.EventHandler(this.buttonToUpper_Click);
            // 
            // buttonCapFirstLets
            // 
            this.buttonCapFirstLets.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonCapFirstLets.Image = ((System.Drawing.Image)(resources.GetObject("buttonCapFirstLets.Image")));
            this.buttonCapFirstLets.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonCapFirstLets.Name = "buttonCapFirstLets";
            this.buttonCapFirstLets.Size = new System.Drawing.Size(93, 22);
            this.buttonCapFirstLets.Text = "Cap. First Letter";
            this.buttonCapFirstLets.Click += new System.EventHandler(this.buttonCapFirstLet_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonSort.Image = ((System.Drawing.Image)(resources.GetObject("buttonSort.Image")));
            this.buttonSort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(32, 22);
            this.buttonSort.Text = "Sort";
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonReverse
            // 
            this.buttonReverse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonReverse.Image = ((System.Drawing.Image)(resources.GetObject("buttonReverse.Image")));
            this.buttonReverse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonReverse.Name = "buttonReverse";
            this.buttonReverse.Size = new System.Drawing.Size(51, 22);
            this.buttonReverse.Text = "Reverse";
            this.buttonReverse.Click += new System.EventHandler(this.buttonReverse_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // labelWordCount
            // 
            this.labelWordCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelWordCount.AutoSize = true;
            this.labelWordCount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWordCount.Location = new System.Drawing.Point(12, 302);
            this.labelWordCount.Name = "labelWordCount";
            this.labelWordCount.Size = new System.Drawing.Size(0, 20);
            this.labelWordCount.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 369);
            this.Controls.Add(this.labelWordCount);
            this.Controls.Add(this.toolstrip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboFormat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboSortMode);
            this.Controls.Add(this.textBoxWords);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "MainForm";
            this.Text = "Word List Proc";
            this.toolstrip.ResumeLayout(false);
            this.toolstrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxWords;
        private System.Windows.Forms.ComboBox comboSortMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboFormat;
        private System.Windows.Forms.ToolStrip toolstrip;
        private System.Windows.Forms.ToolStripButton buttonRemoveDuplicates;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton buttonCapFirstLets;
        private System.Windows.Forms.ToolStripButton buttonToUpper;
        private System.Windows.Forms.ToolStripButton buttonSort;
        private System.Windows.Forms.ToolStripButton buttonToLower;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton buttonReverse;
        private System.Windows.Forms.Label labelWordCount;
    }
}

