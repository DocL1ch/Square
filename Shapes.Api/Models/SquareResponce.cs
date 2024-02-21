namespace Shapes.Api.Models
{
    public class SquareResponce
    {
        public DateTime Time { get; set; } = DateTime.UtcNow;
        public required double Square { get; set; }
    }
}
