public class Journal
{
    private readonly List<string> entries = new List<string>();
    public void AddEntry(string text)
    {
        entries.Add(text);
    }

    public void RemoveEntry(int index)
    {
        if (index < 0 || index >= entries.Count)
            throw new IndexOutOfRangeException($"Index {index} is out of range");
        entries.RemoveAt(index);
    }

    public override string ToString()
    {
        return string.Join(Environment.NewLine, entries);
    }


}