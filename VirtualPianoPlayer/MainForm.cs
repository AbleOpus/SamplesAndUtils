using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace VirtualPianoPlayer
{
    public partial class MainForm : Form
    {
        private string[] words, filePaths;
        private int index, countDown = 3;
        private bool starting;

        public MainForm()
        {
            InitializeComponent();
            PopulateSongComboBox();
            words = GetNotes();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            Select();

            if (!starting)
            {
                Stop();
            }
        }

        public string[] GetNotes()
        {
            return textBoxNotes.Text.Split(new[] { ' ', ';' }, StringSplitOptions.RemoveEmptyEntries);
        }

        private static void ShowError(string message) 
        {
                MessageBox.Show(message, Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Stop()
        {
            Select();
            timer.Stop();
            buttonPlay.Enabled = true;
            numberBoxInterval.Enabled = true;
            buttonPlay.Text = "Play";
            textBoxNotes.Enabled = true;
            index = 0;
        }

        private void PopulateSongComboBox()
        {
            if (!Directory.Exists("Songs"))
            {
                MessageBox.Show("No song directory exists.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                filePaths = Directory.GetFiles("Songs");

                foreach (string path in filePaths)
                {
                    comboSongList.Items.Add(Path.GetFileNameWithoutExtension(path));
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (index == words.Length - 1)
            {
                index = 0;
                Stop();
            }

            string note = words[index];
            SendKeys.Send(note);
            index++;
            labelKeys.Text = "Key Note: " + note;
        }


        private void timerCountDown_Tick(object sender, EventArgs e)
        {
            buttonPlay.Text = countDown.ToString();

            if (countDown == 1)
            {
                timerCountDown.Stop();
                countDown = 3;
                buttonPlay.Text = "Playing";
                timer.Start();
                starting = false;
            }
            else
            {
                countDown--;
            }
        }

        private void numberBoxInterval_ValueChanged(object sender, EventArgs e)
        {
            timer.Interval = (int)numberBoxInterval.Value;
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (textBoxNotes.Text == string.Empty)
            {
                ShowError("No notes to play.");
                return;
            }

            words = GetNotes();
            starting = true;
            numberBoxInterval.Enabled = false;
            buttonPlay.Enabled = false;
            textBoxNotes.Enabled = false;
            timerCountDown.Start();
        }

        private void comboSongList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedFileName = filePaths[comboSongList.SelectedIndex];
                textBoxNotes.Text = File.ReadAllText(selectedFileName);
                words = GetNotes();
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }

        private void buttonOpenPiano_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("http://virtualpiano.net/");
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
        }
    }
}