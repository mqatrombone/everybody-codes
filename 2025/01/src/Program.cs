using System.Collections.Immutable;

namespace Whispers;

public static class Program
{
    public static async Task Main(string[] args)
    {
        var nameInputData = await File.ReadAllLinesAsync("Phase1Input.txt");

        LinearNameList linearNames = new(nameInputData.ParseNames());
        ImmutableList<NameListCommand> nameCommands = nameInputData.ParseCommands();

        nameCommands.ForEach(command => command.Command(linearNames, command.Count));

        Console.WriteLine($"Name is {linearNames.Current}");

        var parentNameInputData = await File.ReadAllLinesAsync("Phase2Input.txt");
        CircularNameList circularNames = new(parentNameInputData.ParseNames());
        ImmutableList<NameListCommand> parentNameCommands = parentNameInputData.ParseCommands();

        parentNameCommands.ForEach(command => command.Command(circularNames, command.Count));

        Console.WriteLine($"First Parent Name is {circularNames.Current}");
    }
}