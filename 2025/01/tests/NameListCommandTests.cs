namespace Whispers.Tests;

public class NameListCommandTests
{
    [Test]
    [TestCase(-1)]
    [TestCase(0)]
    public void ZeroOrNegativeCountThrowsException(int count)
    {
        Assert.That(() =>
        {
            _ = new NameListCommand { Command = NameListExtensions.Right, Count = count };
        }, Throws.TypeOf<ArgumentOutOfRangeException>());
    }
}