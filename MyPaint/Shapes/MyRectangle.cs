using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyPaint
{
    class MyRectangle : IDrawable
    {
        protected Point startPos;     
        protected Point currentPos;   

        public Pen Pen { get; set; }       
        public Brush Brush { get; set; }  

        //Вычисляет координаты прямоугольника и стороны (прямоугольник может рисоваться и с нижнего края и с верхнего)
        protected virtual Rectangle GetRectangle
        {
            get 
            {
                return new Rectangle(
                Math.Min(startPos.X, currentPos.X),
                Math.Min(startPos.Y, currentPos.Y),
                Math.Abs(startPos.X - currentPos.X),
                Math.Abs(startPos.Y - currentPos.Y));
            }
        }

        public MyRectangle (Pen pen, Brush brush)
        {
            this.Pen = pen;
            this.Brush = brush;
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

        public virtual void Update (Graphics graphics)
        {
            graphics.DrawRectangle(this.Pen, GetRectangle);
            graphics.FillRectangle(this.Brush, GetRectangle);
        }
    }
}
