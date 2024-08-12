namespace Mindbox.AreaCalculator.Interfaces
{
    /// <summary>
    /// Интерфейс геометрической фигуры.
    /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Метод вычисления площади фигуры.
        /// </summary>
        /// <returns>Площадь фигуры.</returns>
        public double CalculateArea();
    }
}
