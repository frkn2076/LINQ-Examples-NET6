namespace LINQ_Examples_NET6.Samples;
public class LongCountExample
{
    public long Sample1()
    {
        var colors = new List<string>() { "Red", "Blue", "Purple", "Black" };
        var result = colors.LongCount();
        //  result = 4
        return result;
    }

    public long Sample2()
    {
        var colors = new List<string>() { "Red", "Blue", "Purple", "Black" };
        var result = colors.LongCount(x => x.Length > 3);
        //  result = 3
        return result;
    }
}