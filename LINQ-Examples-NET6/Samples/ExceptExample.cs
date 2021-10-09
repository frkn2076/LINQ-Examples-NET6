namespace LINQ_Examples_NET6.Samples;
public class ExceptExample
{
    public IEnumerable<string> Sample1()
    {
        var first = new List<string>() { "Red", "Green", "Blue", "Black" };
        var second = new List<string>() { "Black", "Blue", "White", "Yellow" };
        var result = first.Except(second);
        //  result = IEnumerable<string> { "Red", "Green" }
        return result;
    }

    public IEnumerable<string> Sample2()
    {
        var first = new List<string>() { "Red", "Green", "Blue", "Black" };
        var second = new List<string>() { "BLACK", "BLue", "White", "Yellow" };
        var result = first.Except(second, StringComparer.OrdinalIgnoreCase);
        //  result = IEnumerable<string> { "Red", "Green" }
        return result;
    }
}