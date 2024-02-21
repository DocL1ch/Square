namespace Shapes.Api.Models.Triangle
{
    public class IsTriangleRectangularResponce
    {
        public DateTime Time { get; set; } = DateTime.UtcNow;
        public required bool IsRectangular { get; set; }
    }
}
