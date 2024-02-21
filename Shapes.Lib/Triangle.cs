namespace Shapes.Lib
{
    /// <summary>
    /// Класс треугольника
    /// </summary>
    public sealed class Triangle : Shape
    {
        /// <summary>
        /// Сторона A
        /// </summary>
        public double A { get; set; }
        /// <summary>
        /// Сторона B
        /// </summary>
        public double B { get; set; }
        /// <summary>
        /// Сторона C
        /// </summary>
        public double C { get; set; }

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        public bool IsRectangular {
            get
            {
                var square = new[] { A, B, C }
                            .OrderBy(x => x)
                            .Select(x => x * x)
                            .ToArray();

                return square[0] + square[1] == square[2];
            } 
        }

        /// <summary>
        /// Конструктор треугольника
        /// </summary>
        /// <param name="a">Сторона A треугольника</param>
        /// <param name="b">Сторона B треугольника</param>
        /// <param name="c">Сторона C треугольника</param>
        /// <exception cref="ArgumentException">Указаны неккоректные стороны треугольника. Треугольник не может существовать</exception>
        public Triangle(double a, double b, double c)
        {
            if (!Exists(a, b, c))
                throw new ArgumentException("Invalid side size");

            A = a;
            B = b;  
            C = c;  
        }

        /// <summary>
        /// Функция вычисления периметра треугольника
        /// </summary>
        /// <returns>Периметр треугольника</returns>
        public double GetPerimeter()
        {
            return A + B + C;
        }

        /// <summary>
        /// Функция вычисления площади треугольника
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        public override double GetSquare()
        {
            var halfP = GetPerimeter() / 2;
            return Math.Sqrt(halfP * (halfP - A) * (halfP - B) * (halfP - C));
        }

        /// <summary>
        /// Может ли существовать треугольник с заданными сторонами
        /// </summary>
        /// <param name="a">Сторона A треугольника</param>
        /// <param name="b">Сторона B треугольника</param>
        /// <param name="c">Сторона C треугольника</param>
        /// <returns>Существует ли треугольник</returns>
        private bool Exists(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
}
