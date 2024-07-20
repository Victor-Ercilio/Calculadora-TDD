namespace Tests
{
    using NUnit.Framework;
    using Calculadora;

    [TestFixture]
    [Author("Victor Ercilio")]
    public class CalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void EmptyConstructor_ReturnsCalculatorObject()
        {
            Calculator calc;

            calc = new Calculator();

            Assert.That(calc, Is.InstanceOf<Calculator>());
        }

        [Test]
        public void Add_AddTwoNumbers_ReturnsSumOfThem()
        {
            Calculator calc = new Calculator();
            double firstNumber = 1;
            double secondNumber = 2;
            double sumResult;

            sumResult = calc.Add(firstNumber, secondNumber);
            
            Assert.That(sumResult, Is.EqualTo(firstNumber + secondNumber));
        }

        [Test]
        public void Divide_NumberDividedByZero_ThrowsDivideByZeroException()
        {
            Calculator calc = new Calculator();

            TestDelegate division = () => calc.Divide(3, 0);

            _ = Assert.Throws<DivideByZeroException>(division);
        }

        [Test]
        public void Divide_NumberByNonZeroNumber_ReturnsDivision()
        {
            Calculator calc = new Calculator();
            double divisor = 1;
            double dividend = 2;
            double resultDivision;

            resultDivision = calc.Divide(dividend, divisor);

            Assert.That(resultDivision, Is.EqualTo(dividend/divisor));
        }

        [Test]
        public void Multiply_TwoRandomNumbers_ReturnsMultiplicationOfThem()
        {
            Calculator calc = new Calculator();
            Random random = new Random();
            double firstNumber = random.NextDouble();
            double secondNumber = random.NextDouble();
            double multiplicantionResult = 0;

            multiplicantionResult = calc.Multiply(firstNumber, secondNumber);

            Assert.That(multiplicantionResult, Is.EqualTo(firstNumber * secondNumber));
        }

        [Test]
        public void Sub_TwoRandomNumbers_ReturnsSubtractionFirstBySecond()
        {
            Calculator calc = new Calculator();
            Random random = new Random();
            double firstNumber = random.NextDouble();
            double secondNumber = random.NextDouble();
            double subtractionResult = 0;

            subtractionResult = calc.Sub(firstNumber, secondNumber);

            Assert.That(subtractionResult, Is.EqualTo(firstNumber - secondNumber));
        }

        [Test]
        public void Add_SumExceedsDoubleMaximumValue_ThrowsArithmeticException()
        {
            Calculator calc = new Calculator();

            TestDelegate sum = () => calc.Add(double.MaxValue, 1);

            _ = Assert.Throws<ArithmeticException>(sum);
        }

        [Test]
        public void Add_SumExceedsDoubleMinimumValue_ThrowsArithmeticException()
        {
            Calculator calc = new Calculator();

            TestDelegate sum = () => calc.Add(double.MinValue, -1);

            _ = Assert.Throws<ArithmeticException>(sum);
        }

    }
}