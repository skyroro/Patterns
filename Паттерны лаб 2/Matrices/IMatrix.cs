using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Паттерны_лаб_2
{
    public interface IMatrixPro
    {
        double this[int row, int column] { get; set; }
        int Rows { get; }
        int Columns { get; }
        void Draw(IDrawer d);
    }

    public interface IMatrix : IMatrixPro
    {
        void DrawElement(IDrawer d, IMatrix matrix, int row, int column);

    }

}
