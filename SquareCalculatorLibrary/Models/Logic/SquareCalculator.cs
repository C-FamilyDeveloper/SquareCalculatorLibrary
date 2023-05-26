using SquareCalculatorLibrary.Interfaces;
using SquareCalculatorLibrary.Models.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCalculatorLibrary.Models.Logic
{
    public class TriangleSquareCalculator<T> : ISquareCalculator<Triangle>
    {
        public double CalculateSquare(Triangle triangle)
        {
            double halfsum = (triangle.Side1 + triangle.Side2 + triangle.Side3) / 2.0;
            return Math.Sqrt(halfsum * (halfsum - triangle.Side1) * (halfsum - triangle.Side2) * (halfsum - triangle.Side3));
        }
    }
    public class RightTriangleSquareCalculator<T> : ISquareCalculator<RightTriangle>
    {
        public double CalculateSquare(RightTriangle triangle) => (triangle.Cathet1 * triangle.Cathet2) / 2.0;
    }
    public class EquilateralTriangleSquareCalculator<T> : ISquareCalculator<EquilateralTriangle>
    {
        public double CalculateSquare(EquilateralTriangle triangle) => (Math.Sqrt(3) * triangle.Side * triangle.Side) / 4.0;
    }
    public class CircleSquareCalculator<T> : ISquareCalculator<Circle>
    {
        public double CalculateSquare(Circle circle) => Math.PI * circle.Radius * circle.Radius;
    }
}
