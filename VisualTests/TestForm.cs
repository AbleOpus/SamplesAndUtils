using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AboCodeLibrary;

namespace VisualTests
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            Text = Bounds.ToString();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            switch (e.KeyData)
            {
                case Keys.Up:
                    this.DockTop();
                    break;

                case Keys.Down:
                    this.DockBottom();
                    break;

                case Keys.Left:
                    this.DockLeft();
                    break;

                case Keys.Right:
                    this.DockRight();
                    break;
            }
        }
    }
}
