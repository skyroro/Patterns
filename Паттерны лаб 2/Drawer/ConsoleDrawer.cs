using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Паттерны_лаб_2
{
    public class ConsoleDrawer : IDrawer
    {
        System.Windows.Forms.TextBox textBox1;

        public ConsoleDrawer(System.Windows.Forms.TextBox textBox1)
        {
            this.textBox1 = textBox1;
        }

        public void DrawBord(IMatrix matrix)
        {
            textBox1.Text += "\r\n";
        }

        public void DrawBordElement(int row, int column)
        {
            textBox1.Text += " ";
        }
        public void DrawElement(IMatrix matrix, int row, int column)
        {
            textBox1.Font = new Font("Arial", 10);
            textBox1.Text += " " + matrix[row, column].ToString("F2") + " ";
        }

        public void DrawNull()
        {
            textBox1.Text += "        ";
        }

        public void DrawPass()
        {
            textBox1.Text += "\r\n";
        }

        public void Clear()
        {
            textBox1.Clear();
        }

    }
}
