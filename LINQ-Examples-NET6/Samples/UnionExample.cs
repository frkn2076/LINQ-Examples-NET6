namespace LINQ_Examples_NET6.Samples;
public class UnionExample
{
    public IEnumerable<string> Sample1()
    {
        var colors1 = new List<string>() { "Red", "Green", "Blue", "Black" };
        var colors2 = new List<string>() { "Purple", "White", "blue", "Red" };
        var result = colors1.Union(colors2);
        //  result = IEnumerable<string>() { "Red", "Green", "Blue", "Black", "Purple", "White", "blue" }
        return result;
    }

    public IEnumerable<string> Sample2()
    {
        var colors1 = new List<string>() { "Red", "Green", "Blue", "Black" };
        var colors2 = new List<string>() { "Purple", "White", "blue", "Red" };
        var result = colors1.Union(colors2, StringComparer.OrdinalIgnoreCase);
        //  result = IEnumerable<string>() { "Red", "Green", "Blue", "Black", "Purple", "White" }
        return result;
    }
}