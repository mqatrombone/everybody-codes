using System.Collections.Immutable;
using System.Security.AccessControl;

namespace Whispers;

public class NameList
{
    private readonly LinkedList<string> _names;

    private LinkedListNode<string> _current;

    public IReadOnlyList<string> List => _names.ToImmutableList();
    
    public string Current => _current.Value;
    
    public NameList(IEnumerable<string> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        _names = new LinkedList<string>(source);
        _current = _names.First ?? new LinkedListNode<string>(string.Empty);
    }

    public void Right()
    {
        if (_current.Next is null)
            return;

        _current = _current.Next;
    }

    public void Left()
    {
        if (_current.Previous is null)
            return;

        _current = _current.Previous;
    }
}