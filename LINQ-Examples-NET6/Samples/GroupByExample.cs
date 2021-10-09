namespace LINQ_Examples_NET6.Samples;
public class GroupByExample
{
    public IEnumerable<IGrouping<int, string>> Sample1()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result = colors.GroupBy(x => x.Length).ToList();
        //  result = IEnumerable<IGrouping<int, string>> { { Key: 3, ["Red"] }, { Key: 5, ["Green", "Black"] }, { Key: 4, ["Blue"] } }
        return result;
    }

    public IEnumerable<IGrouping<int, string>> Sample2()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result = colors.GroupBy(x => x.Length, x => x.Substring(0, 1)).ToList();
        //  result = IEnumerable<IGrouping<int, string>> { { Key: 3, ["R"] }, { Key: 5, ["G", "B"] }, { Key: 4, ["B"] } }
        return result;
    }

    public IEnumerable<IGrouping<string, string>> Sample3()
    {
        var colors = new List<string>() { "Red", "Green", "blue", "Black" };
        var result = colors.GroupBy(x => x.Substring(0, 1), StringComparer.OrdinalIgnoreCase).ToList();
        //  result = IEnumerable<IGrouping<string, string>> { { Key: "R", ["Red"] }, { Key: "G", ["Green"] }, { Key: "b", ["blue", "Black"] } }
        return result;
    }

    public IEnumerable<IGrouping<string, string>> Sample4()
    {
        var colors = new List<string>() { "Red", "Green", "blue", "Black" };
        var result = colors.GroupBy(x => x.Substring(0, 1), x => x.Substring(0, 1), StringComparer.OrdinalIgnoreCase).ToList();
        //  result = IEnumerable<IGrouping<string, char>> { { Key: "R", ["R"] }, { Key: "G", ["G"] }, { Key: "b", ["b", "B"] } }
        return result;
    }
}