namespace Tests
{
    using NUnit.Framework;
    using Calculadora;
    using System.Numerics;

    [TestFixture]
    [Author("Victor Ercilio")]
    public class CalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        #region Constructor
        [Test]
        public void EmptyConstructor_ReturnsCalculatorObject()
        {
            Calculator calc;

            calc = new Calculator();

            Assert.That(calc, Is.InstanceOf<Calculator>());
        }

        #endregion

        #region Method Add
        [TestCase(1, 2, 3)]
        [TestCase(-2, 1, -1)]
        [TestCase(0, 1, 1)]
        public void Add_AddTwoNumbers_ReturnsCorrectvalue(double first, double second, double expected)
        {
            double actual = Calculator.Add(first, second);
            
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Add_SumExceedsDoubleMaximumValue_ThrowsArithmeticException()
        {
            TestDelegate sum = () => Calculator.Add(double.MaxValue, 1);

            _ = Assert.Throws<ArithmeticException>(sum);
        }

        [Test]
        public void Add_SumExceedsDoubleMinimumValue_ThrowsArithmeticException()
        {
            TestDelegate sum = () => Calculator.Add(double.MinValue, -1);

            _ = Assert.Throws<ArithmeticException>(sum);
        }
        #endregion

        #region Method Divide
        [Test]
        public void Divide_NumberDividedByZero_ThrowsDivideByZeroException()
        {
            TestDelegate division = () => Calculator.Divide(1, 0);

            _ = Assert.Throws<DivideByZeroException>(division);
        }

        [TestCase(4, 2, 2)]
        [TestCase(2, 1, 2)]
        [TestCase(9, 3, 3)]
        public void Divide_NumberByNonZeroNumber_ReturnsCorrectValue(double dividend, double divisor, double expected)
        {
            double actual = Calculator.Divide(dividend, divisor);

            Assert.That(actual, Is.EqualTo(expected));
        }

        #endregion

        #region Method Multiply
        [TestCase(1, 2, 2)]
        [TestCase(0, 2, 0)]
        [TestCase(2, -3, -6)]
        public void Multiply_TwoNumbers_ReturnsCorrectValue(double firstNumber, double secondNumber, double expected)
        {
            double actual = Calculator.Multiply(firstNumber, secondNumber);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Multiply_MultiplicationExceedsMaxiumDouble_ThrowsArithmethicExcepion()
        {
            TestDelegate actual = () => Calculator.Multiply(10, double.MaxValue);

            Assert.Throws<ArithmeticException>(actual);
        }

        [Test]
        public void Multiply_MultiplicationExceedsMinimunDouble_ThrowsArithmethicExcepion()
        {
            TestDelegate actual = () => Calculator.Multiply(-10, double.MinValue);

            Assert.Throws<ArithmeticException>(actual);
        }
        #endregion

        #region Method Sub
        [TestCase(1, 2, -1)]
        [TestCase(2, 2, 0)]
        [TestCase(2, 1, 1)]
        public void Sub_TwoRandomNumbers_ReturnsCorrectValue(double minuend, double subtrahend, double expected)
        {
            double actual = Calculator.Sub(minuend, subtrahend);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Sub_SumExceedsDoubleMaximumValue_ThrowsArithmeticException()
        {
            TestDelegate sum = () => Calculator.Sub(double.MaxValue, -1);

            _ = Assert.Throws<ArithmeticException>(sum);
        }

        [Test]
        public void Sub_SumExceedsDoubleMinimumValue_ThrowsArithmeticException()
        {
            TestDelegate sum = () => Calculator.Sub(double.MinValue, 1);

            _ = Assert.Throws<ArithmeticException>(sum);
        }

        #endregion

        #region Method Fibonnaci
        [TestCase(0, new int[0])]
        [TestCase(1, new int[1] {0})]
        [TestCase(2, new int[2] {0, 1})]
        [TestCase(3, new int[3] {0, 1, 1})]
        [TestCase(4, new int[4] {0, 1, 1, 2})]
        public void Fibonacci_ValidNumber_ReturnsExpectedArray(int numbers, int[] expected)
        {
            int[] actual;

            actual = Calculator.Fibonacci(numbers);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Fibonacci_InvalidNumber_ThrowsArgumentException()
        {
            int numbers = -1;

            TestDelegate actual = () => Calculator.Fibonacci(numbers);

            Assert.Throws<ArgumentException>(actual);
        }

        #endregion
    }
}