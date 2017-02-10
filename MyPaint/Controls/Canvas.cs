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
