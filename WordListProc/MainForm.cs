using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WordListProc.Properties;

namespace WordListProc
{
    public partial class MainForm : Form
    {
        private string Seperator
        {
            get
            {
                switch (comboFormat.Text)
                {
                    case "Comma Separated": return ", ";
                    case "Line Separated": return "\r\n";
                    case "Spaced": return " ";
                    default: return " ";
                }
            }
        }

        public MainForm()
        {
            InitializeComponent();
            textBoxWords.DataBindings.Add("Text", Settings.Default, "Text");
            comboFormat.DataBindings.Add("SelectedIndex", Settings.Default, "FormatIndex");
            comboSortMode.DataBindings.Add("SelectedIndex", Settings.Default, "SortIndex");
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Settings.Default.Save();
            base.OnClosing(e);
        }

        private void SortWithSelected()
        {
            List<string> temp = new List<string>(GetWords());

            switch (comboSortMode.Text)
            {
                case "A-Z": temp.Sort(); break;
                case "Z-A": temp.Sort(); temp.Reverse(); break;
                case "Length": temp = temp.OrderBy(x => x.Length).ToList(); break;
                case "Length Descending": temp = temp.OrderByDescending(x => x.Length).ToList(); break;
            }

            DisplayWords(temp);
        }

        private string[] GetWords()
        {
            return textBoxWords.Text.Split(
                new[] { ' ', '\r', '\n', ',' },
                StringSplitOptions.RemoveEmptyEntries);
        }

        private void DisplayWords(IEnumerable<string> words)
        {
            var SB = new StringBuilder();

            foreach (string word in words)
            {
                SB.Append(word.Trim() + Seperator);
            }

            textBoxWords.Text = SB.ToString().Trim(',', ' ', '\r', '\n');
            labelWordCount.Text = words.Count() + " Words";
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            SortWithSelected();
            DisplayWords(GetWords());
        }

        private void buttonRemoveDuplicates_Click(object sender, EventArgs e)
        {
            var words = GetWords();
            words = words.Distinct().ToArray();
            DisplayWords(words);
        }

        private void buttonToLower_Click(object sender, EventArgs e)
        {
            textBoxWords.Text = textBoxWords.Text.ToLower();
        }

        private void buttonToUpper_Click(object sender, EventArgs e)
        {
            textBoxWords.Text = textBoxWords.Text.ToUpper();
        }

        private void buttonCapFirstLet_Click(object sender, EventArgs e)
        {
            string text = textBoxWords.Text;
            var MC = Regex.Matches(text, @"\b\w");

            foreach (Match match in MC)
            {
                text = text.Remove(match.Index, 1);
                text = text.Insert(match.Index, match.Value.ToUpper());
            }

            textBoxWords.Text = text;
        }

        private void buttonReverse_Click(object sender, EventArgs e)
        {
            var words = GetWords();
            words = words.Reverse().ToArray();
            DisplayWords(words);
        }
    }
}
