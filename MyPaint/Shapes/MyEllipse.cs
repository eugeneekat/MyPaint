using System.Drawing;

namespace MyPaint
{
    //Тот же прямоугольник, только эллипс)
    class MyEllipse : MyRectangle
    {
        public MyEllipse(Pen pen, Brush brush) : base(pen, brush)
        {
        }

        public override void Update(Graphics graphics)
        {
            graphics.DrawEllipse(this.Pen, GetRectangle);
            graphics.FillEllipse(this.Brush, GetRectangle);
        }
    }
}
