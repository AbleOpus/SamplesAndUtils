namespace ShortcutHotkeyEditor
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
            this.testBoxHotkey = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonPickPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // testBoxHotkey
            // 
            this.testBoxHotkey.Location = new System.Drawing.Point(55, 80);
            this.testBoxHotkey.Name = "testBoxHotkey";
            this.testBoxHotkey.Size = new System.Drawing.Size(122, 20);
            this.testBoxHotkey.TabIndex = 0;
            this.testBoxHotkey.Text = "Ctrl+F";
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(183, 80);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(149, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save Changes";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonPickPath
            // 
            this.buttonPickPath.Location = new System.Drawing.Point(12, 12);
            this.buttonPickPath.Name = "buttonPickPath";
            this.buttonPickPath.Size = new System.Drawing.Size(320, 26);
            this.buttonPickPath.TabIndex = 3;
            this.buttonPickPath.Text = "Choose Shortcut (.lnk) ...";
            this.buttonPickPath.UseVisualStyleBackColor = true;
            this.buttonPickPath.Click += new System.EventHandler(this.buttonPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hotkey";
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 115);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPickPath);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.testBoxHotkey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Shortcut Hotkey Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox testBoxHotkey;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonPickPath;
        private System.Windows.Forms.Label label1;
    }
}

