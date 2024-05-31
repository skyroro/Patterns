using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Паттерны_лаб_2.Matrices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Паттерны_лаб_2
{
    internal class RenumberingMatrixDecorator : IMatrix
    {
        IMatrix matrix;
        int[] indexRows;
        int[] indexCols;

        public RenumberingMatrixDecorator(IMatrix matrix)
        {
            this.matrix = matrix;

            indexRows = new int[matrix.Rows +1 ];
            indexCols = new int[matrix.Columns+1];

            for(int i = 0; i < matrix.Rows; i++)
            {
                indexRows[i] = i;
            }
            for (int i = 0; i < matrix.Columns; i++)
            {
                indexCols[i] = i;
            }           
        }

        public void RenumberingRows()
        {
            Random rand = new Random();
            int rows = matrix.Rows;
            int rowOne = rand.Next(rows);
            int rowTwo = rand.Next(rows);

            int temp = indexRows[rowOne];
            indexRows[rowOne] = indexRows[rowTwo];
            indexRows[rowTwo] = temp;
        }

        public void RenumberingColumns()
        {
            Random rand = new Random();
            int columns = matrix.Columns;
            int rowOne = rand.Next(columns);
            int rowTwo = rand.Next(columns);

            int temp = indexCols[rowOne];
            indexCols[rowOne] = indexCols[rowTwo];
            indexCols[rowTwo] = temp;
        }

        public void RecoverRows()
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                indexRows[i] = i;
            }
        }

        public void RecoverColumns()
        {
            for (int i = 0; i < matrix.Columns; i++)
            {
                indexCols[i] = i;
            }
        }

        public double this[int row, int column]
        {
            get 
            {
                return matrix[indexRows[row], indexCols[column]]; 
            }
            set 
            {
                matrix[row, column] = value; 
            }
        }

        public IMatrix matrixIdentity { get; set; }

        public int Rows 
        { 
            get 
            {
                return matrix.Rows;
            }
        }

        public int Columns 
        {
            get
            {
                return matrix.Columns;
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
