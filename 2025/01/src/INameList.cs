namespace Whispers;

public interface INameList
{
    IReadOnlyList<string> List { get; }
    string Current { get; }
    void Right();
    void Right(int count);

    void Left();
    void Left(int count);
}