namespace LINQ_Examples_NET6.Samples;
public class TakeLastExample
{
    public IEnumerable<string> Sample1()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black", "White" };
        var result = colors.TakeLast(2);
        //  result = IEnumerable<string>() { "Black", "White" }
        return result;
    }
}