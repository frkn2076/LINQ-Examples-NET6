using LINQ_Examples_NET6.Comparer;
using LINQ_Examples_NET6.Models;

namespace LINQ_Examples_NET6.Samples;
public class ThenByDescendingExample
{
    public IOrderedEnumerable<Person> Sample1()
    {
        var actors = new List<Person>() { new("Leonardo", "Dicaprio"), new("Tom", "Hanks"), new("Tom", "Sawyer"), new("Tom", "Hiddlestone") };
        var result = actors.OrderBy(x => x.Name).ThenByDescending(x => x.Surname);
        //  result = IOrderedEnumerable<Person>  { new("Leonardo", "Dicaprio"), new("Tom", "Sawyer"), new("Tom", "Hiddlestone"), new("Tom", "Hanks") }
        return result;
    }

    public IOrderedEnumerable<Person> Sample2()
    {
        var actors = new List<Person>() { new("Leonardo", "Dicaprio"), new("Tom", "Hanks"), new("Tom", "Sawyer"), new("Tom", "Hiddlestone") };
        var result = actors.OrderBy(x => x.Name).ThenByDescending(x => x.Surname, new LengthComparer());
        //  result = IOrderedEnumerable<Person>  { new("Leonardo", "Dicaprio"), new("Tom", "Hiddlestone"), new("Tom", "Sawyer"), new("Tom", "Hanks") }
        return result;
    }
}