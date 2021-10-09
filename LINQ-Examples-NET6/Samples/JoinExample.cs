namespace LINQ_Examples_NET6.Samples;
public class JoinExample
{
    public IEnumerable<string> Sample1()
    {
        var colors1 = new List<string>() { "Red", "Blue", "White", "Black" };
        var colors2 = new List<string>() { "White", "Gray", "black" };

        var result = colors1.Join(colors2, x => x, x => x, (res1, res2) => res1);
        //  result = IEnumerable<string> { "White" }
        return result;
    }

    public IEnumerable<string> Sample2()
    {
        var colors1 = new List<string>() { "Red", "Blue", "White", "Black" };
        var colors2 = new List<string>() { "White", "Gray", "black" };

        var result = colors1.Join(colors2, x => x, x => x, (res1, res2) => res1, StringComparer.OrdinalIgnoreCase);
        //  result = IEnumerable<string> { "White", "Black" }
        return result;
    }
}