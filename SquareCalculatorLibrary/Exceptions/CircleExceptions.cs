using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalculatorLibrary.Exceptions
{
    public class CircleNegativeRadiusException : Exception
    {
        public override string Message => "Невозможен круг отрицательного радиуса";
    }
}
