namespace LINQ_Examples_NET6.Samples;
public class SkipWhileExample
{
    public IEnumerable<string> Sample1()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black", "White" };
        var result = colors.SkipWhile(x => x.Length < 5);
        //  result = IEnumerable<string>() { "Green", "Blue", "Black", "White" }
        return result;
    }

    public IEnumerable<string> Sample2()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black", "White" };
        var result = colors.SkipWhile((v, i) => v.Length - i > 2);
        //  result = IEnumerable<string>() { "Blue", "Black", "White" }
        return result;
    }
}