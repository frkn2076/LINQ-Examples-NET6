using LINQ_Examples_NET6.Models;

namespace LINQ_Examples_NET6.Samples;
public class DistinctByExample
{
    public IEnumerable<Person> Sample1()
    {
        var actors = new List<Person>() { new("Leonardo", "Dicaprio"), new("Tom", "Hanks"), new("Tom", "Sawyer"), new("Tom", "Hiddlestone") };
        var result = actors.DistinctBy(x => x.Name);
        //  result = List<User>() { new("Leonardo", "Dicaprio"), new("Tom", "Hanks") }
        return result;
    }

    public IEnumerable<Person> Sample2()
    {
        var colors = new List<Person>() { new("Leonardo", "Dicaprio"), new("Tom", "Hanks"), new("TOM", "Sawyer"), new("tom", "Hiddlestone") };
        var result = colors.DistinctBy(x => x.Name, StringComparer.OrdinalIgnoreCase);
        //  result = IEnumerable<User>() { new("Leonardo", "Dicaprio"), new("Tom", "Hanks") }
        return result;
    }
}