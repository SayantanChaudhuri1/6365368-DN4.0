using CalcLibrary;
using NUnit.Framework;


namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calc;

        [SetUp]
        public void SetUp()
        {
            calc = new Calculator();
        }

        [TearDown]
        public void TearDown()
        {
            // Clean up if needed
        }

        [TestCase(2, 3, 5)]
        [TestCase(0, 0, 0)]
        [TestCase(-1, -1, -2)]
        public void Add_ShouldReturnCorrectSum(int a, int b, int expected)
        {
            int result = calc.Add(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
