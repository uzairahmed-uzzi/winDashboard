using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winDashboardPrac
{
    internal class RoundedPanel : Panel
    {
        private int cornerRadius = 10; // Adjust this value to change the corner radius

        public int CornerRadius
        {
            get { return cornerRadius; }
            set
            {
                cornerRadius = value;
                Invalidate(); // Invalidate the control to trigger a repaint
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90); // Top-left corner
            path.AddArc(Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90); // Top-right corner
            path.AddArc(Width - cornerRadius, Height - cornerRadius, cornerRadius, cornerRadius, 0, 90); // Bottom-right corner
            path.AddArc(0, Height - cornerRadius, cornerRadius, cornerRadius, 90, 90); // Bottom-left corner
            path.CloseFigure();

            Region = new Region(path);
        }
    }
}
