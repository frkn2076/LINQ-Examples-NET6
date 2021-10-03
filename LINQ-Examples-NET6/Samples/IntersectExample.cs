namespace LINQ_Examples_NET6.Samples;
public class IntersectExample
{
    public void Sample1()
    {
        var colors1 = new List<string>() { "Red", "Green", "Blue", "Black" };
        var colors2 = new List<string>() { "Red", "Purple", "black", "Green" };

        var result = colors1.Intersect(colors2);
        //  result = IEnumerable<string> { "Red", "Green" } 
    }

    public void Sample2()
    {
        var colors1 = new List<string>() { "Red", "Green", "Blue", "Black" };
        var colors2 = new List<string>() { "Red", "Purple", "black", "Green" };

        var result = colors1.Intersect(colors2, StringComparer.OrdinalIgnoreCase);
        //  result = IEnumerable<string> { "Red", "Green", "Black" } 
    }
}