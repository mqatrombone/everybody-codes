using System.Collections.Immutable;

namespace Whispers;

public static class FileStreamExtensions
{
    public static LinkedList<string> ParseNames(this string[] inputLines)
    {
        var names = inputLines[0].Split(',');
        return new LinkedList<string>(names);
    }

    public static ImmutableList<NameListCommand> ParseCommands(this string[] inputLines)
    {
        var commands = inputLines[^1].Split(',');
        return commands.Select(x => new NameListCommand
        {
            Command = x[0] switch
            {
                'R' => NameListExtensions.Right,
                'L' => NameListExtensions.Left,
                _ => throw new ArgumentOutOfRangeException(nameof(inputLines))
            },
            Count = int.Parse(x[1..])
        }).ToImmutableList();
    }
}