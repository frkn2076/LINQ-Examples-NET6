namespace LINQ_Examples_NET6.Samples;
public class ToListExample
{
    public IEnumerable<string> Sample1()
    {
        IEnumerable<string> colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result = colors.ToList();
        //  result = List<string> { "Red", "Green", "Blue", "Black" }
        return result;
    }
}