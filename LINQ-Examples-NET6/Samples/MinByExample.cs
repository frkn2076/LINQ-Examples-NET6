namespace LINQ_Examples_NET6.Samples;
public class MinByExample
{
    public string Sample1()
    {
        var colors = new List<string>() { "Red", "Blue", "Purple", "Black" };
        var result = colors.MinBy(x => x.Length);
        //  result = "Red"
        return result;
    }

    public string Sample2()
    {
        var colors = new List<string>() { "Gray", "Blue", "lack", "Purple" };
        var result = colors.MinBy(x => x.Substring(0, 1), StringComparer.OrdinalIgnoreCase);
        //  result = "Blue"
        return result;
    }
}