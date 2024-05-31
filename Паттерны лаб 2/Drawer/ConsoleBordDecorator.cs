using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Паттерны_лаб_2
{
    internal class ConsoleBordDecorator : IDrawer
    {
        IDrawer d;
        System.Windows.Forms.TextBox textBox1;

        public ConsoleBordDecorator(IDrawer d, System.Windows.Forms.TextBox textBox1)
        {
            this.d = d;
            this.textBox1 = textBox1;
        }

        public void DrawBord(IMatrix matrix)
        {
            textBox1.Font = new Font("Arial", 10);
            int onColumn = 5;

            for (int i = 0; i < onColumn * matrix.Columns; i++)
            {
                textBox1.Text += "–";
            }

            textBox1.Text += "–";
            textBox1.Text += "\r\n";
        }

        public void DrawBordElement(int row, int column)
        {
            textBox1.Font = new Font("Arial", 10);
            textBox1.Text += "|";
        }

        public void DrawElement(IMatrix matrix, int row, int column) 
        {
            d.DrawElement(matrix, row, column);
        }

        public void DrawNull() 
        {
            d.DrawNull();
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
