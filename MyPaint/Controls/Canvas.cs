using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    //Эта панель не имеет эффекта мерцания при перерисовке и перерисовывается при изменении размера
    class Canvas : Panel
    {
        public Canvas()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
    }
}
