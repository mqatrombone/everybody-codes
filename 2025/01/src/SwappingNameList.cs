using System.Collections.Immutable;

namespace Whispers;

public class SwappingNameList : INameList
{
    private readonly LinkedList<string> _names;

    public IReadOnlyList<string> List => _names.ToImmutableList();

    public SwappingNameList(IEnumerable<string> source)
    {
        ArgumentNullException.ThrowIfNull(source);
        _names = new LinkedList<string>(source);
    }

    public void Right(int count)
    {
        if (_names.First is null)
        {
            return;
        }

        LinkedListNode<string> current = _names.First;

        for (int i = 0; i < count; i++)
        {
            current = current.Next ?? _names.First;
        }

        (_names.First.Value, current.Value) = (current.Value, _names.First.Value);
    }

    public void Left(int count)
    {
        if (_names.First is null)
        {
            return;
        }

        if (_names.Last is null)
        {
            return;
        }

        LinkedListNode<string> current = _names.First;

        for (int i = 0; i < count; i++)
        {
            current = current.Previous ?? _names.Last;
        }

        (_names.First.Value, current.Value) = (current.Value, _names.First.Value);
    }
}