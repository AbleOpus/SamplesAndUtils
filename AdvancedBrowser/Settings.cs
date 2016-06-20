using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;

namespace AdvancedWebBrowser
{
    [Serializable]
    class Settings : SettingsBase<Settings>
    {
        /// <summary>
        /// Occurs when a link has been added to the history list.
        /// </summary>
        [field: NonSerialized]
        public event EventHandler HistoryAdded;

        /// <summary>
        /// Gets or sets whether to track user navigation history.
        /// </summary>
        public bool TrackHistory { get; set; }

        /// <summary>
        /// Gets or sets whether the syntax highlighter in the view source window is enabled.
        /// </summary>
        public bool ViewSourceHighlighterEnabled { get; set; }

        /// <summary>
        /// Gets or sets whether to wrap words in the view source window.
        /// </summary>
        public bool ViewSourceWordWrapEnabled { get; set; }

        /// <summary>
        /// Gets or sets the font of the code in the view source window.
        /// </summary>
        public Font ViewSourceFont { get; set; }

        /// <summary>
        /// Gets or sets the homepage.
        /// </summary>
        public string Homepage { get; set; }

        /// <summary>
        /// Gets or sets whether to show the bookmark bar.
        /// </summary>
        public bool ShowBookmarks { get; set; }

        /// <summary>
        /// Gets or sets whether to show the status strip control at 
        /// the very bottom of the main window.
        /// </summary>
        public bool ShowStatusBar { get; set; }

        /// <summary>
        /// Gets or sets the users bookmarks.
        /// </summary>
        public ObservableCollection<Bookmark> Bookmarks { get; set; }

        private readonly List<string> history = new List<string>();
        // Do not add history directly to this list.
        public string[] History => history?.ToArray();

        public void ClearHistory()
        {
            history.Clear();
        }

        public void AddHistory(string URL)
        {
            if (URL != history.LastOrDefault())
                history.Add(URL);

            HistoryAdded?.Invoke(this, EventArgs.Empty);
        }

        public Settings()
        {
            Bookmarks = new ObservableCollection<Bookmark>();
            history = new List<string>();
        }

        /// <summary>
        /// Clear history and clear bookmarks.
        /// </summary>
        public override void Reset()
        {
            ViewSourceFont = new Font("Courier New", 13f);
            ViewSourceHighlighterEnabled = true;
            ViewSourceWordWrapEnabled = false;
            TrackHistory = true;
            Bookmarks?.Clear();
            if (history != null) ClearHistory();
            Homepage = "http://AbleOpus.com";
            ShowBookmarks = true;
            ShowStatusBar = true;
        }
    }
}