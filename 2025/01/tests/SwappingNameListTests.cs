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

    [Test]
    public void LeftOneSwapsCorrectly()
    {
        const string source = "Vyrdax,Drakzyph,Fyrryn,Elarzris";
        SwappingNameList sut = new(source.Split(','));
        sut.Left(1);

        const string expected = "Elarzris,Drakzyph,Fyrryn,Vyrdax";
        Assert.That(string.Join(',', sut.List), Is.EqualTo(expected));
    }

    [Test]
    public void ExampleBehavesCorrectly()
    {
        const string source = "Vyrdax,Drakzyph,Fyrryn,Elarzris";
        SwappingNameList sut = new(source.Split(','));

        sut.Right(3);
        sut.Left(2);
        sut.Right(3);
        sut.Left(3);

        const string expected = "Drakzyph,Vyrdax,Elarzris,Fyrryn";
        Assert.That(string.Join(',', sut.List), Is.EqualTo(expected));
    }
}