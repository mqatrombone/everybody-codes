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
}