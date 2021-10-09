namespace LINQ_Examples_NET6.Samples;
public class ToDictionaryExample
{
    public Dictionary<string, string> Sample1()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black", "red" };
        var result = colors.ToDictionary(x => x.Substring(0, 3));
        //  result = Dictionary<string, string> { { Key: "Red", Value: "Red" }, { Key: "Gre", Value: "Green" }, { Key: "Blu", Value: "Blue" }, { Key: "Bla", Value: "Black" }, { Key: "red", Value: "red" } }
        return result;
    }

    public void Sample2()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black", "red" };
        var result = colors.ToDictionary(x => x.Substring(0, 3), StringComparer.OrdinalIgnoreCase);
        // throws ArgumentException: "An item with the same key has already been added. Key: red"
    }

    public Dictionary<string, int> Sample3()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black", "red" };
        var result = colors.ToDictionary(x => x, x => x.Length);
        //  result = Dictionary<string, int> { { Key: "Red", Value: 3 }, { Key: "Green", Value: 5 }, { Key: "Blue", Value: 4 }, { Key: "Black", Value: 5 }, { Key: "red", Value: 3 } }
        return result;
    }

    public void Sample4()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black", "red" };
        var result = colors.ToDictionary(x => x, x => x.Length, StringComparer.OrdinalIgnoreCase);
        // throws ArgumentException: "An item with the same key has already been added. Key: red"
    }
}
