using LINQ_Examples_NET6.Models;

namespace LINQ_Examples_NET6.Samples;
public class ExceptByExample
{
    public IEnumerable<Person> Sample1()
    {
        var first = new List<Person>() { new("Leonardo", "Dicaprio"), new("Tom", "Hanks"), new("TOM", "Sawyer"), new("Tom", "Hiddlestone") };
        var second = new List<string>() { "Tom", "Hugh" };
        var result = first.ExceptBy(second, x => x.Name);
        //  result = IEnumerable<Person>() { new("Leonardo", "Dicaprio"), new("TOM", "Sawyer") }
        return result;
    }

    public IEnumerable<Person> Sample2()
    {
        var first = new List<Person>() { new("Leonardo", "Dicaprio"), new("Tom", "Hanks"), new("TOM", "Sawyer"), new("Tom", "Hiddlestone") };
        var second = new List<string>() { "ToM", "HUGh" };
        var result = first.ExceptBy(second, x => x.Name, StringComparer.OrdinalIgnoreCase);
        //  result = IEnumerable<Person>() { new("Leonardo", "Dicaprio") }
        return result;
    }
}