namespace FizzBuzz.Test;

public class FizzBuzzTests
{

    private FizzBuzz fizzbuzz;

    [SetUp]
    public void Setup()
    {
        fizzbuzz = new FizzBuzz();
    }

    [TestCase(1, "1")]
    [TestCase(3, "Fizz")]
    [TestCase(5, "Buzz")]
    [TestCase(6, "Fizz")]
    [TestCase(7, "7")]
    [TestCase(10, "Buzz")]
    [TestCase(15, "Fizz Buzz")]
    [TestCase(30, "Fizz Buzz")]
    [TestCase(62, "62")]
    public void FizzBuzzCheckTestCase(int input, string expected)
    {
        Assert.AreEqual(expected, fizzbuzz.Check(input));
    }
}