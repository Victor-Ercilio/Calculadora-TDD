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

            Assert.That(calc, Is.Not.Null);
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

    }
}