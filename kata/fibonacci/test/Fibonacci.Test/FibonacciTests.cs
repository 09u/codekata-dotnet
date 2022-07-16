using System.Numerics;
using NUnit.Framework;

namespace Fibonacci.Tests
{
    [TestFixture]
    class TestFibonacci
    {
        private Fibonacci fib;

        [SetUp]
        public void SetUp()
        {
            fib = new Fibonacci();
        }

        [TestCase("0", "0")]
        [TestCase("1", "1")]
        [TestCase("2", "1")]
        [TestCase("3", "2")]
        [TestCase("4", "3")]
        [TestCase("5", "5")]
        [TestCase("6", "8")]
        [TestCase("7", "13")]
        [TestCase("50", "12586269025")]
        [TestCase("100", "354224848179261915075")]
        public void First_number_should_be_one(string actual, string expected)
        {
            Assert.AreEqual(BigInteger.Parse(expected), fib.Calculate(BigInteger.Parse(actual))); 
        }

        [Test]
        public void First_number_should_be_one()
        {
            Assert.AreEqual((BigInteger) 1, fib.Calculate((BigInteger) 1));
        }
    }
}
