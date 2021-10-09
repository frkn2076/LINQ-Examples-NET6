namespace LINQ_Examples_NET6.Samples;
public class CountExample
{
    public int Sample1()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result = colors.Count();
        //  result = 4
        return result;
    }

    public int Sample2()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result = colors.Count(item => item.Length == 5);
        //  result = 2
        return result;
    }
}