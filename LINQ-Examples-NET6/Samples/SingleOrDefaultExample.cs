namespace LINQ_Examples_NET6.Samples;
public class SingleOrDefaultExample
{
    public void Sample1()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result = colors.SingleOrDefault();
        // throws InvalidOperationException: "Sequence contains more than one element"
    }

    public string Sample2()
    {
        var colors = new List<string>();
        var result = colors.SingleOrDefault();
        //  result = null
        return result;
    }

    public string Sample3()
    {
        var colors = new List<string>() { "Blue" };
        var result = colors.SingleOrDefault();
        //  result = "Blue"
        return result;
    }

    public void Sample4()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result = colors.SingleOrDefault(x => x.Length > 3);
        // throws InvalidOperationException: "Sequence contains more than one element"
    }

    public string Sample5()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result = colors.SingleOrDefault(x => x.Length > 7);
        //  result = null 
        return result;
    }

    public string Sample6()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result = colors.SingleOrDefault(x => x.Length == 3);
        //  result = "Red"
        return result;
    }
}