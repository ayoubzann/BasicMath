using NUnit.Framework;
using MathApp;

namespace MathNUnitTest
{
    public class BasicMathTest
    {
        [TestCase(1, 1, 2)]
        [TestCase(10, 10, 20)]
        [TestCase(10, -5, 5)]
        [TestCase(1, 0, 1)]
        public void Test_AddMethod(int number1, int number2, int expected)
        {
            BasicMath basicMath = new BasicMath();
            double actual = basicMath.Add(number1, number2);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_SubtractMethod()
        {
            BasicMath basicMath = new BasicMath();
            double actual = basicMath.Subtract(10, 9);

            Assert.AreEqual(1, actual);
        }

        [Test]
        public void Test_MultiplyMethod()
        {
	        BasicMath basicMath = new BasicMath();
	        double actual = basicMath.Multiply(10, 10);

	        Assert.AreEqual(100, actual);
        }

		[TestCase(1, 1, 1)]
        [TestCase(10, 5, 2)]
        [TestCase(10, -5, -2)]
        [TestCase(7, 0, 7)]
        public void Test_DivideMethod(int number1, int number2, int expected)
        {
            BasicMath basicMath = new BasicMath();
            double actual = basicMath.Divide(number1, number2);

            Assert.AreEqual(expected, actual);
        }
    }
}