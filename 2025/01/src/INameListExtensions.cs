namespace Whispers;

public static class INameListExtensions
{
    extension(INameList list)
    {
        public void Right(int count)
        {
            list.Right(count);
        }

        public void Left(int count)
        {
            list.Left(count);
        }
    }
}