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
}