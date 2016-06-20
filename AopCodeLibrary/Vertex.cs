using System;
using System.Drawing;

namespace AboCodeLibrary
{
    /// <summary>
    /// Represents a 3-dimensional point.
    /// </summary>
    struct Vertex
    {
        /// <summary>
        /// Gets or sets the X position of the vertex.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Gets or sets the Y position of the vertex.
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Gets or sets the Z position of the vertex.
        /// </summary>
        public int Z { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vertex"/> class with
        /// the specified arguments.
        /// </summary>
        /// <param name="x">The X position of the vertex.</param>
        /// <param name="y">The Y position of the vertex.</param>
        /// <param name="z">The Z position of the vertex.</param>
        public Vertex(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        #region Operator overloading
        public static bool operator ==(Vertex v1, Vertex v2)
        {
            bool isXEqual = v1.X == v2.X;
            bool isYEqual = v1.Y == v2.Y;
            bool isZEqual = v1.Z == v2.Z;

            return (isXEqual && isZEqual && isYEqual);
        }

        public static bool operator !=(Vertex v1, Vertex v2)
        {
            bool isXEqual = v1.X == v2.X;
            bool isYEqual = v1.Y == v2.Y;
            bool isZEqual = v1.Z == v2.Z;

            return !(isXEqual && isZEqual && isYEqual);
        }

        public static bool operator <(Vertex v1, Vertex v2)
        {
            int total1 = v1.X + v1.Y + v1.Z;
            int total2 = v2.X + v2.Y + v2.Z;

            return (total1 < total2);
        }

        public static bool operator >(Vertex v1, Vertex v2)
        {
            int total1 = v1.X + v1.Y + v1.Z;
            int total2 = v2.X + v2.Y + v2.Z;

            return (total1 > total2);
        }

        public static bool operator <=(Vertex v1, Vertex v2)
        {
            int total1 = v1.X + v1.Y + v1.Z;
            int total2 = v2.X + v2.Y + v2.Z;

            return (total1 <= total2);
        }

        public static bool operator >=(Vertex v1, Vertex v2)
        {
            int total1 = v1.X + v1.Y + v1.Z;
            int total2 = v2.X + v2.Y + v2.Z;

            return (total1 >= total2);
        }

        public static Vertex operator *(Vertex v1, Vertex v2)
        {
            Vertex v3 = new Vertex
                (v1.X * v2.X, v1.Y * v2.Y, v1.Z * v2.Z);
            return v3;
        }

        public static Vertex operator ++(Vertex v1)
        {
            v1.X++;
            v1.Y++;
            v1.Z++;
            return v1;
        }

        public static Vertex operator --(Vertex v1)
        {
            v1.X--;
            v1.Y--;
            v1.Z--;
            return v1;
        }

        public static Vertex operator /(Vertex v1, Vertex v2)
        {
            Vertex v3 = new Vertex
                (v1.X / v2.X, v1.Y / v2.Y, v1.Z / v2.Z);
            return v3;
        }

        public override int GetHashCode()
        {
            return
            X.GetHashCode() ^
            Y.GetHashCode() ^
            Z.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Vertex)) return false;

            Vertex v1 = (Vertex)obj;

            bool isXEqual = v1.X == this.X;
            bool isYEqual = v1.Y == this.Y;
            bool isZEqual = v1.Z == this.Z;

            return (isXEqual && isZEqual && isYEqual);
        }
        #endregion

        /// <summary>
        /// Resets the vertex to its original position.
        /// </summary>
        public void ResetToOrigin()
        {
            X = Y = Z = 0;
        }

        /// <summary>
        /// Returns the fully qualified type name of this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String"/> containing a fully qualified type name.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        public override string ToString()
        {
            return $"{{X={X}, Y={Y}, Z={Z}}}";
        }
    }

    struct VertexColored
    {
        /// <summary>
        /// Gets or sets the X position of the vertex.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Gets or sets the Y position of the vertex.
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Gets or sets the Z position of the vertex.
        /// </summary>
        public int Z { get; set; }


        /// <summary>
        /// Creates a vertex object.
        /// </summary>
        /// <param name="x">The X position of the vertex.</param>
        /// <param name="y">The Y position of the vertex.</param>
        /// <param name="z">The Z position of the vertex.</param>
        /// <param name="color">The color to apply to the vertex.</param>
        public VertexColored(int x, int y, int z, Color color)
        {
            X = x;
            Y = y;
            Z = z;
            VertexColor = color;
        }

        #region Operator overloading
        public static bool operator ==(VertexColored v1, VertexColored v2)
        {
            bool isXEqual = v1.X == v2.X;
            bool isYEqual = v1.Y == v2.Y;
            bool isZEqual = v1.Z == v2.Z;
            return (isXEqual && isZEqual && isYEqual);
        }

        public static bool operator !=(VertexColored v1, VertexColored v2)
        {
            bool isXEqual = v1.X == v2.X;
            bool isYEqual = v1.Y == v2.Y;
            bool isZEqual = v1.Z == v2.Z;
            return !(isXEqual && isZEqual && isYEqual);
        }

        public static bool operator <(VertexColored v1, VertexColored v2)
        {
            int total1 = v1.X + v1.Y + v1.Z;
            int total2 = v2.X + v2.Y + v2.Z;
            return (total1 < total2);
        }

        public static bool operator >(VertexColored v1, VertexColored v2)
        {
            int total1 = v1.X + v1.Y + v1.Z;
            int total2 = v2.X + v2.Y + v2.Z;
            return (total1 > total2);
        }

        public static bool operator <=(VertexColored v1, VertexColored v2)
        {
            int total1 = v1.X + v1.Y + v1.Z;
            int total2 = v2.X + v2.Y + v2.Z;
            return (total1 <= total2);
        }

        public static bool operator >=(VertexColored v1, VertexColored v2)
        {
            int total1 = v1.X + v1.Y + v1.Z;
            int total2 = v2.X + v2.Y + v2.Z;
            return (total1 >= total2);
        }

        public static Vertex operator *(VertexColored v1, VertexColored v2)
        {
            return new Vertex(v1.X * v2.X, v1.Y * v2.Y, v1.Z * v2.Z);
        }

        public static VertexColored operator ++(VertexColored v1)
        {
            v1.X++;
            v1.Y++;
            v1.Z++;
            return v1;
        }

        public static VertexColored operator --(VertexColored v1)
        {
            v1.X--;
            v1.Y--;
            v1.Z--;
            return v1;
        }

        public static VertexColored operator /(VertexColored v1, VertexColored v2)
        {
           return new VertexColored(v1.X / v2.X, v1.Y / v2.Y, v1.Z / v2.Z, v2.VertexColor);
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode() ^ Z.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Vertex)) return false;

            VertexColored v1 = (VertexColored)obj;

            bool isXEqual = v1.X == this.X;
            bool isYEqual = v1.Y == this.Y;
            bool isZEqual = v1.Z == this.Z;

            return (isXEqual && isZEqual && isYEqual);
        }
        #endregion

        /// <summary>
        /// Gets or sets the color of the vertex.
        /// </summary>
        public Color VertexColor { get; set; }

        /// <summary>
        /// Resets the vertex to its original position.
        /// </summary>
        public void ResetToOrigin()
        {
            X = Y = Z = 0;
        }

        public override string ToString()
        {
            return $"{{X={X}, Y={Y}, Z={Z}}}";
        }
    }
}
