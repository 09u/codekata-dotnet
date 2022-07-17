namespace LeapYear.Test;

public class Tests
{
    private LeapYear leapYear;

    [SetUp]
    public void Setup()
    {
        leapYear = new LeapYear();
    }

    [TestCase(true, 1904)]
    [TestCase(true, 1952)]
    [TestCase(true, 2000)]
    [TestCase(true, 2012)]
    [TestCase(true, 2048)]
    [TestCase(true, 2096)]
    [TestCase(false, 1700)]
    [TestCase(false, 1900)]
    [TestCase(false, 2100)]
    [TestCase(false, 2001)]
    [TestCase(false, 2014)]
    [TestCase(false, 2050)]
    public void CheckLeapYear(bool expected, int year)
    {
        Assert.AreEqual(expected, leapYear.Check(year));
    }
}