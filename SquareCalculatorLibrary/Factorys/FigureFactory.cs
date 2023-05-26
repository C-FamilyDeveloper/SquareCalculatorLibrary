using SquareCalculatorLibrary.Models.Figures;

namespace SquareCalculatorLibrary.Factorys
{
    public class FigureFactory
    {
        public Triangle CreateTriangle(double side1, double side2, double side3)
        {
            if (side1 == side2 && side2 == side3)
            {
                return new EquilateralTriangle(side1);
            }
            else if ((side1 * side1 + side2 * side2 == side3 * side3) ||
                (side2 * side2 + side3 * side3 == side1 * side1) ||
                (side1 * side1 + side3 * side3 == side2 * side2))
            {               
                return new RightTriangle(side1,side2,side3);
            }
            else
            {
                return new Triangle(side1, side2, side3);
            }
        }
        public Circle CreateCircle(double radius)
        {
            return new Circle(radius);
        }
    }
}
