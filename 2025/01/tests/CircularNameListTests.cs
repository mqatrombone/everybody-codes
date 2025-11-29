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

    [Test]
    public void LeftLoopsBackToLast()
    {
        const string source = "Vyrdax,Drakzyph,Fyrryn,Elarzris";
        CircularNameList sut = new(source.Split(','));

        sut.Left();

        Assert.That(sut.Current, Is.EqualTo("Elarzris"));
    }

    [Test]
    public void RightLoopsBackToFirst()
    {
        const string source = "Vyrdax,Drakzyph,Fyrryn,Elarzris";
        CircularNameList sut = new(source.Split(','));

        sut.Left();
        sut.Right();

        Assert.That(sut.Current, Is.EqualTo("Vyrdax"));
    }
}