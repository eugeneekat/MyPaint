using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Creator
{
    enum Shapes
    {
        Pencil, Line, Ellipse, Rectangle
    }
    //Для удобства - можно создавать фигуры через методы, либо передав enum
    static class ShapeCreator
    {
        public static Pen DefaultPen { get; set; } = Pens.Black;
        public static Brush DefaultFillColor { get; set; } = Brushes.Transparent;
        
        public static IDrawable CreateShape(Shapes shapes)
        {
            switch (shapes)
            {           
                case Shapes.Line:
                    return CreateLine();
                case Shapes.Ellipse:
                    return CreateEllipse();
                case Shapes.Rectangle:
                    return CreateRectangle();
                case Shapes.Pencil:
                default:
                    return CreatePencil();
            }
        }

        public static IDrawable CreatePencil()
        {
            return new MyPencil(DefaultPen);
            
        }
        public static IDrawable CreatePencil(Pen pen)
        {
            return new MyPencil(pen);
        }

        public static IDrawable CreateLine()
        {
            return new MyLine(DefaultPen);
        }
        public static IDrawable CreateLine(Pen pen)
        {
            return new MyLine(pen);
        }

        public static IDrawable CreateEllipse()
        {
            return new MyEllipse(DefaultPen, DefaultFillColor);
        }
        public static IDrawable CreateEllipse(Pen pen, Brush brush)
        {
            return new MyEllipse(pen, brush);
        }

        public static IDrawable CreateRectangle()
        {
            return new MyRectangle(DefaultPen, DefaultFillColor);
        }
        public static IDrawable CreateRectangle(Pen pen, Brush brush)
        {
            return new MyRectangle(pen, brush);
        }

    }
}
