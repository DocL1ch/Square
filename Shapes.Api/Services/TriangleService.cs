using Shapes.Lib;

namespace Shapes.Api.Services
{
    public class TriangleService
    {
        public TriangleService() { }

        public double GetSquare(double a, double b, double c)
        {
            var t = new Triangle(a, b, c);
            return t.GetSquare();
        }

        public bool IsRectangular(double a, double b, double c)
        {
            var t = new Triangle(a, b, c);
            return t.IsRectangular;
        }
    }
}
