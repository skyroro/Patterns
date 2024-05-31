using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Паттерны_лаб_2
{
    internal class GraphicsShadowDecorator : IDrawer
    {
        IDrawer d;
        Graphics graphics;

        float x0;
        float y0;
        float width;
        float height;
        float indent;

        Font font;

        public GraphicsShadowDecorator(IDrawer d, Graphics graphics)
        {
            this.d = d;
            this.graphics = graphics;
            parametrs();
        }

        public void DrawBord(IMatrix matrix)
        {
            d.DrawBord(matrix);
        }

        public void DrawBordElement(int row, int column)
        {
            d.DrawBordElement(row, column);
        }

        public void DrawElement(IMatrix matrix, int row, int column)
        {
            d.DrawElement(matrix, row, column);
            SolidBrush brush = new SolidBrush(Color.DarkGray);

            string text1 = matrix[row, column].ToString("F2");
            RectangleF rectF1 = new RectangleF(x0 + column * width + indent, y0 + row * height + indent, width - indent, height - indent);
            
            graphics.DrawString(text1, font, brush, rectF1);
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
            indent = 5.0F;

            font = new Font("Arial", 10);
        }

    }
}
