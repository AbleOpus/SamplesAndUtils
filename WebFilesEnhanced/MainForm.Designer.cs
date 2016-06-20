namespace WebFilesEnhanced
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
            this.upperToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnNewFile = new System.Windows.Forms.ToolStripButton();
            this.btnLoadSite = new System.Windows.Forms.ToolStripButton();
            this.btnCloseSite = new System.Windows.Forms.ToolStripButton();
            this.btnExploreSite = new System.Windows.Forms.ToolStripButton();
            this.btnSettings = new System.Windows.Forms.ToolStripButton();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panelCodeBoxPadder = new System.Windows.Forms.Panel();
            this.richTextBoxCode = new System.Windows.Forms.RichTextBox();
            this.webBrowser = new WebFilesEnhanced.ZoomBrowser();
            this.lowerToolStrip = new System.Windows.Forms.ToolStrip();
            this.comboEditFile = new System.Windows.Forms.ToolStripComboBox();
            this.comboPreviewFile = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiZoomFactor = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmi100 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi80 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi60 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi40 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi20 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.upperToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panelCodeBoxPadder.SuspendLayout();
            this.lowerToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // upperToolStrip
            // 
            this.upperToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.upperToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewFile,
            this.btnLoadSite,
            this.btnCloseSite,
            this.btnExploreSite,
            this.btnSettings});
            this.upperToolStrip.Location = new System.Drawing.Point(0, 0);
            this.upperToolStrip.Name = "upperToolStrip";
            this.upperToolStrip.Size = new System.Drawing.Size(918, 25);
            this.upperToolStrip.TabIndex = 0;
            // 
            // btnNewFile
            // 
            this.btnNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnNewFile.Enabled = false;
            this.btnNewFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNewFile.Name = "btnNewFile";
            this.btnNewFile.Size = new System.Drawing.Size(56, 22);
            this.btnNewFile.Text = "New File";
            this.btnNewFile.Click += new System.EventHandler(this.buttonNewFile_Click);
            // 
            // btnLoadSite
            // 
            this.btnLoadSite.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLoadSite.Name = "btnLoadSite";
            this.btnLoadSite.Size = new System.Drawing.Size(91, 22);
            this.btnLoadSite.Text = "Load Website...";
            this.btnLoadSite.Click += new System.EventHandler(this.buttonOpenDir_Click);
            // 
            // btnCloseSite
            // 
            this.btnCloseSite.Enabled = false;
            this.btnCloseSite.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCloseSite.Name = "btnCloseSite";
            this.btnCloseSite.Size = new System.Drawing.Size(86, 22);
            this.btnCloseSite.Text = "Close WebSite";
            this.btnCloseSite.Click += new System.EventHandler(this.buttonCloseWebSite_Click);
            // 
            // btnExploreSite
            // 
            this.btnExploreSite.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExploreSite.Name = "btnExploreSite";
            this.btnExploreSite.Size = new System.Drawing.Size(94, 22);
            this.btnExploreSite.Text = "Explore Website";
            this.btnExploreSite.Click += new System.EventHandler(this.buttonExplore_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(62, 22);
            this.btnSettings.Text = "Settings...";
            this.btnSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.Color.YellowGreen;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 50);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.panelCodeBoxPadder);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.webBrowser);
            this.splitContainer.Size = new System.Drawing.Size(918, 445);
            this.splitContainer.SplitterDistance = 457;
            this.splitContainer.SplitterWidth = 8;
            this.splitContainer.TabIndex = 1;
            this.splitContainer.TabStop = false;
            // 
            // panelCodeBoxPadder
            // 
            this.panelCodeBoxPadder.BackColor = System.Drawing.SystemColors.Window;
            this.panelCodeBoxPadder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCodeBoxPadder.Controls.Add(this.richTextBoxCode);
            this.panelCodeBoxPadder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCodeBoxPadder.Location = new System.Drawing.Point(0, 0);
            this.panelCodeBoxPadder.Name = "panelCodeBoxPadder";
            this.panelCodeBoxPadder.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panelCodeBoxPadder.Size = new System.Drawing.Size(457, 445);
            this.panelCodeBoxPadder.TabIndex = 1;
            // 
            // richTextBoxCode
            // 
            this.richTextBoxCode.AcceptsTab = true;
            this.richTextBoxCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxCode.Location = new System.Drawing.Point(0, 3);
            this.richTextBoxCode.Name = "richTextBoxCode";
            this.richTextBoxCode.ShowSelectionMargin = true;
            this.richTextBoxCode.Size = new System.Drawing.Size(455, 437);
            this.richTextBoxCode.TabIndex = 0;
            this.richTextBoxCode.Text = "";
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(453, 445);
            this.webBrowser.TabIndex = 0;
            // 
            // lowerToolStrip
            // 
            this.lowerToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.lowerToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comboEditFile,
            this.comboPreviewFile,
            this.toolStripLabel2,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.tsmiZoomFactor,
            this.toolStripSeparator1});
            this.lowerToolStrip.Location = new System.Drawing.Point(0, 25);
            this.lowerToolStrip.Name = "lowerToolStrip";
            this.lowerToolStrip.Size = new System.Drawing.Size(918, 25);
            this.lowerToolStrip.TabIndex = 2;
            this.lowerToolStrip.Text = "toolStrip2";
            // 
            // comboEditFile
            // 
            this.comboEditFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(192)))), ((int)(((byte)(31)))));
            this.comboEditFile.DropDownHeight = 100;
            this.comboEditFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEditFile.Enabled = false;
            this.comboEditFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboEditFile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEditFile.ForeColor = System.Drawing.Color.White;
            this.comboEditFile.IntegralHeight = false;
            this.comboEditFile.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.comboEditFile.Name = "comboEditFile";
            this.comboEditFile.Size = new System.Drawing.Size(121, 25);
            this.comboEditFile.SelectedIndexChanged += new System.EventHandler(this.comboSelectEditFile_SelectedIndexChanged);
            // 
            // comboPreviewFile
            // 
            this.comboPreviewFile.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.comboPreviewFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(192)))), ((int)(((byte)(31)))));
            this.comboPreviewFile.DropDownHeight = 100;
            this.comboPreviewFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPreviewFile.Enabled = false;
            this.comboPreviewFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboPreviewFile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPreviewFile.ForeColor = System.Drawing.Color.White;
            this.comboPreviewFile.IntegralHeight = false;
            this.comboPreviewFile.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.comboPreviewFile.Name = "comboPreviewFile";
            this.comboPreviewFile.Size = new System.Drawing.Size(121, 25);
            this.comboPreviewFile.SelectedIndexChanged += new System.EventHandler(this.comboSelectPreviewFile_SelectedIndexChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.ForeColor = System.Drawing.Color.Olive;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(63, 22);
            this.toolStripLabel2.Text = "Text Editor";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Olive;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(77, 22);
            this.toolStripLabel1.Text = "Page Preview";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsmiZoomFactor
            // 
            this.tsmiZoomFactor.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiZoomFactor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi100,
            this.tsmi80,
            this.tsmi60,
            this.tsmi40,
            this.tsmi20});
            this.tsmiZoomFactor.Enabled = false;
            this.tsmiZoomFactor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiZoomFactor.Name = "tsmiZoomFactor";
            this.tsmiZoomFactor.Size = new System.Drawing.Size(88, 22);
            this.tsmiZoomFactor.Text = "Zoom Factor";
            // 
            // tsmi100
            // 
            this.tsmi100.Checked = true;
            this.tsmi100.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmi100.Name = "tsmi100";
            this.tsmi100.Size = new System.Drawing.Size(150, 22);
            this.tsmi100.Tag = "100";
            this.tsmi100.Text = "100% (default)";
            this.tsmi100.Click += new System.EventHandler(this.ZoomItems_Click);
            // 
            // tsmi80
            // 
            this.tsmi80.Name = "tsmi80";
            this.tsmi80.Size = new System.Drawing.Size(150, 22);
            this.tsmi80.Tag = "80";
            this.tsmi80.Text = "80%";
            this.tsmi80.Click += new System.EventHandler(this.ZoomItems_Click);
            // 
            // tsmi60
            // 
            this.tsmi60.Name = "tsmi60";
            this.tsmi60.Size = new System.Drawing.Size(150, 22);
            this.tsmi60.Tag = "60";
            this.tsmi60.Text = "60%";
            this.tsmi60.Click += new System.EventHandler(this.ZoomItems_Click);
            // 
            // tsmi40
            // 
            this.tsmi40.Name = "tsmi40";
            this.tsmi40.Size = new System.Drawing.Size(150, 22);
            this.tsmi40.Tag = "40";
            this.tsmi40.Text = "40%";
            this.tsmi40.Click += new System.EventHandler(this.ZoomItems_Click);
            // 
            // tsmi20
            // 
            this.tsmi20.Name = "tsmi20";
            this.tsmi20.Size = new System.Drawing.Size(150, 22);
            this.tsmi20.Tag = "20";
            this.tsmi20.Text = "20%";
            this.tsmi20.Click += new System.EventHandler(this.ZoomItems_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 495);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.lowerToolStrip);
            this.Controls.Add(this.upperToolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(692, 377);
            this.Name = "MainForm";
            this.Text = "Web Files Enhanced";
            this.upperToolStrip.ResumeLayout(false);
            this.upperToolStrip.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panelCodeBoxPadder.ResumeLayout(false);
            this.lowerToolStrip.ResumeLayout(false);
            this.lowerToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip upperToolStrip;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ToolStrip lowerToolStrip;
        private System.Windows.Forms.ToolStripComboBox comboEditFile;
        private System.Windows.Forms.ToolStripComboBox comboPreviewFile;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private ZoomBrowser webBrowser;
        private System.Windows.Forms.ToolStripDropDownButton tsmiZoomFactor;
        private System.Windows.Forms.ToolStripMenuItem tsmi100;
        private System.Windows.Forms.ToolStripMenuItem tsmi80;
        private System.Windows.Forms.ToolStripMenuItem tsmi60;
        private System.Windows.Forms.ToolStripMenuItem tsmi40;
        private System.Windows.Forms.ToolStripMenuItem tsmi20;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnNewFile;
        private System.Windows.Forms.ToolStripButton btnLoadSite;
        private System.Windows.Forms.ToolStripButton btnSettings;
        private System.Windows.Forms.ToolStripButton btnExploreSite;
        private System.Windows.Forms.ToolStripButton btnCloseSite;
        private System.Windows.Forms.Panel panelCodeBoxPadder;
        private System.Windows.Forms.RichTextBox richTextBoxCode;
    }
}

