namespace LINQ_Examples_NET6.Samples;
public class MaxByExample
{
    public void Sample1()
    {
        var colors = new List<string>() { "Red", "Blue", "Purple", "Black" };
        var result = colors.MaxBy(x => x.Length);
        //  result = "Purple"
    }

    public void Sample2()
    {
        var colors = new List<string>() { "Gray", "Blue", "pink", "Purple" };
        var result = colors.MaxBy(x => x.Substring(0, 1), StringComparer.OrdinalIgnoreCase);
        //  result = "pink"
    }
}