namespace LogFileRemover
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.checkBoxStrictRemoval = new System.Windows.Forms.CheckBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblRemoved = new System.Windows.Forms.Label();
            this.listBoxRemoved = new System.Windows.Forms.ListBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.listBoxUnremovable = new System.Windows.Forms.ListBox();
            this.lblUnremovable = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.logRemover = new LogFileRemover.LogRemover();
            this.SuspendLayout();
            // 
            // checkBoxStrictRemoval
            // 
            this.checkBoxStrictRemoval.AutoSize = true;
            this.checkBoxStrictRemoval.Checked = true;
            this.checkBoxStrictRemoval.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxStrictRemoval.Location = new System.Drawing.Point(15, 16);
            this.checkBoxStrictRemoval.Name = "checkBoxStrictRemoval";
            this.checkBoxStrictRemoval.Size = new System.Drawing.Size(95, 17);
            this.checkBoxStrictRemoval.TabIndex = 0;
            this.checkBoxStrictRemoval.Text = "Strict Removal";
            this.toolTip.SetToolTip(this.checkBoxStrictRemoval, "When checked, the program will delete files with a .log extension.\r\n Otherwise it" +
        " will also delete .txt files with the term \"log\" in the name");
            this.checkBoxStrictRemoval.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.Location = new System.Drawing.Point(325, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Location = new System.Drawing.Point(325, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // lblRemoved
            // 
            this.lblRemoved.AutoSize = true;
            this.lblRemoved.Location = new System.Drawing.Point(12, 46);
            this.lblRemoved.Name = "lblRemoved";
            this.lblRemoved.Size = new System.Drawing.Size(56, 13);
            this.lblRemoved.TabIndex = 7;
            this.lblRemoved.Text = "Removed:";
            // 
            // listBoxRemoved
            // 
            this.listBoxRemoved.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxRemoved.FormattingEnabled = true;
            this.listBoxRemoved.IntegralHeight = false;
            this.listBoxRemoved.Location = new System.Drawing.Point(12, 62);
            this.listBoxRemoved.Name = "listBoxRemoved";
            this.listBoxRemoved.Size = new System.Drawing.Size(388, 110);
            this.listBoxRemoved.TabIndex = 8;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(116, 12);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(203, 23);
            this.progressBar.TabIndex = 9;
            // 
            // listBoxUnremovable
            // 
            this.listBoxUnremovable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxUnremovable.FormattingEnabled = true;
            this.listBoxUnremovable.IntegralHeight = false;
            this.listBoxUnremovable.Location = new System.Drawing.Point(12, 203);
            this.listBoxUnremovable.Name = "listBoxUnremovable";
            this.listBoxUnremovable.Size = new System.Drawing.Size(388, 118);
            this.listBoxUnremovable.TabIndex = 11;
            this.toolTip.SetToolTip(this.listBoxUnremovable, "Double-click an item to open it in your default text editor");
            this.listBoxUnremovable.DoubleClick += new System.EventHandler(this.listBoxUnremovable_DoubleClick);
            // 
            // lblUnremovable
            // 
            this.lblUnremovable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnremovable.AutoSize = true;
            this.lblUnremovable.Location = new System.Drawing.Point(12, 187);
            this.lblUnremovable.Name = "lblUnremovable";
            this.lblUnremovable.Size = new System.Drawing.Size(73, 13);
            this.lblUnremovable.TabIndex = 10;
            this.lblUnremovable.Text = "Unremovable:";
            // 
            // logRemover
            // 
            this.logRemover.WorkerSupportsCancellation = true;
            this.logRemover.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.logRemover_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 333);
            this.Controls.Add(this.listBoxUnremovable);
            this.Controls.Add(this.lblUnremovable);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.listBoxRemoved);
            this.Controls.Add(this.lblRemoved);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.checkBoxStrictRemoval);
            this.Controls.Add(this.btnStop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log File Remover";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxStrictRemoval;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ListBox listBoxRemoved;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ListBox listBoxUnremovable;
        private LogRemover logRemover;
        private System.Windows.Forms.Label lblRemoved;
        private System.Windows.Forms.Label lblUnremovable;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

