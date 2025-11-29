namespace Whispers;

public record NameListCommand
{
    public required Action<NameList, int> Command { get; init; }

    public required int Count
    {
        get;
        init
        {
            ArgumentOutOfRangeException.ThrowIfNegativeOrZero(value);
            field = value;
        }
    }
}