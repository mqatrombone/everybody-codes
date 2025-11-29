using System.Collections.Immutable;

namespace Whispers;

public class SwappingNameList
{
    private readonly LinkedList<string> _names;

    public IReadOnlyList<string> List => _names.ToImmutableList();

    public SwappingNameList(IEnumerable<string> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        _names = new LinkedList<string>(source);
    }
}