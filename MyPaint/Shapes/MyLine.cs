using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    //Линия - тут просто меняется текущая позиция и идет перерисовка
    class MyLine : IDrawable
    {
        protected Point startPos;      
        protected Point currentPos;

        public Pen Pen { get; set; }
        public Brush Brush { get; set; }

        public MyLine (Pen pen)
        {
            Pen = pen;
        }

        public virtual void Drawing(Point position, Control control)
        {
            currentPos = position;
            control.Invalidate();
        }

        public virtual void EndDraw(Point position, Control control)
        {
            control.Invalidate();
        }

        public virtual void StartDraw(Point position, Control control)
        {
            currentPos = startPos = position;
        }

        public virtual void Update(Graphics graphics)
        {
            graphics.DrawLine(Pen, startPos, currentPos);
        }
    }
}
