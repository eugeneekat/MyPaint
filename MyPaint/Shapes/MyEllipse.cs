using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
