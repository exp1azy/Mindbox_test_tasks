namespace Mindbox.AreaCalculator.Exceptions
{
    /// <summary>
    /// Исключение выбрасывается, когда нарушено неравенство треугольника.
    /// </summary>
    public class TriangleInequalityException : Exception
    {
        public TriangleInequalityException() : base() { }
        public TriangleInequalityException(string message) : base(message) { }
    }
}
