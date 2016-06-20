namespace WebFilesEnhanced
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonPickFont = new System.Windows.Forms.Button();
            this.checkBoxHorizSplitView = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonClose.Location = new System.Drawing.Point(156, 82);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // buttonPickFont
            // 
            this.buttonPickFont.Location = new System.Drawing.Point(12, 12);
            this.buttonPickFont.Name = "buttonPickFont";
            this.buttonPickFont.Size = new System.Drawing.Size(219, 23);
            this.buttonPickFont.TabIndex = 4;
            this.buttonPickFont.Text = "Pick Editor Font...";
            this.buttonPickFont.UseVisualStyleBackColor = true;
            this.buttonPickFont.Click += new System.EventHandler(this.buttonPickFont_Click);
            // 
            // checkBoxHorizSplitView
            // 
            this.checkBoxHorizSplitView.AutoSize = true;
            this.checkBoxHorizSplitView.Location = new System.Drawing.Point(12, 50);
            this.checkBoxHorizSplitView.Name = "checkBoxHorizSplitView";
            this.checkBoxHorizSplitView.Size = new System.Drawing.Size(144, 17);
            this.checkBoxHorizSplitView.TabIndex = 6;
            this.checkBoxHorizSplitView.Text = "Use Horizontal Split View";
            this.checkBoxHorizSplitView.UseVisualStyleBackColor = true;
            this.checkBoxHorizSplitView.CheckedChanged += new System.EventHandler(this.checkBoxHorizSplitView_CheckedChanged);
            // 
            // SettingsDialog
            // 
            this.AcceptButton = this.buttonClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 117);
            this.Controls.Add(this.checkBoxHorizSplitView);
            this.Controls.Add(this.buttonPickFont);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonPickFont;
        private System.Windows.Forms.CheckBox checkBoxHorizSplitView;
    }
}