namespace LINQ_Examples_NET6.Samples;
public class IntersectByExample
{
    public IEnumerable<string> Sample1()
    {
        var colors1 = new List<string>() { "Red", "Blue", "White", "Black" };
        var colors2 = new List<string>() { "R", "b", "black", "Green" };

        var result = colors1.IntersectBy(colors2, x => x.Substring(0, 1));
        //  result = IEnumerable<string> { "Red" } 
        return result;
    }

    public IEnumerable<string> Sample2()
    {
        var colors1 = new List<string>() { "Red", "Blue", "White", "Black" };
        var colors2 = new List<string>() { "R", "b", "black", "Green" };

        var result = colors1.IntersectBy(colors2, x => x.Substring(0, 1), StringComparer.OrdinalIgnoreCase);
        //  result = IEnumerable<string> { "Red", "Blue" }
        return result;
    }
}