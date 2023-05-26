using SquareCalculatorLibrary.Exceptions;
using SquareCalculatorLibrary.Interfaces;
using SquareCalculatorLibrary.Models.Logic;

namespace SquareCalculatorLibrary.Models.Figures
{
    public class Triangle : IFigure
    {
        public double Side1 { get; private set; }
        public double Side2 { get; private set; }
        public double Side3 { get; private set; }

        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new TriangleNegativeSidesException();
            }
            if (side1 + side2 <= side3 || side2 + side3 <= side1 || side1 + side3 <= side2)
            {
                throw new TriangleNotExistsException();
            }
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public virtual double GetSquare()
        {
            return new TriangleSquareCalculator<Triangle>().CalculateSquare(this);
        }
    }
    public class RightTriangle : Triangle
    {
        public double Hypotenuse { get; private set; }
        public double Cathet1 { get; private set; }
        public double Cathet2 { get; private set; }

        public RightTriangle(double side1, double side2, double side3) : base(side1, side2, side3)
        {
            List<double> sides = new() { side1, side2, side3 };
            double hypotenuse = sides.Max();
            sides.Remove(hypotenuse);
            Hypotenuse = hypotenuse;
            Cathet1 = sides[0];
            Cathet2 = sides[1];
        }
        public override double GetSquare()
        {
            return new RightTriangleSquareCalculator<RightTriangle>().CalculateSquare(this);
        }
    }
    public class EquilateralTriangle : Triangle
    {
        public double Side { get; private set; }
        public EquilateralTriangle(double side) : base(side, side, side)
        {
            Side = side;
        }
        public override double GetSquare()
        {
            return new EquilateralTriangleSquareCalculator<EquilateralTriangle>().CalculateSquare(this);
        }
    }
}
