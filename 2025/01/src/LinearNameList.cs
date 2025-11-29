using System.Collections.Immutable;

namespace Whispers;

public class LinearNameList : INameList
{
    private readonly LinkedList<string> _names;

    private LinkedListNode<string> _current;

    public IReadOnlyList<string> List => _names.ToImmutableList();

    public string Current => _current.Value;

    public LinearNameList(IEnumerable<string> source)
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
    public void Right(int count)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(count, 1);

        for (int i = 0; i < count; i++)
        {
            Right();
        }
    }

    public void Left()
    {
        if (_current.Previous is null)
            return;

        _current = _current.Previous;
    }

    public void Left(int count)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(count, 1);

        for (int i = 0; i < count; i++)
        {
            Left();
        }
    }
}