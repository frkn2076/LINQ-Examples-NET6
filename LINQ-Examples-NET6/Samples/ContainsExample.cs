namespace LINQ_Examples_NET6.Samples;
public class ContainsExample
{
    public bool Sample1()
    {
        var numbers = new List<int>() { 1, 2, 3, 4, 5 };
        var result = numbers.Contains<int>(1);
        //  result = 1 == 3 || 2 == 3 || 3 == 3 || 4 == 3 || 5 == 3
        return result;
    }

    public bool Sample2()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result = colors.Contains("RED", StringComparer.OrdinalIgnoreCase);
        //  result = true
        return result;
    }
}