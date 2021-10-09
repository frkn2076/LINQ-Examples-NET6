namespace LINQ_Examples_NET6.Samples;
public class ElementAtOrDefaultExample
{
    public string Sample1()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result = colors.ElementAtOrDefault(1);
        //  result = "Green"
        return result;
    }

    public string Sample2()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result = colors.ElementAtOrDefault(7);
        //  result = null
        return result;
    }

    public string Sample3()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result = colors.ElementAtOrDefault(new Index(2, true));
        //  result = "Blue"
        return result;
    }

    public string Sample4()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result = colors.ElementAtOrDefault(new Index(5, true));
        //  result = null
        return result;
    }
}