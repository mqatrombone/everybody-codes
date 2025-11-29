namespace Whispers;

public record NameListCommand
{
    public required Action<INameList, int> Command { get; init; }

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