namespace LINQ_Examples_NET6.Samples;
public class FirstExample
{
    public string Sample1()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result = colors.First();
        //  result = "Red"
        return result;
    }

    public string Sample2()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result = colors.First(x => x.Length > 4);
        //  result = "Green"
        return result;
    }

    public void Sample3()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result = colors.First(x => x.Length > 7);
        // throws InvalidOperationException: "Sequence contains no matching element"
    }
}