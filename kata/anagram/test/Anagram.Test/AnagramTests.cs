namespace Anagram.Test;

public class AnagramTests
{
    private Anagram _anagram;
    [SetUp]
    public void Setup()
    {
        _anagram = new Anagram();
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }

    [Test]
    public void TwoCharacters()
    {
        var expected = new List<string> { "AB", "BA" };
        Assert.AreEqual(expected, _anagram.Of("AB"));
    }

    [Test]
    public void ThreeCharacters()
    {
        var expected = new List<string> { "ABC", "ACB", "BAC", "BCA", "CAB", "CBA" };
        Assert.That(_anagram.Of("ABC"), Is.EqualTo(expected));
    } 

}