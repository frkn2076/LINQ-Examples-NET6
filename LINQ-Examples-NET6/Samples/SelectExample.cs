namespace LINQ_Examples_NET6.Samples;
public class SelectExample
{
    public IEnumerable<int> Sample1()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result = colors.Select(x => x.Length);
        //  result = IEnumerable<int> { 3, 5, 4, 5 };
        return result;
    }

    public IEnumerable<string> Sample2()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result = colors.Select((v, i) => $"{v}-{i}");
        //  result = IEnumerable<string> { "Red-0", "Green-1", "Blue-2", "Black-3" };
        return result;
    }
}