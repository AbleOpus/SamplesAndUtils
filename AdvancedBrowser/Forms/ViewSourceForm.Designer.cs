namespace AdvancedWebBrowser.Forms
{
    partial class ViewSourceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSourceForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuItemFileToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemWordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHighlight = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFont = new System.Windows.Forms.ToolStripMenuItem();
            this.richColoredTextBox = new AdvancedWebBrowser.Forms.RichColoredTextBox();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFileToolStrip,
            this.viewToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 1;
            // 
            // menuItemFileToolStrip
            // 
            this.menuItemFileToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSaveAs,
            this.menuItemExit});
            this.menuItemFileToolStrip.Name = "menuItemFileToolStrip";
            this.menuItemFileToolStrip.Size = new System.Drawing.Size(37, 20);
            this.menuItemFileToolStrip.Text = "&File";
            // 
            // menuItemSaveAs
            // 
            this.menuItemSaveAs.Image = global::AdvancedWebBrowser.Properties.Resources.Save;
            this.menuItemSaveAs.Name = "menuItemSaveAs";
            this.menuItemSaveAs.Size = new System.Drawing.Size(123, 22);
            this.menuItemSaveAs.Text = "&Save As...";
            this.menuItemSaveAs.Click += new System.EventHandler(this.menuItemSaveAs_Click);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(123, 22);
            this.menuItemExit.Text = "&Exit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemWordWrap,
            this.menuItemHighlight,
            this.menuItemFont});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // menuItemWordWrap
            // 
            this.menuItemWordWrap.CheckOnClick = true;
            this.menuItemWordWrap.Image = global::AdvancedWebBrowser.Properties.Resources.WordWrap;
            this.menuItemWordWrap.Name = "menuItemWordWrap";
            this.menuItemWordWrap.Size = new System.Drawing.Size(161, 22);
            this.menuItemWordWrap.Text = "&Word Wrap";
            // 
            // menuItemHighlight
            // 
            this.menuItemHighlight.CheckOnClick = true;
            this.menuItemHighlight.Name = "menuItemHighlight";
            this.menuItemHighlight.Size = new System.Drawing.Size(161, 22);
            this.menuItemHighlight.Text = "&Highlight Syntax";
            // 
            // menuItemFont
            // 
            this.menuItemFont.Image = global::AdvancedWebBrowser.Properties.Resources.Font;
            this.menuItemFont.Name = "menuItemFont";
            this.menuItemFont.Size = new System.Drawing.Size(161, 22);
            this.menuItemFont.Text = "&Font...";
            this.menuItemFont.Click += new System.EventHandler(this.menuItemFont_Click);
            // 
            // richColoredTextBox
            // 
            this.richColoredTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.richColoredTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richColoredTextBox.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richColoredTextBox.Highlighter = null;
            this.richColoredTextBox.HighlighterEnabled = false;
            this.richColoredTextBox.Location = new System.Drawing.Point(0, 24);
            this.richColoredTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.richColoredTextBox.Name = "richColoredTextBox";
            this.richColoredTextBox.ReadOnly = true;
            this.richColoredTextBox.Size = new System.Drawing.Size(632, 447);
            this.richColoredTextBox.TabIndex = 0;
            this.richColoredTextBox.Text = "";
            this.richColoredTextBox.WordWrap = false;
            // 
            // ViewSourceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 471);
            this.Controls.Add(this.richColoredTextBox);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "ViewSourceForm";
            this.Text = "View Source";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichColoredTextBox richColoredTextBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemWordWrap;
        private System.Windows.Forms.ToolStripMenuItem menuItemFont;
        private System.Windows.Forms.ToolStripMenuItem menuItemHighlight;
        private System.Windows.Forms.ToolStripMenuItem menuItemFileToolStrip;
        private System.Windows.Forms.ToolStripMenuItem menuItemSaveAs;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;

    }
}