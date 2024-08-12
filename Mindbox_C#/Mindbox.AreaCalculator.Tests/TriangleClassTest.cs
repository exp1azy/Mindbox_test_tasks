using Mindbox.AreaCalculator;
using Mindbox.AreaCalculator.Exceptions;

namespace AreaCalculator.Tests
{
    [TestClass]
    public class TriangleClassTest
    {
        [TestMethod]
        public void ValidTriangle()
        {
            var triangle = new Triangle(2, 2, 2);
            var result = triangle.CalculateArea();

            Assert.AreEqual(1.7320508075688772, result);
        }

        [TestMethod]
        public void ValidRightTriangle()
        {
            var triangle = new Triangle(3, 4, 5);
            var result = triangle.CalculateArea();

            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void ThrowsLessOrEqualZeroException()
        {
            var triangle = new Triangle(0, 1, 2);

            Assert.ThrowsException<LessOrEqualZeroException>(() => triangle.CalculateArea());
        }

        [TestMethod]
        public void ThrowsTriangleInequalityException()
        {
            var triangle = new Triangle(1, 2, 3);

            Assert.ThrowsException<TriangleInequalityException>(() => triangle.CalculateArea());
        }
    }
}