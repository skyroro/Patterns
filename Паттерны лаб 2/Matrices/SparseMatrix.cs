using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Паттерны_лаб_2
{
    public class SparseMatrix : SomeMatrix
    {
        public SparseMatrix(int row, int column) : base(row, column) { }

        protected override IVector CriaVector(int column)
        {
            return new SparseVector(column);
        }

        protected override bool IsNotNull(double element)
        {
            if (element == 0) return false;
            else return true;
        }
    }
}
