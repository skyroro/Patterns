using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Паттерны_лаб_2.Matrices
{
    public class HorizontalGroupMatrix : IMatrix
    {

        private List<IMatrix> matrices = new List<IMatrix>();
        public void AddMatrix(IMatrix matrix)
        {
            matrices.Add(matrix);
        }

        public int Rows
        {
            get
            {
                int rows = 0;
                foreach (IMatrix matrix in matrices)
                {
                    if (matrix.Rows > rows)
                        rows = matrix.Rows;
                }
                return rows;
            }
        }

        public int Columns
        {
            get
            {
                int columns = 0;
                foreach (IMatrix matrix in matrices)
                {
                    columns += matrix.Columns;
                }
                return columns;
            }
        }

        public double this[int row, int column]
        {
            get 
            {
                int passedColumns = 0;
                int past = 0;

                foreach (IMatrix matrix in matrices)
                {
                    passedColumns += matrix.Columns;
                    if (column < passedColumns)
                    {
                        if (row < matrix.Rows)
                        {
                            return matrix[row, column - past];
                        }
                        else return 0;
                    }
                    past += matrix.Columns;
                }

                return 0;
            }
            set 
            {
                int passedColumns = 0;
                int past = 0;

                foreach (IMatrix matrix in matrices)
                {
                    passedColumns += matrix.Columns;
                    if(column < passedColumns)
                    {
                        if (row < matrix.Rows)
                            matrix[row, column - past] = value;
                        return;
                    }
                    past += matrix.Columns;
                }
            }
        }

        public void Draw(IDrawer d)
        {
            MatrixDrawer.Draw(d, this);
        }

        

        public IMatrix GetMatrixM(IMatrix matrixx, int row, int column)
        {
            IMatrix m;
            if (IsTransp(matrixx)) m = GetMatrix(column - GetIndent(column, matrixx), row);
            else m = GetMatrix(row, column - GetIndent(column, matrixx));
            return m;
        }

        bool IsTransp (IMatrix matrixx)
        {
            bool transp = true;
            for (int row = 0; row < this.Rows; row++)
            {
                for (int column = 0; column < this.Columns; column++)
                {
                    if (this[row, column] != matrixx[column, row]) transp = false;
                }
            }
            return transp;
        }

        int GetIndent(int column, IMatrix matrixx)
        {
            int indent = 0;
            if(column >= matrixx.Columns) indent = matrixx.Columns;
            return indent;
        }
        public IMatrix GetMatrix(int row, int column)
        {
            IMatrix m = new SparseMatrix(1, 1);
            int passedColumns = 0;
            int pastc = 0;

            foreach (IMatrix matrix in matrices)
            {
                passedColumns += matrix.Columns;
                if (column < pastc) break;
                if (column < passedColumns)
                {
                    if (row < matrix.Rows)
                    {
                        m = matrix;
                        return m;
                    }
                }
                pastc += matrix.Columns;
            }
            return m;
        }

        public void DrawElement(IDrawer d, IMatrix matrixx, int row, int column)
        {            
            IMatrix m;
            m = GetMatrixM(matrixx, row, column);
            //m = GetMatrix(row, column);
            m.DrawElement(d, matrixx, row, column);
        }
    }
}