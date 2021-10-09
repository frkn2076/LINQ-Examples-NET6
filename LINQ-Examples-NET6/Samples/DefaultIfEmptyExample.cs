namespace LINQ_Examples_NET6.Samples;
public class DefaultIfEmptyExample
{
    public IEnumerable<int> Sample1()
    {
        var empty = new List<int>();
        var result = empty.DefaultIfEmpty();
        //  result = IEnumerable<int> { 0 }
        return result;
    }

    public IEnumerable<int> Sample2()
    {
        var empty = new List<int>();
        var result = empty.DefaultIfEmpty(5);
        //  result = IEnumerable<int> { 5 }
        return result;
    }
}