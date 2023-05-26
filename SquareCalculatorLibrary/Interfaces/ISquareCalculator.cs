using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalculatorLibrary.Interfaces
{
    interface ISquareCalculator<T> where T : IFigure
    {
        double CalculateSquare(T figure);
    }
}
