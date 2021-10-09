namespace LINQ_Examples_NET6.Samples;
internal class UnionExample
{
    public void Sample1()
    {
        var colors1 = new List<string>() { "Red", "Green", "Blue", "Black" };
        var colors2 = new List<string>() { "Purple", "White", "blue", "Red" };
        var result = colors1.Union(colors2);
        //  result = IEnumerable<string>() { "Red", "Green", "Blue", "Black", "Purple", "White", "blue" }
    }

    public void Sample2()
    {
        var colors1 = new List<string>() { "Red", "Green", "Blue", "Black" };
        var colors2 = new List<string>() { "Purple", "White", "blue", "Red" };
        var result = colors1.Union(colors2, StringComparer.OrdinalIgnoreCase);
        //  result = IEnumerable<string>() { "Red", "Green", "Blue", "Black", "Purple", "White" }
    }
}

