namespace VirtualPianoPlayer
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelKeys = new System.Windows.Forms.Label();
            this.lblInterval = new System.Windows.Forms.Label();
            this.numberBoxInterval = new System.Windows.Forms.NumericUpDown();
            this.timerCountDown = new System.Windows.Forms.Timer(this.components);
            this.buttonPlay = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonOpenPiano = new System.Windows.Forms.ToolStripButton();
            this.comboSongList = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.textBoxNotes = new VirtualPianoPlayer.NotesTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxInterval)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 300;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelKeys
            // 
            this.labelKeys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelKeys.AutoSize = true;
            this.labelKeys.Location = new System.Drawing.Point(14, 241);
            this.labelKeys.Name = "labelKeys";
            this.labelKeys.Size = new System.Drawing.Size(83, 15);
            this.labelKeys.TabIndex = 2;
            this.labelKeys.Text = "Key Note: N/A";
            this.labelKeys.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInterval
            // 
            this.lblInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(330, 241);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(46, 15);
            this.lblInterval.TabIndex = 3;
            this.lblInterval.Text = "Interval";
            // 
            // numberBoxInterval
            // 
            this.numberBoxInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numberBoxInterval.Location = new System.Drawing.Point(389, 238);
            this.numberBoxInterval.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numberBoxInterval.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numberBoxInterval.Name = "numberBoxInterval";
            this.numberBoxInterval.Size = new System.Drawing.Size(97, 23);
            this.numberBoxInterval.TabIndex = 4;
            this.numberBoxInterval.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numberBoxInterval.ValueChanged += new System.EventHandler(this.numberBoxInterval_ValueChanged);
            // 
            // timerCountDown
            // 
            this.timerCountDown.Interval = 1000;
            this.timerCountDown.Tick += new System.EventHandler(this.timerCountDown_Tick);
            // 
            // buttonPlay
            // 
            this.buttonPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonPlay.Image = ((System.Drawing.Image)(resources.GetObject("buttonPlay.Image")));
            this.buttonPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(33, 20);
            this.buttonPlay.Text = "Play";
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // buttonOpenPiano
            // 
            this.buttonOpenPiano.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.buttonOpenPiano.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenPiano.Image")));
            this.buttonOpenPiano.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonOpenPiano.Name = "buttonOpenPiano";
            this.buttonOpenPiano.Size = new System.Drawing.Size(75, 20);
            this.buttonOpenPiano.Text = "Go To Piano";
            this.buttonOpenPiano.Click += new System.EventHandler(this.buttonOpenPiano_Click);
            // 
            // comboSongList
            // 
            this.comboSongList.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.comboSongList.BackColor = System.Drawing.SystemColors.Control;
            this.comboSongList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSongList.Name = "comboSongList";
            this.comboSongList.Size = new System.Drawing.Size(233, 23);
            this.comboSongList.SelectedIndexChanged += new System.EventHandler(this.comboSongList_SelectedIndexChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(34, 20);
            this.toolStripLabel1.Text = "Song";
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonPlay,
            this.toolStripSeparator1,
            this.buttonOpenPiano,
            this.comboSongList,
            this.toolStripLabel1});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(3);
            this.toolStrip.Size = new System.Drawing.Size(500, 29);
            this.toolStrip.TabIndex = 10;
            this.toolStrip.Text = "toolStrip";
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNotes.Location = new System.Drawing.Point(0, 29);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(500, 194);
            this.textBoxNotes.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 275);
            this.Controls.Add(this.textBoxNotes);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.numberBoxInterval);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.labelKeys);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(455, 200);
            this.Name = "MainForm";
            this.Text = "Virtual Piano Player";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.numberBoxInterval)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelKeys;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.NumericUpDown numberBoxInterval;
        private NotesTextBox textBoxNotes;
        private System.Windows.Forms.Timer timerCountDown;
        private System.Windows.Forms.ToolStripButton buttonPlay;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton buttonOpenPiano;
        private System.Windows.Forms.ToolStripComboBox comboSongList;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStrip toolStrip;
    }
}

