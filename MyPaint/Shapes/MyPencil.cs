using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MyPaint
{
    //Карандаш
    class MyPencil : IDrawable
    {
        public Pen Pen { get; set; }
        public Brush Brush { get; set; }

        List<Point> points = new List<Point>();

        public MyPencil(Pen pen)
        {
            Pen = pen;
        }

        public void Drawing(Point position, Control control)
        {
            points.Add(position);
            control.Invalidate();        
        }

        public void EndDraw(Point position, Control control)
        {
            control.Invalidate();
        }

        public void StartDraw(Point position, Control control)
        {
            //Сначала сразу добавляем 2 точки что бы отрисовать линию, ниаче с 1 точкой будет исключение
            points.Add(position);
            points.Add(position);
        }

        //Отрисовка линии по точкам
        public void Update(Graphics graphics)
        {
            graphics.DrawLines(Pen, points.ToArray());
        }
    }
}
