namespace Mindbox.AreaCalculator.Exceptions
{
    /// <summary>
    /// Исключение выбрасывается в случаях, когда передаваемое значение меньше, либо равно нулю.
    /// </summary>
    public class LessOrEqualZeroException : Exception
    {
        public LessOrEqualZeroException() : base() { }
        public LessOrEqualZeroException(string message) : base(message) { }
    }
}
