using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Паттерны_лаб_2
{
    internal class ConsoleShadowDecorator : IDrawer
    {
        IDrawer d;
        System.Windows.Forms.TextBox textBox1;

        public ConsoleShadowDecorator(IDrawer d, System.Windows.Forms.TextBox textBox1)
        {
            this.d = d;
            this.textBox1 = textBox1;
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
            textBox1.Text += "_";
        }

        public void DrawNull()
        {
            textBox1.Text += "          ";
        }

        public void DrawPass() 
        {
            d.DrawPass();     
        }

        public void Clear()
        {
            d.Clear();
        }
    }
}
