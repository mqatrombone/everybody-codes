using System.Collections.Immutable;

namespace Whispers;

public static class FileStreamExtensions
{
    extension(string[] inputLines)
    {
        public LinkedList<string> ParseNames()
        {
            var names = inputLines[0].Split(',');
            return new LinkedList<string>(names);
        }

        public ImmutableList<NameListCommand> ParseCommands()
        {
            var commands = inputLines[^1].Split(',');
            return commands.Select(x => new NameListCommand
            {
                Command = x[0] switch
                {
                    'R' => INameListExtensions.Right,
                    'L' => INameListExtensions.Left,
                    _ => throw new ArgumentOutOfRangeException(nameof(inputLines))
                },
                Count = int.Parse(x[1..])
            }).ToImmutableList();
        }
    }
}