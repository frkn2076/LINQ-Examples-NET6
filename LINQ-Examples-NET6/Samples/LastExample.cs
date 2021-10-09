namespace LINQ_Examples_NET6.Samples;
public class LastExample
{
    public string Sample1()
    {
        var colors = new List<string>() { "Red", "Blue", "White", "Black" };
        var result = colors.Last();
        //  result = "Black"
        return result;
    }

    public string Sample2()
    {
        var colors = new List<string>() { "Red", "Blue", "White", "Black" };
        var result = colors.Last(x => x.Length < 5);
        //  result = "Blue"
        return result;
    }
}