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

        var firstParentNameInput = await File.ReadAllLinesAsync("Phase2Input.txt");
        CircularNameList circularNames = new(firstParentNameInput.ParseNames());
        ImmutableList<NameListCommand> firstParentNameCommands = firstParentNameInput.ParseCommands();

        firstParentNameCommands.ForEach(command => command.Command(circularNames, command.Count));

        Console.WriteLine($"First Parent Name is {circularNames.Current}");

        var secondParentNameInput = await File.ReadAllLinesAsync("Phase3Input.txt");
        SwappingNameList swappingNames = new(secondParentNameInput.ParseNames());
        ImmutableList<NameListCommand> secondParentNameCommands = secondParentNameInput.ParseCommands();

        secondParentNameCommands.ForEach(command => command.Command(swappingNames, command.Count));

        Console.WriteLine($"Second Parent Name is {swappingNames.List[0]}");
    }
}