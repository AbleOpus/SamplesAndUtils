using System;
using System.Collections.Generic;
using System.Drawing;

namespace SmoothPainting
{
    /// <summary>
    /// Manages path related aspects of this drawing program.
    /// </summary>
    class PathManager
    {
        private readonly List<Point> activePath = new List<Point>();

        private readonly List<Point[]> pathList = new List<Point[]>();
        // Expose this field as a readonly list so it cannot be modified
        // from outside the class, yet retains read-related List helpers.
        /// <summary>
        /// Gets the list of all submitted paths.
        /// </summary>
        public IReadOnlyList<Point[]> PathList => pathList;

        /// <summary>
        /// Gets the path that is currently being created.
        /// </summary>
        public Point[] GetActivePath()
        {
            return activePath.ToArray();
        }

        /// <summary>
        /// Submits a point to the active path.
        /// </summary>
        public void SubmitPoint(Point point)
        {
            activePath.Add(point);
        }

        /// <summary>
        /// Submits the active path to the path list. Then clears the active path.
        /// </summary>
        public void SubmitActivePath()
        {
            if (activePath.Count > 1)
            {
                pathList.Add(GetActivePath());
            }

            activePath.Clear();
        }

        /// <summary>
        /// Gets the distance between two points.
        /// </summary>
        public static float DistanceTo(PointF p1, PointF p2)
        {
            double a = p1.X - p2.X;
            double b = p1.Y - p2.Y;
            return (float)Math.Sqrt(a * a + b * b);
        }

        /// <summary>
        /// Clears both the active path and submitted paths.
        /// </summary>
        public void Clear()
        {
            pathList.Clear();
            activePath.Clear();
        }
    }
}
