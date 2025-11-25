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
}