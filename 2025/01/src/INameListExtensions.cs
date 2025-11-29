namespace Whispers;

public static class INameListExtensions
{
    extension(INameList list)
    {
        public void Right(int count)
        {
            list.CommandR(count);
        }

        public void Left(int count)
        {
            list.CommandL(count);
        }
    }
}