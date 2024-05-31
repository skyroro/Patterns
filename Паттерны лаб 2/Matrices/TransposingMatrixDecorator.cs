using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Паттерны_лаб_2.Matrices;

namespace Паттерны_лаб_2
{
    internal class TransposingMatrixDecorator : IMatrix
    {
        IMatrix matrix;

        public TransposingMatrixDecorator(IMatrix matrix)
        {
            this.matrix = matrix;
        }

        public double this[int row, int column]
        {
            get { return matrix[column, row]; }
            set { matrix[column, row] = value; }
        }

        public int Rows
        {
            get
            {
                return matrix.Columns;
            }
        }

        public int Columns
        {
            get
            {
                return matrix.Rows;
            }
        }

        public void Draw(IDrawer d)
        {
            MatrixDrawer.Draw(d, this);
        }

        
        public void DrawElement(IDrawer d, IMatrix matrixx, int row, int column)
        {
            matrix.DrawElement(d, matrixx, row, column);
        }
    }
}
