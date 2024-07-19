namespace Tests
{
    using NUnit.Framework;

    [TestFixture]
    [Author("Victor Ercilio")]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void InstanciateCalculator_EmptyConstructor_ReturnsCalculatorObject()
        {
            Assert.Pass();
        }
    }
}