using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Паттерны_лаб_2
{
    public interface IDrawer
    {
        void DrawBord(IMatrix matrix);
        void DrawBordElement(int row, int column);
        void DrawElement(IMatrix matrix, int row, int column);       
        void DrawNull();
        void DrawPass();
        void Clear();
    }
}
