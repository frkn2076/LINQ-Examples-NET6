namespace LINQ_Examples_NET6.Samples;
public class DistinctExample
{
    public IEnumerable<int> Sample1()
    {
        var numbers = new List<int>() { 1, 2, 2, 4, 1, 5 };
        var result = numbers.Distinct();
        //  result = IEnumerable<int> { 1, 2, 4, 5 }
        return result;
    }

    public IEnumerable<string> Sample2()
    {
        var colors = new List<string>() { "Red", "RED", "Blue", "Black", "BluE" };
        var result = colors.Distinct(StringComparer.OrdinalIgnoreCase);
        //  result = IEnumerable<string> { "Red", "Blue", "Black" }
        return result;
    }
}