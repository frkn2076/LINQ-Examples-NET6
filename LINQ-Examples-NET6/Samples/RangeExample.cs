namespace LINQ_Examples_NET6.Samples;
public class RangeExample
{
    public IEnumerable<int> Sample1()
    {
        var result = Enumerable.Range(2, 5);
        //  result = IEnumerable<int> { 2, 3, 4, 5, 6}
        return result;
    }
}