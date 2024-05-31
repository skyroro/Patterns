using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Паттерны_лаб_2
{
    public static class MatrixInitializer
    {
        public static void Fill(IMatrix matrix, int nonZero, double maxValue)
        {
            Random rand = new Random();
            int rows = matrix.Rows;
            int columns = matrix.Columns;

            int nonZeroCount = 0;

            while (nonZeroCount < nonZero)
            {
                int row = rand.Next(rows);
                int column = rand.Next(columns);
                double value = rand.NextDouble() * maxValue;

                if (value != 0 && matrix[row, column] == 0)
                    nonZeroCount++;

                matrix[row, column] = value;
            }

        }

        public static void Fill(IMatrix matrix, int value)
        {
            int rows = matrix.Rows;
            int columns = matrix.Columns;

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    matrix[row, column] = value;
                }
            }

        }
    }
}
