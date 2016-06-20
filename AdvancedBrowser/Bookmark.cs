using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace AdvancedWebBrowser
{
    /// <summary>
    /// Represents a Web-Browsers user bookmark.
    /// </summary>
    [Serializable]
    public class Bookmark
    {
        /// <summary>
        /// Gets or sets the link to navigate to.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the title to be displayed to the user.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the favicon of the website.
        /// </summary>
        public Icon FavIcon { get; set; }

        /// <summary>
        /// Gets whether the icon has been set.
        /// </summary>
        public bool HasIcon => FavIcon != null;

        /// <summary>
        /// Initializes a new instance of the <see cref="Bookmark"/> class with
        /// the specified arguments.
        /// </summary>
        /// <param name="url">The link to navigate to.</param>
        /// <param name="title">The title to be displayed to the user.</param>
        /// <param name="favIcon">The favicon of the website.</param>
        public Bookmark(string url, string title, Icon favIcon)
        {
            Url = url;
            Title = title;
            FavIcon = favIcon;
        }

        /// <summary>
        /// Extracts all bookmark instances from the list type.
        /// </summary>
        public static IEnumerable<Bookmark> ExtractBookmarks(IList list)
        {
            if (list == null) return new Bookmark[] { };

            return (from object item in list
                    let bookmark = item
                    as Bookmark
                    where item != null
                    select bookmark).ToList();
        }

        /// <summary>
        /// Gets the favicon of the currently loaded webpage.
        /// </summary>
        public static async Task<Icon> GetFavIconAsyc(string URL)
        {
            return await GetFavIconAsync(new Uri(URL));
        }

        /// <summary>
        /// Gets the favicon of the currently loaded webpage.
        /// </summary>
        public static async Task<Icon> GetFavIconAsync(Uri uri)
        {
            string url = $@"http://{uri.Host}/favicon.ico";

            try
            {
                using (var webClient = new WebClient())
                {
                    byte[] data = await webClient.DownloadDataTaskAsync(url);
                    var memStream = new MemoryStream(data);
                    var icon = new Icon(memStream);
                    memStream.Close();
                    return icon;
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
