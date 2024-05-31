using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Паттерны_лаб_2
{
    public class MatrixStatistics
    {
        public double Sum { get; }
        public double Average { get; }
        public double Max { get; }
        public int NoZero { get; }

        public MatrixStatistics(IMatrix matrix)
        {
            Sum = СalculationSum(matrix);
            Average = СalculationAverage(matrix);
            Max = СalculationMax(matrix);
            NoZero = СalculationNoZero(matrix);

        }

        double СalculationSum(IMatrix matrix)
        {
            double tempSum = 0;

            int rows = matrix.Rows;
            int columns = matrix.Columns;

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    double temp = matrix[row, column];
                    tempSum += temp;
                }
            }

            return tempSum;
        }

        double СalculationAverage(IMatrix matrix)
        {
            int n = matrix.Rows * matrix.Columns;
            double tempAverage = Sum / n;

            return tempAverage;
        }

        double СalculationMax(IMatrix matrix)
        {
            double tempMax = Double.MinValue;

            int rows = matrix.Rows;
            int columns = matrix.Columns;

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    double temp = matrix[row, column];
                    if (temp > tempMax)
                        tempMax = temp;
                }
            }

            return tempMax;
        }

        int СalculationNoZero(IMatrix matrix)
        {
            int n = 0;

            int rows = matrix.Rows;
            int columns = matrix.Columns;

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    double temp = matrix[row, column];
                    if (temp != 0)
                        n++;
                }
            }

            return n;
        }
    }
}
