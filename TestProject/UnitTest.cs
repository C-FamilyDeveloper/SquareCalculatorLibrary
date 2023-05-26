using SquareCalculatorLibrary.Interfaces;
using SquareCalculatorLibrary.Exceptions;
using SquareCalculatorLibrary.Factorys;
using SquareCalculatorLibrary.Models.Figures;

namespace TestProject
{
    public class Tests
    {
        [Test]
        public void TestNegativeSidesTriangle()
        {
            Assert.Throws<TriangleNegativeSidesException>(() =>
            {
                IFigure figure = new FigureFactory().CreateTriangle(-1, 2, 3);
            });
        }
        [Test]
        public void TestNonRightSidesTriangle()
        {
            Assert.Throws<TriangleNotExistsException>(() =>
            {
                IFigure figure = new FigureFactory().CreateTriangle(1, 1, 5);
            });
        }
        [Test]
        public void TestNegativeRadiusCircle()
        {
            Assert.Throws<CircleNegativeRadiusException>(() =>
            {
                IFigure figure = new FigureFactory().CreateCircle(-2);
            });
        }
        [Test]
        public void TestCreateRightTypeOfEquilateralTriangle()
        {
            IFigure figure = new FigureFactory().CreateTriangle(1.383838, 1.383838, 1.383838);
            Assert.IsTrue(figure is EquilateralTriangle);
        }
        [Test]
        public void TestCreateRightTypeOfRightTriangle()
        {
            IFigure figure = new FigureFactory().CreateTriangle(3, 4, 5);
            Assert.IsTrue(figure is RightTriangle);
        }
        [TestCase(3,4,5, ExpectedResult = 6)]
        public double TestResultsOfCalculatingTriangleResults(double side1, double side2, double side3)
        {
            IFigure figure = new FigureFactory().CreateTriangle(side1,side2,side3);
            return figure.GetSquare();
        }
        [TestCase(3)]
        public void TestResultsOfCalculatingCircleResults(double radius)
        {
            IFigure figure = new FigureFactory().CreateCircle(radius);
            Assert.That(figure.GetSquare(), Is.EqualTo(28.27).Within(0.01));
        }
    }
}