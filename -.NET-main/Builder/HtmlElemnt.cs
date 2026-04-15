public class HtmlElement
{
    public string Name { get; set; }
    public string Text { get; set; }
    public List<HtmlElement> Elements = new List<HtmlElement>();

    public HtmlElement()
    {

    }

    public HtmlElement(string name, string text)
    {
        Name = name;
        Text = text;
    }

    public string ToString()
    {
        return base.ToString();
    }
}