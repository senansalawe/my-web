using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace calculator
{
    class Round : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath p = new GraphicsPath();
            p.AddEllipse(30, 10, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(p);
            base.OnPaint(pevent);
            // this is for round button if you wont
        }
    }
}
