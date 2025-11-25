namespace Whispers.Tests;

public class FileExtensionsTests
{
    [Test]
    public async Task NamesParseCorrectly()
    {
        var inputFileStream = await File.ReadAllLinesAsync("TestInput.txt");

        var inputNames = inputFileStream.ParseNames();

        LinkedList<string> expectedNames = new();
        expectedNames.AddLast("Vyrdax");
        expectedNames.AddLast("Drakzyph");
        expectedNames.AddLast("Fyrryn");
        expectedNames.AddLast("Elarzris");

        Assert.That(inputNames, Is.EqualTo(expectedNames));
    }
}