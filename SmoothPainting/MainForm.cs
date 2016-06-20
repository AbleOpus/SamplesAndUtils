using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace SmoothPainting
{
    public partial class MainForm : Form
    {
        private float fidelity = 4;
        private Point lastPos;
        private readonly PathManager pathManager = new PathManager();
        private readonly Pen penStroke = new Pen(Color.Black, 10f);

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            lastPos = e.Location;
            // Start path.
            pathManager.SubmitPoint(e.Location);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            // Finish off the path.
            pathManager.SubmitPoint(e.Location);
            // The user is done with the active path.
            pathManager.SubmitActivePath();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            var activePath = pathManager.GetActivePath();

            // Draw active path.
            // Cannot draw paths if they have only one point.
            if (activePath.Length > 1)
            {
                e.Graphics.DrawLines(penStroke, activePath);
            }

            // Draw trailing line. This effect is only noticeable with low fidelity (higher values).
            if (activePath.Length > 0)
            {
                e.Graphics.DrawLine(penStroke, activePath.Last(), PointToClient(Cursor.Position));
            }

            // Draw submitted paths.
            foreach (var path in pathManager.PathList)
                e.Graphics.DrawLines(penStroke, path);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            // If pressing the left mouse button.
            if (e.Button == MouseButtons.Left)
            {
                #region Old Fidelity Method
                // While last mouse position is not equal to current.
                //while (lastPos != e.Location)
                //{
                //    if (e.Location.X > lastPos.X)
                //    {
                //        lastPos = new Point(lastPos.X + 1, lastPos.Y);
                //    }
                //    else if (e.Location.X < lastPos.X)
                //    {
                //        lastPos = new Point(lastPos.X - 1, lastPos.Y);
                //    }

                //    if (e.Location.Y > lastPos.Y)
                //    {
                //        lastPos = new Point(lastPos.X, lastPos.Y + 1);
                //    }
                //    else if (e.Location.Y < lastPos.Y)
                //    {
                //        lastPos = new Point(lastPos.X, lastPos.Y - 1);
                //    }

                //    pathingData.SubmitPoint(lastPos);
                //}
                #endregion

                // Test the distance between the last submitted pos and the current mouse pos.
                // If the distance is above the fidelity threshold, then submit the point.
                if (PathManager.DistanceTo(e.Location, lastPos) > fidelity)
                {
                    pathManager.SubmitPoint(lastPos);
                    lastPos = e.Location;
                }

                Invalidate();
            }
        }

        private void buttonClear_Click(object sender, System.EventArgs e)
        {
            pathManager.Clear();
            Invalidate();
        }

        private void FidelityButtons_Click(object sender, System.EventArgs e)
        {
            var controlClicked = (ToolStripMenuItem) sender;
            fidelity = float.Parse(controlClicked.Text);
        }
    }
}
