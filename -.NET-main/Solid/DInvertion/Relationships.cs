public enum Relationship{
    Parent,
    Child,
    Sibling
}

public class Person
{
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
}

public interface IRelationshipBrowser
{
    IEnumerable<Person> FindAllChildrenOf(string name);
}
public class Relationships : IRelationshipBrowser
{
    private List<(Person, Relationship, Person)> relations = new List<(Person, Relationship, Person)>();
    public void AddParentAndChild(Person parent, Person child)  
    {
        relations.Add((parent, Relationship.Parent, child));
        relations.Add((child, Relationship.Child, parent));
    }

    public IEnumerable<Person> FindAllChildrenOf(string name)
    {
        return relations.Where(x => x.Item1.Name == name && x.Item2 == Relationship.Parent).Select(x => x.Item3);
    }
}

public class Research
{
    public Research(IRelationshipBrowser browser)
    {
        foreach (var p in browser.FindAllChildrenOf("John"))
        {
            Console.WriteLine($"John has a child called {p.Name}");
        }
    }
}