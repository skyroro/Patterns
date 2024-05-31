using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Паттерны_лаб_2
{
    public class UsualVector : IVector
    {
        private double[] vector;

        public UsualVector(int dimension)
        {
            vector = new double[dimension];
        }

        public double this[int index]
        {
            get { return vector[index]; }
            set { vector[index] = value; }
        }

        public int Dimension
        {
            get { return vector.Length; }
        }
    }
}
