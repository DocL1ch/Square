using Shapes.Lib;

namespace Shapes.Api.Services
{
    public class CircleService
    {
        public CircleService() { }

        public double GetSquare(double radius)
        {
            var c = new Circle(radius);
            return c.GetSquare();
        }
    }
}
