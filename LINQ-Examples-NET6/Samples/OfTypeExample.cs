namespace LINQ_Examples_NET6.Samples;
public class OfTypeExample
{
    public IEnumerable<string> Sample1()
    {
        var items = new ArrayList() { "White", 1, 2.0, "George" };
        var result = items.OfType<string>();
        //  IEnumerable<string> { "White", "George" }
        return result;
    }
}