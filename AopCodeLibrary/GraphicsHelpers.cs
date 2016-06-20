using System.Drawing;

namespace AboCodeLibrary
{
    public enum Dimension { Width, Height }

    static class GraphicsHelp
    {
        /// <summary>
        /// Crops the specified bitmap to the specified region.
        /// </summary>
        /// <param name="bitmap">The bitmap to crop.</param>
        /// <param name="cropArea">The area to crop to.</param>
        /// <returns>The cropped bitmap.</returns>
        public static Bitmap CropBitmap(Bitmap bitmap, Rectangle cropArea)
        {
            return bitmap.Clone(cropArea, bitmap.PixelFormat);
        }

        /// <summary>
        /// Gets the constrained equivalent dimension of another changed dimension by 
        /// finding the difference between the old one and the new one, then returning
        /// the dimension with the difference applied to it.
        /// </summary>
        /// <param name="originalSize">The original size.</param>
        /// <param name="dimeToFind">The dimension equivalent to be calculated.</param>
        /// <param name="dimeChanged">The changed dimension to find the difference of.</param>
        public static int GetConstrainedDimension(Size originalSize, Dimension dimeToFind, int dimeChanged)
        {
            if (dimeToFind == Dimension.Height)
            {
                double difference = dimeChanged / (double)originalSize.Width;
                return (int)(originalSize.Height * difference + 0.5);
            }
            else
            {
                double difference = dimeChanged / (double)originalSize.Height;
                return (int)(originalSize.Width * difference + 0.5);
            }
        }
    }
}
