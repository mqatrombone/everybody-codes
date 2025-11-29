namespace Whispers;

public static class INameListExtensions
{
    extension(INameList list)
    {
        public void Right(int count)
        {
            ArgumentOutOfRangeException.ThrowIfLessThan(count, 1);

            for (int i = 0; i < count; i++)
            {
                list.Right();
            }
        }

        public void Left(int count)
        {
            ArgumentOutOfRangeException.ThrowIfLessThan(count, 1);

            for (int i = 0; i < count; i++)
            {
                list.Left();
            }
        }
    }
}