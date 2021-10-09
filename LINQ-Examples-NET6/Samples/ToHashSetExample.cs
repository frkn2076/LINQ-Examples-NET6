namespace LINQ_Examples_NET6.Samples;
public class ToHashSetExample
{
    public HashSet<string> Sample1()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black", "red" };
        var result = colors.ToHashSet();
        //  result = HashSet<string> { "Red", "Green", "Blue", "Black", "red" }
        return result;
    }

    public HashSet<string> Sample2()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black", "red" };
        var result = colors.ToHashSet(StringComparer.OrdinalIgnoreCase);
        //  result = HashSet<string> { "Red", "Green", "Blue", "Black" }
        return result;
    }
}
