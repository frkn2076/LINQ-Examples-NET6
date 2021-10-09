namespace LINQ_Examples_NET6.Samples;
public class ElementAtExample
{
    public string Sample1()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result = colors.ElementAt(1);
        //  result = "Green"
        return result;
    }

    public string Sample2()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result = colors.ElementAt(new Index(2, true));
        //  result = "Blue"
        return result;
    }
}