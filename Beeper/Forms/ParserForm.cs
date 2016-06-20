using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Beeper.Properties;

namespace Beeper.Forms
{
    public partial class ParserForm : StyledForm
    {
        public ParserForm()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            switch (Settings.Default.ParseModeIndex)
            {
                case 0: radioCode.Checked = true; break;
                case 1: radioMusicSheet.Checked = true; break;
                case 2: radioPowerShell.Checked = true; break;
                case 3: radioBash.Checked = true; break;
            }

            numberBoxComma.Value = Settings.Default.CommaPause;
            numberBoxDuration.Value = Settings.Default.Duration;
            numberBoxPause.Value = Settings.Default.Pause;
            numberBoxPeriodPause.Value = Settings.Default.PeriodPause;
            numberBoxSemicolonPause.Value = Settings.Default.SemiColonPause;
            textBoxSource.Text = Settings.Default.LastSource;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            // Save Settings
            Settings.Default.CommaPause = (int)numberBoxComma.Value;
            Settings.Default.Duration = (int)numberBoxDuration.Value;
            Settings.Default.LastSource = textBoxSource.Text;
            Settings.Default.Pause = (int)numberBoxPause.Value;
            Settings.Default.PeriodPause = (int)numberBoxPeriodPause.Value;
            Settings.Default.SemiColonPause = (int)numberBoxSemicolonPause.Value;
            if (radioCode.Checked) Settings.Default.ParseModeIndex = 0;
            else if (radioMusicSheet.Checked) Settings.Default.ParseModeIndex = 1;
            else if (radioPowerShell.Checked) Settings.Default.ParseModeIndex = 2;
            else if (radioBash.Checked) Settings.Default.ParseModeIndex = 3;
            base.OnClosing(e);
        }

        private void UpdateOutputHandler(object sender, EventArgs e)
        {
            Note[] notes = null;

            var CP = new ConversionParams();
            CP.DefaultDuration = (int)numberBoxDuration.Value;
            CP.DefaultCommaPause = (int)numberBoxComma.Value;
            CP.DefaultPause = (int)numberBoxPause.Value;
            CP.DefaultSemiColonPause = (int)numberBoxSemicolonPause.Value;

            if (radioCode.Checked)
                notes = SequenceConversion.CSharpCodeToNoteArray(textBoxSource.Text, CP);
            else if (radioMusicSheet.Checked)
                notes = SequenceConversion.MusicSheetToNoteArray(textBoxSource.Text, CP);
            else if (radioPowerShell.Checked)
                notes = SequenceConversion.PowerShellToNoteArray(textBoxSource.Text, CP);
            else if (radioBash.Checked)
                notes = SequenceConversion.BashToNoteArray(textBoxSource.Text, CP);

            textBoxOutput.Text = SequenceConversion.NoteArrayToSequence(notes);
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            using (var dialogSaveFile = new SaveFileDialog())
            {
                dialogSaveFile.InitialDirectory = Application.StartupPath;
                dialogSaveFile.Filter = @"Text File|*.txt";

                if (dialogSaveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllText(dialogSaveFile.FileName, textBoxOutput.Text);
                    }
                    catch (Exception ex)
                    {
                        ex.ShowError();
                    }
                }
            }
        }
    }
}
