namespace Whispers.Tests;

public class CircularNameListTests
{
    [Test]
    public void CreateDoesNotChangeOrder()
    {
        const string source = "Vyrdax,Drakzyph,Fyrryn,Elarzris";
        CircularNameList actual = new(source.Split(','));

        Assert.That(string.Join(',', actual.List), Is.EqualTo(source));
    }
}