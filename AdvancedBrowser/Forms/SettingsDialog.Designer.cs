namespace AdvancedWebBrowser.Forms
{
    partial class SettingsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsDialog));
            this.textBoxHomepage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxHistory = new System.Windows.Forms.CheckBox();
            this.buttonClearHistory = new System.Windows.Forms.Button();
            this.checkBoxShowBookmarks = new System.Windows.Forms.CheckBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxHomepage
            // 
            this.textBoxHomepage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHomepage.Location = new System.Drawing.Point(74, 11);
            this.textBoxHomepage.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHomepage.Name = "textBoxHomepage";
            this.textBoxHomepage.Size = new System.Drawing.Size(163, 20);
            this.textBoxHomepage.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Homepage";
            // 
            // checkBoxHistory
            // 
            this.checkBoxHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxHistory.AutoSize = true;
            this.checkBoxHistory.Location = new System.Drawing.Point(11, 67);
            this.checkBoxHistory.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxHistory.Name = "checkBoxHistory";
            this.checkBoxHistory.Size = new System.Drawing.Size(89, 17);
            this.checkBoxHistory.TabIndex = 2;
            this.checkBoxHistory.Text = "Track History";
            this.checkBoxHistory.UseVisualStyleBackColor = true;
            // 
            // buttonClearHistory
            // 
            this.buttonClearHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearHistory.Location = new System.Drawing.Point(162, 56);
            this.buttonClearHistory.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClearHistory.Name = "buttonClearHistory";
            this.buttonClearHistory.Size = new System.Drawing.Size(75, 23);
            this.buttonClearHistory.TabIndex = 3;
            this.buttonClearHistory.Text = "Clear History";
            this.buttonClearHistory.UseVisualStyleBackColor = true;
            this.buttonClearHistory.Click += new System.EventHandler(this.buttonClearHistory_Click);
            // 
            // checkBoxShowBookmarks
            // 
            this.checkBoxShowBookmarks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxShowBookmarks.AutoSize = true;
            this.checkBoxShowBookmarks.Location = new System.Drawing.Point(11, 89);
            this.checkBoxShowBookmarks.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxShowBookmarks.Name = "checkBoxShowBookmarks";
            this.checkBoxShowBookmarks.Size = new System.Drawing.Size(109, 17);
            this.checkBoxShowBookmarks.TabIndex = 4;
            this.checkBoxShowBookmarks.Text = "Show Bookmarks";
            this.checkBoxShowBookmarks.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReset.Location = new System.Drawing.Point(162, 83);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 117);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.checkBoxShowBookmarks);
            this.Controls.Add(this.buttonClearHistory);
            this.Controls.Add(this.checkBoxHistory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxHomepage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHomepage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxHistory;
        private System.Windows.Forms.Button buttonClearHistory;
        private System.Windows.Forms.CheckBox checkBoxShowBookmarks;
        private System.Windows.Forms.Button buttonReset;
    }
}