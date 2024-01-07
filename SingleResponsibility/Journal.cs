namespace SingleResponsibility;

public class Journal
{
    private readonly List<string> entries = new();

    private static int count = 0;

    public readonly string Name;

    public Journal(string name) => Name = name;

    public int AddEntry(string text)
    {
        entries.Add($"{++count}: {text}");
        return count;
    }

    public void RemoveEntry(int id) => entries.RemoveAt(id);

    public override string ToString() => string.Join(Environment.NewLine, entries);
}