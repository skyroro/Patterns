using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Паттерны_лаб_2
{
    public class UsualMatrix : SomeMatrix
    {
        public UsualMatrix(int row, int column) : base(row, column) { }

        protected override IVector CriaVector(int column)
        {
            return new UsualVector(column);
        }

        protected override bool IsNotNull(double element)
        {
            return true;
        }
    }
}
