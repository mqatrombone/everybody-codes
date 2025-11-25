namespace Whispers;

public static class FileStreamExtensions
{
    public static LinkedList<string> ParseNames(this string[] inputLines)
    {
        var names = inputLines[0].Split(',');
        return new LinkedList<string>(names);
    }
}