using Mindbox.AreaCalculator.Exceptions;

namespace Mindbox.AreaCalculator.Tests
{
    [TestClass]
    public class CircleClassTest
    {
        [TestMethod]
        public void ValidCircle()
        {
            var circle = new Circle(1);
            var result = circle.CalculateArea();

            Assert.AreEqual(Math.PI, result);
        }

        [TestMethod]
        public void InvalidCircle()
        {
            var circle = new Circle(-1);
            Assert.ThrowsException<LessOrEqualZeroException>(() => circle.CalculateArea());
        }
    }
}
