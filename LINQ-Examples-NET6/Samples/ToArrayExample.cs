namespace LINQ_Examples_NET6.Samples;
public class ToArrayExample
{
    public string[] Sample1()
    {
        IEnumerable<string> colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result = colors.ToArray();
        //  result = string[] { "Red", "Green", "Blue", "Black" }
        return result;
    }
}