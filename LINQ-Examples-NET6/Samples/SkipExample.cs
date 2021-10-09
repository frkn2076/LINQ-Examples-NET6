namespace LINQ_Examples_NET6.Samples;
public class SkipExample
{
    public IEnumerable<string> Sample1()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black", "White" };
        var result = colors.Skip(2);
        //  result = IEnumerable<string>() { "Blue", "Black", "White" }
        return result;
    }
}