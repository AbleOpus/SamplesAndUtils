namespace IniEditingDemo
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
            this.textBoxContent = new System.Windows.Forms.RichTextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSection = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNewValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKeyName = new System.Windows.Forms.TextBox();
            this.buttonModifyKey = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonRemoveComments = new System.Windows.Forms.Button();
            this.buttonFormatBlankLines = new System.Windows.Forms.Button();
            this.buttonIndentAll = new System.Windows.Forms.Button();
            this.buttonUnIndentAll = new System.Windows.Forms.Button();
            this.buttonRemoveKey = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonRemoveEmpty = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxContent
            // 
            this.textBoxContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxContent.Location = new System.Drawing.Point(12, 12);
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.ReadOnly = true;
            this.textBoxContent.Size = new System.Drawing.Size(678, 300);
            this.textBoxContent.TabIndex = 0;
            this.textBoxContent.Text = "";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoad.Location = new System.Drawing.Point(534, 434);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Load...";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxSection);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxNewValue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxKeyName);
            this.groupBox1.Location = new System.Drawing.Point(12, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 107);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Key Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Section";
            // 
            // textBoxSection
            // 
            this.textBoxSection.Location = new System.Drawing.Point(80, 22);
            this.textBoxSection.Name = "textBoxSection";
            this.textBoxSection.Size = new System.Drawing.Size(128, 20);
            this.textBoxSection.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Value";
            // 
            // textBoxNewValue
            // 
            this.textBoxNewValue.Location = new System.Drawing.Point(80, 74);
            this.textBoxNewValue.Name = "textBoxNewValue";
            this.textBoxNewValue.Size = new System.Drawing.Size(128, 20);
            this.textBoxNewValue.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Key Name";
            // 
            // textBoxKeyName
            // 
            this.textBoxKeyName.Location = new System.Drawing.Point(80, 48);
            this.textBoxKeyName.Name = "textBoxKeyName";
            this.textBoxKeyName.Size = new System.Drawing.Size(128, 20);
            this.textBoxKeyName.TabIndex = 0;
            // 
            // buttonModifyKey
            // 
            this.buttonModifyKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonModifyKey.Location = new System.Drawing.Point(12, 434);
            this.buttonModifyKey.Name = "buttonModifyKey";
            this.buttonModifyKey.Size = new System.Drawing.Size(75, 23);
            this.buttonModifyKey.TabIndex = 4;
            this.buttonModifyKey.Text = "Modify";
            this.toolTip.SetToolTip(this.buttonModifyKey, "Change the specified key to the specified value.");
            this.buttonModifyKey.UseVisualStyleBackColor = true;
            this.buttonModifyKey.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(615, 434);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonRemoveComments
            // 
            this.buttonRemoveComments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveComments.Location = new System.Drawing.Point(351, 318);
            this.buttonRemoveComments.Name = "buttonRemoveComments";
            this.buttonRemoveComments.Size = new System.Drawing.Size(141, 23);
            this.buttonRemoveComments.TabIndex = 6;
            this.buttonRemoveComments.Text = "Remove Comments";
            this.toolTip.SetToolTip(this.buttonRemoveComments, "Removes all comments.");
            this.buttonRemoveComments.UseVisualStyleBackColor = true;
            this.buttonRemoveComments.Click += new System.EventHandler(this.buttonRemoveComment_Click);
            // 
            // buttonFormatBlankLines
            // 
            this.buttonFormatBlankLines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFormatBlankLines.Location = new System.Drawing.Point(351, 347);
            this.buttonFormatBlankLines.Name = "buttonFormatBlankLines";
            this.buttonFormatBlankLines.Size = new System.Drawing.Size(141, 23);
            this.buttonFormatBlankLines.TabIndex = 7;
            this.buttonFormatBlankLines.Text = "Format Blank Lines";
            this.toolTip.SetToolTip(this.buttonFormatBlankLines, "Removes all unnecessary newlines and ensures that\r\nthere is one newline is betwee" +
        "n each section.");
            this.buttonFormatBlankLines.UseVisualStyleBackColor = true;
            this.buttonFormatBlankLines.Click += new System.EventHandler(this.buttonFormatBlankLines_Click);
            // 
            // buttonIndentAll
            // 
            this.buttonIndentAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIndentAll.Location = new System.Drawing.Point(351, 376);
            this.buttonIndentAll.Name = "buttonIndentAll";
            this.buttonIndentAll.Size = new System.Drawing.Size(141, 23);
            this.buttonIndentAll.TabIndex = 8;
            this.buttonIndentAll.Text = "Indent All";
            this.toolTip.SetToolTip(this.buttonIndentAll, "Indents all pairs with a tab character.\r\nNote: original indents are discarded.");
            this.buttonIndentAll.UseVisualStyleBackColor = true;
            this.buttonIndentAll.Click += new System.EventHandler(this.buttonIndentAll_Click);
            // 
            // buttonUnIndentAll
            // 
            this.buttonUnIndentAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUnIndentAll.Location = new System.Drawing.Point(351, 405);
            this.buttonUnIndentAll.Name = "buttonUnIndentAll";
            this.buttonUnIndentAll.Size = new System.Drawing.Size(141, 23);
            this.buttonUnIndentAll.TabIndex = 9;
            this.buttonUnIndentAll.Text = "Un-indent All";
            this.toolTip.SetToolTip(this.buttonUnIndentAll, "Unindents all pairs by one tab character.");
            this.buttonUnIndentAll.UseVisualStyleBackColor = true;
            this.buttonUnIndentAll.Click += new System.EventHandler(this.buttonUnIndentAll_Click);
            // 
            // buttonRemoveKey
            // 
            this.buttonRemoveKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemoveKey.Location = new System.Drawing.Point(93, 434);
            this.buttonRemoveKey.Name = "buttonRemoveKey";
            this.buttonRemoveKey.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveKey.TabIndex = 7;
            this.buttonRemoveKey.Text = "Remove";
            this.toolTip.SetToolTip(this.buttonRemoveKey, "Remove the specified key.");
            this.buttonRemoveKey.UseVisualStyleBackColor = true;
            this.buttonRemoveKey.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelInfo.Location = new System.Drawing.Point(498, 318);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(192, 110);
            this.labelInfo.TabIndex = 10;
            // 
            // buttonRemoveEmpty
            // 
            this.buttonRemoveEmpty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveEmpty.Location = new System.Drawing.Point(351, 434);
            this.buttonRemoveEmpty.Name = "buttonRemoveEmpty";
            this.buttonRemoveEmpty.Size = new System.Drawing.Size(141, 23);
            this.buttonRemoveEmpty.TabIndex = 11;
            this.buttonRemoveEmpty.Text = "Remove Empty";
            this.toolTip.SetToolTip(this.buttonRemoveEmpty, "Removes keys that have no value set.\r\nExample: Foo=");
            this.buttonRemoveEmpty.UseVisualStyleBackColor = true;
            this.buttonRemoveEmpty.Click += new System.EventHandler(this.buttonRemoveEmpty_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 469);
            this.Controls.Add(this.buttonRemoveEmpty);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonUnIndentAll);
            this.Controls.Add(this.buttonIndentAll);
            this.Controls.Add(this.buttonRemoveKey);
            this.Controls.Add(this.buttonModifyKey);
            this.Controls.Add(this.buttonFormatBlankLines);
            this.Controls.Add(this.buttonRemoveComments);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.textBoxContent);
            this.MinimumSize = new System.Drawing.Size(615, 268);
            this.Name = "MainForm";
            this.Text = "Ini Editor Demo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBoxContent;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonModifyKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNewValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKeyName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRemoveComments;
        private System.Windows.Forms.Button buttonFormatBlankLines;
        private System.Windows.Forms.Button buttonIndentAll;
        private System.Windows.Forms.Button buttonUnIndentAll;
        private System.Windows.Forms.Button buttonRemoveKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSection;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonRemoveEmpty;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

