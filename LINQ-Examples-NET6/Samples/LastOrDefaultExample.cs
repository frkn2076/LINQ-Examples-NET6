namespace LINQ_Examples_NET6.Samples;
public class LastOrDefaultExample
{
    public string Sample1()
    {
        var colors = new List<string>() { "Red", "Blue", "Purple", "Black" };
        var result = colors.LastOrDefault();
        //  result = "Black"
        return result;
    }

    public string Sample2()
    {
        var colors = new List<string>();
        var result = colors.LastOrDefault();
        //  result = null
        return result;
    }

    public string Sample3()
    {
        var colors = new List<string>() { "Red", "Blue", "Purple", "Black" };
        var result = colors.LastOrDefault("White");
        //  result = "Black"
        return result;
    }

    public string Sample4()
    {
        var colors = new List<string>();
        var result = colors.LastOrDefault("White");
        //  result = "White"
        return result;
    }

    public string Sample5()
    {
        var colors = new List<string>() { "Red", "Blue", "Purple", "Black" };
        var result = colors.LastOrDefault(x => x.Length < 5);
        //  result = "Blue"
        return result;
    }

    public string Sample6()
    {
        var colors = new List<string>();
        var result = colors.LastOrDefault(x => x.Length < 5);
        //  result = null
        return result;
    }

    public string Sample7()
    {
        var colors = new List<string>() { "Red", "Blue", "Purple", "Black" };
        var result = colors.LastOrDefault(x => x.Length < 5, "White");
        //  result = "Blue"
        return result;
    }

    public string Sample8()
    {
        var colors = new List<string>() { "Purple" };
        var result = colors.LastOrDefault(x => x.Length < 5, "White");
        //  result = "White"
        return result;
    }
}