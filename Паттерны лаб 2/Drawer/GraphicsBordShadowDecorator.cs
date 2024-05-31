using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Паттерны_лаб_2
{
    internal class GraphicsBordShadowDecorator : IDrawer
    {
        IDrawer d;
        Graphics graphics;

        float x0;
        float y0;
        float width;
        float height;
        Pen blackPen;

        public GraphicsBordShadowDecorator(IDrawer d, Graphics graphics)
        {
            this.d = d;
            this.graphics = graphics;
            parametrs();
        }

        public void DrawBord(IMatrix matrix)
        {
            d.DrawBord(matrix);
            graphics.DrawRectangle(blackPen, x0, y0, matrix.Columns * width, matrix.Rows * height);
        }

        public void DrawBordElement(int row, int column)
        {
            d.DrawBordElement(row, column);
            graphics.DrawRectangle(blackPen, x0 + column * width, y0 + row * height, width, height);
        }

        public void DrawElement(IMatrix matrix, int row, int column)
        {
            d.DrawElement(matrix, row, column);
        }

        public void DrawNull()
        {
            d.DrawNull();
        }

        public void DrawPass() { }

        public void Clear()
        {
            d.Clear();
        }

        public void parametrs()
        {
            x0 = 7.0F;
            y0 = 17.0F;
            width = 40.0F;
            height = 30.0F;

            blackPen = new Pen(Color.DarkGray, 1);
        }
    }
}
