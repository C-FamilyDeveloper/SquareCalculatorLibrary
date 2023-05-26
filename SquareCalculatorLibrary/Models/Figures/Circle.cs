using SquareCalculatorLibrary.Exceptions;
using SquareCalculatorLibrary.Interfaces;
using SquareCalculatorLibrary.Models.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalculatorLibrary.Models.Figures
{
    public class Circle : IFigure
    {
        public double Radius { get; private set; }
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new CircleNegativeRadiusException();
            }
            Radius = radius;
        }

        public double GetSquare()
        {
            return new CircleSquareCalculator<Circle>().CalculateSquare(this);
        }
    }
}
