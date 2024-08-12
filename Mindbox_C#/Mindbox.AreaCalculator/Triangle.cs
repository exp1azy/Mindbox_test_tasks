using Mindbox.AreaCalculator.Exceptions;
using Mindbox.AreaCalculator.Interfaces;

namespace Mindbox.AreaCalculator
{
    /// <summary>
    /// Класс треугольника.
    /// </summary>
    /// <param name="sideA">Сторона A.</param>
    /// <param name="sideB">Сторона B.</param>
    /// <param name="sideC">Сторона C.</param>
    public class Triangle(double sideA, double sideB, double sideC) : IShape
    {
        private readonly double _sideA = sideA;
        private readonly double _sideB = sideB;
        private readonly double _sideC = sideC;

        /// <summary>
        /// Метод вычисления площади треугольника.
        /// </summary>
        /// <returns>Площадь треугольника.</returns>
        public double CalculateArea()
        {
            if (_sideA <= 0 || _sideB <= 0 || _sideC <= 0)
                throw new LessOrEqualZeroException("Стороны треугольника не могут быть меньше, либо равными 0");
            if (_sideA + _sideB <= _sideC || _sideB + _sideC <= _sideA || _sideA + _sideC <= _sideB)
                throw new TriangleInequalityException("Нарушено неравенство треугольника");

            var maxSide = Math.Max(_sideA, Math.Max(sideB, _sideC));

            if (maxSide == _sideA)
            {
                if (_sideB * _sideB + _sideC * _sideC - maxSide * maxSide == 0)
                    return _sideB * _sideC * 0.5;
            }             
            else if (maxSide == _sideB)
            {
                if (_sideA * _sideA + _sideC * _sideC - maxSide * maxSide == 0)
                    return _sideA * _sideC * 0.5;
            }                   
            else
            {
                if (_sideA * _sideA + _sideB * _sideB - maxSide * maxSide == 0)
                    return _sideA * _sideB * 0.5;
            }

            var p = (_sideA + _sideB + _sideC) * 0.5;

            return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
        }   
    }
}
