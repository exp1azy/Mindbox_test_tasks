using Mindbox.AreaCalculator.Exceptions;
using Mindbox.AreaCalculator.Interfaces;

namespace Mindbox.AreaCalculator
{
    /// <summary>
    /// Класс круга.
    /// </summary>
    /// <param name="radius">Радиус круга.</param>
    public class Circle(double radius) : IShape
    {
        private readonly double _radius = radius;

        /// <summary>
        /// Метод вычисления площади круга.
        /// </summary>
        /// <returns>Площадь круга.</returns>
        public double CalculateArea()
        {
            if (_radius <= 0)
                throw new LessOrEqualZeroException("Радиус круга не может быть меньше, либо равен 0");

            return Math.PI * _radius * _radius;
        }
    }
}
