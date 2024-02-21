namespace Shapes.Lib
{
    /// <summary>
    /// Класс окружности
    /// </summary>
    public sealed class Circle : Shape
    {
        /// <summary>
        /// Радиус окружности
        /// </summary>
        public double R { get; set; }

        /// <summary>
        /// Конструктор окружнсоти
        /// </summary>
        /// <param name="r">Радиус окружности</param>
        /// <exception cref="ArgumentException">Радиус не может быть меньше либо равен 0</exception>
        public Circle(double r)
        {
            if (r <= 0)
                throw new ArgumentException("Radius can`t be less or equal 0");

            R = r;
        }

        /// <summary>
        /// Найти площадь окружности
        /// </summary>
        /// <returns>Площадь окружности</returns>
        public override double GetSquare()
        {
            return Math.PI * R * R;
        }
    }
}
