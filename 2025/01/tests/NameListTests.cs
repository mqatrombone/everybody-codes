namespace Whispers.Tests;

public class NameListTests
{
    [Test]
    public void CreateDoesNotAlterOrder()
    {
        const string source = "Vyrdax,Drakzyph,Fyrryn,Elarzris";
        NameList actual = new(source.Split(','));

        Assert.That(string.Join(',', actual.List), Is.EqualTo(source));
    }

    [Test]
    public void RightDoesNotGoPastLast()
    {
        const string source = "Vyrdax,Drakzyph,Fyrryn,Elarzris";
        NameList actual = new(source.Split(','));

        for (int i = 0; i <= actual.List.Count; i++)
        {
            actual.Right();
        }

        Assert.That(actual.Current, Is.EqualTo(actual.List[^1]));
    }

    [Test]
    public void LeftDoesNotGoPastFirst()
    {
        const string source = "Vyrdax,Drakzyph,Fyrryn,Elarzris";
        NameList actual = new(source.Split(','));

        actual.Right();
        actual.Left();
        actual.Left();

        Assert.That(actual.Current, Is.EqualTo(actual.List[0]));
    }

    [Test]
    [TestCase("Vyrdax,Drakzyph,Fyrryn,Elarzris", 1, "Drakzyph")]
    [TestCase("Vyrdax,Drakzyph,Fyrryn,Elarzris", 2, "Fyrryn")]
    [TestCase("Vyrdax,Drakzyph,Fyrryn,Elarzris", 3, "Elarzris")]
    [TestCase("Vyrdax,Drakzyph,Fyrryn,Elarzris", 5, "Elarzris")]
    public void RightWithArgGoesCorrectDistance(string source, int count, string expected)
    {
        NameList sut = new(source.Split(','));

        sut.Right(count);

        Assert.That(sut.Current, Is.EqualTo(expected));
    }

    [Test]
    [TestCase("Vyrdax,Drakzyph,Fyrryn,Elarzris", 1, "Fyrryn")]
    [TestCase("Vyrdax,Drakzyph,Fyrryn,Elarzris", 2, "Drakzyph")]
    [TestCase("Vyrdax,Drakzyph,Fyrryn,Elarzris", 3, "Vyrdax")]
    [TestCase("Vyrdax,Drakzyph,Fyrryn,Elarzris", 5, "Vyrdax")]
    public void LeftWithArgGoesCorrectDistance(string source, int count, string expected)
    {
        // Arrange
        NameList sut = new(source.Split(','));

        // Act
        sut.Right(3);
        sut.Left(count);

        Assert.That(sut.Current, Is.EqualTo(expected));
    }
}