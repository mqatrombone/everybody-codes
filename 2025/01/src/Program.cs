using System.Collections.Immutable;

namespace Whispers;

public static class Program
{
    public static async Task Main(string[] args)
    {
        var inputData = await File.ReadAllLinesAsync("Phase1Input.txt");

        LinearNameList linearNames = new(inputData.ParseNames());
        ImmutableList<NameListCommand> commands = inputData.ParseCommands();

        commands.ForEach(command => command.Command(linearNames, command.Count));

        Console.WriteLine($"Name is {linearNames.Current}");
    }
}