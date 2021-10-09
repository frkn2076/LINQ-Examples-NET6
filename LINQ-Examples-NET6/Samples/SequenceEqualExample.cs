namespace LINQ_Examples_NET6.Samples;
public class SequenceEqualExample
{
    public bool Sample1()
    {
        var colors1 = new List<string>() { "Red", "Green", "Blue", "Black" };
        var colors2 = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result = Enumerable.SequenceEqual(colors1, colors2);
        //  result = true
        return result;
    }

    public bool Sample2()
    {
        var colors1 = new List<string>() { "Red", "Green", "Blue", "Black" };
        var colors2 = new List<string>() { "Black", "Red", "Green", "Blue", };
        var result = Enumerable.SequenceEqual(colors1, colors2);
        //  result = false
        return false;
    }

    public bool Sample3()
    {
        var colors1 = new List<string>() { "Red", "Green", "Blue", "Black" };
        var colors2 = new List<string>() { "red", "GrEen", "Blue", "Black" };
        var result = Enumerable.SequenceEqual(colors1, colors2, StringComparer.OrdinalIgnoreCase);
        //  result = true
        return result;
    }
}