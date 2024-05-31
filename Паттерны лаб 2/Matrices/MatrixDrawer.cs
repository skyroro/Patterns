using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Паттерны_лаб_2.Matrices
{
    internal static class MatrixDrawer
    {

        public static void Draw(IDrawer d, IMatrix matrix)
        {
            d.Clear();
            d.DrawBord(matrix);

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    d.DrawBordElement(i, j);
                    matrix.DrawElement(d, matrix, i, j);
                }

                d.DrawBordElement(0, 0);
                d.DrawPass();
                d.DrawBord(matrix);
            }
        }
    }
}
