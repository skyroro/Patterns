﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Паттерны_лаб_2
{
    public interface IVector
    {
        double this[int index] { get; set; }
        int Dimension { get; }
    }
}
