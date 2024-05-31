using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Паттерны_лаб_2
{
    public class SparseVector : IVector
    {
        private Dictionary<int, double> vector;

        public SparseVector(int dimension)
        {
            this.Dimension = dimension;
            vector = new Dictionary<int, double>(dimension);
        }

        public double this[int index]
        {
            get
            {
                if (vector.ContainsKey(index))
                    return vector[index];
                else return 0;
            }
            set
            {
                if (index < 0 || index > Dimension)
                {
                    throw new KeyNotFoundException($"The key '{index}' does not exist in the dictionary.");
                }

                vector[index] = value;
            }
        }

        public int Dimension
        {
            get;
        }
    }
}
