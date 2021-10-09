namespace LINQ_Examples_NET6.Samples;
public class EmptyExample
{
    public IEnumerable<int> Sample1()
    {
        var result = Enumerable.Empty<int>();
        //  result = IEnumerable<int> { }
        return result;
    }
}