namespace LINQ_Examples_NET6.Samples;
public class FirstOrDefaultExample
{
    public string Sample1()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result = colors.FirstOrDefault();
        //  result = "Red"
        return result;
    }

    public string Sample2()
    {
        var colors = new List<string>() { };
        var result = colors.FirstOrDefault();
        //  result = null
        return result;
    }

    public string Sample3()
    {
        var colors = new List<string>() { };
        var result = colors.FirstOrDefault("White");
        //  result = "White"
        return result;
    }

    public string Sample4()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result = colors.FirstOrDefault(x => x.Length > 3);
        //  result = "Green"
        return result;
    }

    public string Sample5()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result = colors.FirstOrDefault(x => x.Length > 5);
        //  result = null
        return result;
    }

    public string Sample6()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result = colors.FirstOrDefault(x => x.Length > 5, "White");
        //  result = "White"
        return result;
    }
}