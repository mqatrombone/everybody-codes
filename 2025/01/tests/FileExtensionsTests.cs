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
    
    [Test]
    public async Task CommandsParseCorrectly()
    {
        var inputFileStream = await File.ReadAllLinesAsync("TestInput.txt");

        var inputCommands = inputFileStream.ParseCommands();
        
        // R3,L2,R3,L1
        List<NameListCommand> expectedCommands =
        [
            new() { Command = NameListExtensions.Right, Count = 3 },
            new() { Command = NameListExtensions.Left, Count = 2 },
            new() { Command = NameListExtensions.Right, Count = 3 },
            new() { Command = NameListExtensions.Left, Count = 1 }
        ];
        
        Assert.That(inputCommands, Is.EqualTo(expectedCommands));
    }
}