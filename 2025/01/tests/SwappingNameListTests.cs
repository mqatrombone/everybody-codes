namespace Whispers.Tests;

public class SwappingNameListTests
{
    [Test]
    public void ConstructorDoesNotChangeOrder()
    {
        const string source = "Vyrdax,Drakzyph,Fyrryn,Elarzris";
        SwappingNameList actual = new(source.Split(','));

        Assert.That(string.Join(',', actual.List), Is.EqualTo(source));
    }

    [Test]
    public void RightOneSwapsCorrectly()
    {
        const string source = "Vyrdax,Drakzyph,Fyrryn,Elarzris";
        SwappingNameList sut = new(source.Split(','));
        sut.Right(1);

        const string expected = "Drakzyph,Vyrdax,Fyrryn,Elarzris";
        Assert.That(string.Join(',', sut.List), Is.EqualTo(expected));
    }
}