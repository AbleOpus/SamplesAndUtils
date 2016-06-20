using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AdvancedWebBrowser.Forms
{
    public partial class BookmarkBar : BrowserControl
    {
        private Bookmark clickedBookmark;

        /// <summary>
        /// Gets or sets the maximum width of the tab caption (in pixels).
        /// </summary>
        public int MaxBookmarkCaptionWidth { get; set; }

        /// <summary>
        /// Occurs when a bookmark is clicked by the middle mouse button.
        /// </summary>
        [Description("Occurs when a bookmark is clicked by the middle mouse button.")]
        public event EventHandler<Bookmark> BookmarkMiddleClicked = delegate { };

        public BookmarkBar()
        {
            MaxBookmarkCaptionWidth = 150;
            InitializeComponent();
            toolStrip.AllowDrop = true;
            toolStrip.DragEnter += toolStrip_DragEnter;
            toolStrip.DragDrop += toolStrip_DragDrop;
            AddBookmarks(Settings.Default.Bookmarks);
            Settings.Default.Bookmarks.CollectionChanged += Bookmarks_CollectionChanged;
        }

        private void Bookmarks_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    var added = Bookmark.ExtractBookmarks(e.NewItems);
                    AddBookmarks(added);
                    break;
                case NotifyCollectionChangedAction.Remove:
                    var removed = Bookmark.ExtractBookmarks(e.OldItems);
                    RemoveBookmarks(removed);
                    break;
            }
        }

        /// <summary>
        /// Removes bookmarks from the display.
        /// </summary>
        private void RemoveBookmarks(IEnumerable<Bookmark> bookmarks)
        {
            foreach (Bookmark bookmark in bookmarks)
            {
                for (int i = toolStrip.Items.Count - 1; i >= 0; i--)
                {
                    if (toolStrip.Items[i].Tag == bookmark)
                    {
                        toolStrip.Items.RemoveAt(i);
                    }
                }
            }
        }

        private async void toolStrip_DragDrop(object sender, DragEventArgs e)
        {
            var bookmark = (Bookmark)e.Data.GetData(typeof(Bookmark));
            Icon icon = await Bookmark.GetFavIconAsync(WebBrowser.Url);
            bookmark.FavIcon = icon;
            Settings.Default.Bookmarks.Add(bookmark);
        }

        private static void toolStrip_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(typeof(Bookmark)) != null)
                e.Effect = DragDropEffects.Link;
        }

        private void AddBookmarks(IEnumerable<Bookmark> bookmarks)
        {
            foreach (var bookmark in bookmarks)
            {
                var button = new ToolStripButton
                {
                    Tag = bookmark,
                    DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
                    ImageAlign = ContentAlignment.MiddleLeft,
                    ImageScaling = ToolStripItemImageScaling.SizeToFit
                };

                if (MaxBookmarkCaptionWidth == 0)
                    button.Text = bookmark.Title;
                else
                    button.Text = bookmark.Title.AutoEllipsesString(button.Font, MaxBookmarkCaptionWidth);

                if (bookmark.FavIcon != null)
                    button.Image = bookmark.FavIcon.ToBitmap();

                button.MouseDown += (s, e) =>
                {
                    if (e.Button == MouseButtons.Right) return;

                    if (e.Button == MouseButtons.Middle)
                    {
                        BookmarkMiddleClicked(this,  (Bookmark)button.Tag);
                        return;
                    }

                    WebBrowser?.Navigate(bookmark.Url);
                };

                toolStrip.Items.Add(button);
            }
        }

        /// <summary>
        /// Reloads all of the bookmarks
        /// </summary>
        //private void RefreshBookmarks()
        //{
        //    toolStrip.Items.Clear();

        //    foreach (var bookmark in Settings.Instance.Bookmarks)
        //    {
        //        if (!bookmark.InBar) continue;

        //        var btn = new ToolStripButton();
        //        btn.Tag = bookmark;
        //        btn.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
        //        btn.ImageAlign = ContentAlignment.MiddleLeft;
        //        btn.ImageScaling = ToolStripItemImageScaling.SizeToFit;

        //        if (MaxBookmarkCaptionWidth == 0)
        //            btn.Text = bookmark.Title;
        //        else
        //        btn.Text = bookmark.Title.AutoEllipsesString(btn.Font, MaxBookmarkCaptionWidth);

        //        if (bookmark.FavIcon != null)
        //            btn.Image = bookmark.FavIcon.ToBitmap();

        //        btn.Click += (s, e) =>
        //        {
        //            if (WebBrowser != null)
        //                WebBrowser.Navigate(bookmark.Url);
        //        };

        //        toolStrip.Items.Add(btn);
        //    }
        //}

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            Settings.Default.Bookmarks.Remove(clickedBookmark);
        }

        /// <summary>
        /// Gets the currently hovered ToolStripButton.
        /// </summary>
        private ToolStripButton GetHoveredButton()
        {
            Point pos = toolStrip.PointToClient(Cursor.Position);
            return toolStrip.Items.Cast<ToolStripButton>().FirstOrDefault(button => button.Bounds.Contains(pos));
        }

        private void contextMenuToolStrip_Opening(object sender, CancelEventArgs e)
        {
            var btn = GetHoveredButton();

            if (btn == null)
            {
                clickedBookmark = null;
                e.Cancel = true;
            }
            else
            {
                clickedBookmark = (Bookmark)btn.Tag;
            }
        }

        private void menuItemEdit_Click(object sender, EventArgs e)
        {
            using (var formEditBookmark = new EditBookmarkForm(clickedBookmark))
            {
                formEditBookmark.ShowDialog();
            }
        }
    }
}
