using System.Collections.Immutable;

namespace Whispers;

public class NameList(IEnumerable<string> source)
{
    private readonly LinkedList<string> _names = new(source);

    public IReadOnlyList<string> List => _names.ToImmutableList();
}