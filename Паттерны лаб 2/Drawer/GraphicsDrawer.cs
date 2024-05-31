using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Паттерны_лаб_2
{
    public class GraphicsDrawer : IDrawer
    {
        Graphics graphics;

        float x0;
        float y0;
        float width;
        float height;
        float indent;

        Font font;

        public GraphicsDrawer(Graphics graphics)
        {
            this.graphics = graphics;
            parametrs();
        }
        public void DrawBord(IMatrix matrix) { }

        public void DrawBordElement(int row, int column) { }

        public void DrawElement(IMatrix matrix, int row, int column)
        {
            string text1 = matrix[row, column].ToString("F2");
            RectangleF rectF1 = new RectangleF(x0 + column * width + indent, y0 + row * height + indent, width - indent, height - indent);
            graphics.DrawString(text1, font, Brushes.Black, rectF1);
        }    

        public void DrawNull() { }

        public void DrawPass() { }

        public void Clear()
        {
            graphics.Clear(Color.White);
        }

        public void parametrs()
        {
            x0 = 5.0F;
            y0 = 15.0F;
            width = 40.0F;
            height = 30.0F;
            indent = 5.0F;

            font = new Font("Arial", 10);
        }
    }
}
