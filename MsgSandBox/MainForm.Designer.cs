namespace MsgSandBox
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
            this.components = new System.ComponentModel.Container();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonFreeze = new System.Windows.Forms.CheckBox();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.clmMsgID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMsgIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHWnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLParam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWParam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsData = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLookup = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDump = new System.Windows.Forms.Button();
            this.buttonDeleteDump = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonShowDlg = new System.Windows.Forms.Button();
            this.buttonHideForm = new System.Windows.Forms.Button();
            this.buttonShowForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.cmsData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.Location = new System.Drawing.Point(601, 307);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonFreeze
            // 
            this.buttonFreeze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFreeze.Appearance = System.Windows.Forms.Appearance.Button;
            this.buttonFreeze.Location = new System.Drawing.Point(483, 307);
            this.buttonFreeze.Name = "buttonFreeze";
            this.buttonFreeze.Size = new System.Drawing.Size(112, 23);
            this.buttonFreeze.TabIndex = 3;
            this.buttonFreeze.Text = "Freeze";
            this.buttonFreeze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonFreeze.UseVisualStyleBackColor = true;
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxFilter.Location = new System.Drawing.Point(12, 278);
            this.textBoxFilter.Multiline = true;
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(188, 52);
            this.textBoxFilter.TabIndex = 0;
            this.toolTip.SetToolTip(this.textBoxFilter, "Filters out specific messages by the msg index.\r\n512, 32 and 132 are filtered bec" +
        "ause they are frequently received");
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMsgID,
            this.clmMsgIndex,
            this.clmHWnd,
            this.clmLParam,
            this.clmWParam,
            this.clmResult});
            this.dataGridView.ContextMenuStrip = this.cmsData;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView.Size = new System.Drawing.Size(663, 235);
            this.dataGridView.TabIndex = 8;
            // 
            // clmMsgID
            // 
            this.clmMsgID.FillWeight = 150.6698F;
            this.clmMsgID.HeaderText = "Msg ID";
            this.clmMsgID.Name = "clmMsgID";
            // 
            // clmMsgIndex
            // 
            this.clmMsgIndex.FillWeight = 91.37056F;
            this.clmMsgIndex.HeaderText = "Msg Index";
            this.clmMsgIndex.Name = "clmMsgIndex";
            // 
            // clmHWnd
            // 
            this.clmHWnd.FillWeight = 110.6698F;
            this.clmHWnd.HeaderText = "HWnd";
            this.clmHWnd.Name = "clmHWnd";
            // 
            // clmLParam
            // 
            this.clmLParam.FillWeight = 110.6698F;
            this.clmLParam.HeaderText = "LParam";
            this.clmLParam.Name = "clmLParam";
            // 
            // clmWParam
            // 
            this.clmWParam.FillWeight = 110.6698F;
            this.clmWParam.HeaderText = "WParam";
            this.clmWParam.Name = "clmWParam";
            // 
            // clmResult
            // 
            this.clmResult.FillWeight = 65.95026F;
            this.clmResult.HeaderText = "Result";
            this.clmResult.Name = "clmResult";
            // 
            // cmsData
            // 
            this.cmsData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFilter,
            this.tsmiLookup});
            this.cmsData.Name = "cmsData";
            this.cmsData.Size = new System.Drawing.Size(126, 48);
            // 
            // tsmiFilter
            // 
            this.tsmiFilter.Name = "tsmiFilter";
            this.tsmiFilter.Size = new System.Drawing.Size(125, 22);
            this.tsmiFilter.Text = "Filter This";
            this.tsmiFilter.Click += new System.EventHandler(this.menuItemFilter_Click);
            // 
            // tsmiLookup
            // 
            this.tsmiLookup.Name = "tsmiLookup";
            this.tsmiLookup.Size = new System.Drawing.Size(125, 22);
            this.tsmiLookup.Text = "Lookup";
            this.tsmiLookup.Click += new System.EventHandler(this.menuItemLookup_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Msg Filter";
            // 
            // buttonDump
            // 
            this.buttonDump.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDump.Location = new System.Drawing.Point(601, 278);
            this.buttonDump.Name = "buttonDump";
            this.buttonDump.Size = new System.Drawing.Size(75, 23);
            this.buttonDump.TabIndex = 10;
            this.buttonDump.Text = "Dump";
            this.buttonDump.UseVisualStyleBackColor = true;
            this.buttonDump.Click += new System.EventHandler(this.buttonDump_Click);
            // 
            // buttonDeleteDump
            // 
            this.buttonDeleteDump.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteDump.Location = new System.Drawing.Point(483, 278);
            this.buttonDeleteDump.Name = "buttonDeleteDump";
            this.buttonDeleteDump.Size = new System.Drawing.Size(112, 23);
            this.buttonDeleteDump.TabIndex = 11;
            this.buttonDeleteDump.Text = "Delete Dump";
            this.buttonDeleteDump.UseVisualStyleBackColor = true;
            this.buttonDeleteDump.Click += new System.EventHandler(this.buttonDeleteDump_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.buttonShowDlg);
            this.groupBox1.Controls.Add(this.buttonHideForm);
            this.groupBox1.Controls.Add(this.buttonShowForm);
            this.groupBox1.Location = new System.Drawing.Point(206, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 77);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SandBox Form";
            // 
            // buttonShowDlg
            // 
            this.buttonShowDlg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonShowDlg.Location = new System.Drawing.Point(81, 19);
            this.buttonShowDlg.Name = "buttonShowDlg";
            this.buttonShowDlg.Size = new System.Drawing.Size(90, 23);
            this.buttonShowDlg.TabIndex = 15;
            this.buttonShowDlg.Text = "ShowDialog";
            this.buttonShowDlg.UseVisualStyleBackColor = true;
            this.buttonShowDlg.Click += new System.EventHandler(this.btnShowDlg_Click);
            // 
            // buttonHideForm
            // 
            this.buttonHideForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonHideForm.Location = new System.Drawing.Point(6, 48);
            this.buttonHideForm.Name = "buttonHideForm";
            this.buttonHideForm.Size = new System.Drawing.Size(69, 23);
            this.buttonHideForm.TabIndex = 14;
            this.buttonHideForm.Text = "Hide";
            this.buttonHideForm.UseVisualStyleBackColor = true;
            this.buttonHideForm.Click += new System.EventHandler(this.buttonHideForm_Click);
            // 
            // buttonShowForm
            // 
            this.buttonShowForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonShowForm.Location = new System.Drawing.Point(6, 19);
            this.buttonShowForm.Name = "buttonShowForm";
            this.buttonShowForm.Size = new System.Drawing.Size(69, 23);
            this.buttonShowForm.TabIndex = 13;
            this.buttonShowForm.Text = "Show";
            this.buttonShowForm.UseVisualStyleBackColor = true;
            this.buttonShowForm.Click += new System.EventHandler(this.buttonShowForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 342);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonDeleteDump);
            this.Controls.Add(this.buttonDump);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonFreeze);
            this.Controls.Add(this.buttonClear);
            this.MinimumSize = new System.Drawing.Size(622, 255);
            this.Name = "MainForm";
            this.Text = "Msg SandBox";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.cmsData.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.CheckBox buttonFreeze;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDump;
        private System.Windows.Forms.Button buttonDeleteDump;
        private System.Windows.Forms.ContextMenuStrip cmsData;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilter;
        private System.Windows.Forms.ToolStripMenuItem tsmiLookup;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMsgID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMsgIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHWnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLParam;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWParam;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonShowDlg;
        private System.Windows.Forms.Button buttonHideForm;
        private System.Windows.Forms.Button buttonShowForm;
    }
}

