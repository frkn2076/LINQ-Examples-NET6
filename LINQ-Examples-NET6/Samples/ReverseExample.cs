namespace LINQ_Examples_NET6.Samples;
public class ReverseExample
{
    public IEnumerable<string> Sample1()
    {
        IEnumerable<string> colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        colors = colors.Reverse();
        // colors = IEnumerable<string> { "Black", "Blue", "Green", "Red" }
        return colors;
    }
}