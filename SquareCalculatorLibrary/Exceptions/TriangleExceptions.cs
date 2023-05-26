using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalculatorLibrary.Exceptions
{
    public class TriangleNegativeSidesException : Exception
    {
        public override string Message => "Невозможен треугольник, одна или более сторон которого - отрицательны";
    }
    public class TriangleNotExistsException : Exception
    {
        public override string Message => "Невозможен треугольник с заданными длинами сторон";
    }
}
