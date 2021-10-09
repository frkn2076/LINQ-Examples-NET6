namespace LINQ_Examples_NET6.Samples;
public class WhereExample
{
    public IEnumerable<string> Sample1()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result = colors.Where(x => x.Length > 4);
        //  result = IEnumerable<string> { "Green", "Black" }
        return result;
    }

    public IEnumerable<string> Sample2()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result = colors.Where((v,i) => v.Length - i > 2);
        //  result = IEnumerable<string> { "Red", "Green" }
        return result;
    }
}
