namespace Whispers.Tests;

public class NameListCommandTests
{
    [Test]
    public void ZeroOrNegativeCountThrowsException()
    {
        Assert.That(() =>
        {
            _ = new NameListCommand { Command = NameListExtensions.Right, Count = -1 };
        }, Throws.TypeOf<ArgumentOutOfRangeException>());
    }
}