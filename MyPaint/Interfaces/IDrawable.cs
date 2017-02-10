using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    //Итерфейс для фигур, все конкретные классы фигур определяют эти методы как virtual для возможного последующего наследования и отрисовки по определенным своим правилам
    interface IDrawable
    {
        Pen Pen { get; set; }
        Brush Brush { get; set; }
        //Начало рисования
        void StartDraw(Point position, Control control);
        //Процесс рисования
        void Drawing(Point position, Control control);
        //Конец рисования
        void EndDraw(Point position, Control control);
        //Обновление экрана
        void Update(Graphics graphics);
    }
}
