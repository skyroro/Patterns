using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Паттерны_лаб_2.Matrices;

namespace Паттерны_лаб_2
{
    public abstract class SomeMatrix : IMatrix
    {
        private IVector[] rows;

        public SomeMatrix(int row, int column)
        {
            this.Rows = row;
            this.Columns = column;

            rows = new IVector[row];

            for (int i = 0; i < row; i++)
            {
                rows[i] = CriaVector(column);
            }
        }

        protected abstract IVector CriaVector(int colums);

        public double this[int row, int column]
        {
            get { return rows[row][column]; }
            set { rows[row][column] = value; }
        }

        public int Rows { get; }
        public int Columns { get; }

        public void Draw(IDrawer d)
        {
            MatrixDrawer.Draw(d, this);
        }

        public void DrawElement(IDrawer d, IMatrix m, int row, int column)
        {
            if (IsNotNull(m[row, column]))  
                d.DrawElement(m, row, column);
            else d.DrawNull();

            //IsNotNull поверяется для матрицы которая вызвала DrawElemnt, а вызывать может только объект типа someMatrix
        }


        protected abstract bool IsNotNull(double element);
    }
}
