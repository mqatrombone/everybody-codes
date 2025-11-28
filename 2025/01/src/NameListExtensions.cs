namespace Whispers;

public static class NameListExtensions
{
    public static void Right(this NameList list, int count)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(count, 1);

        for (int i = 0; i < count; i++)
        {
            list.Right();
        }
    }

    public static void Left(this NameList list, int count)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(count, 1);

        for (int i = 0; i < count; i++)
        {
            list.Left();
        }
    }
}