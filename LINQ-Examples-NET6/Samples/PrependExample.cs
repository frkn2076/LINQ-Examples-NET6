namespace LINQ_Examples_NET6.Samples;
public class PrependExample
{
    public IEnumerable<string> Sample1()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result = colors.Prepend("White");
        //  result = IEnumerable<string> { "White", "Red", "Green", "Blue", "Black" }
        return result;
    }
}