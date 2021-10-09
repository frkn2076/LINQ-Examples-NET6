namespace LINQ_Examples_NET6.Samples;
public class TakeExample
{
    public IEnumerable<string> Sample1()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black", "White" };
        var result = colors.Take(2);
        //  result = IEnumerable<string>() { "Red", "Green" }
        return result;
    }

    public IEnumerable<string> Sample2()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black", "White" };
        var result = colors.Take(new Range(1, 4));
        //  result = IEnumerable<string>() { "Green", "Blue", "Black" }
        return result;
    }
}