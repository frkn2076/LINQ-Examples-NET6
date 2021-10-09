namespace LINQ_Examples_NET6.Samples;
public class MaxExample
{
    public int Sample1()
    {
        var numbers = new List<int>() { 1, 2, 5, 4, 3 };
        var result = numbers.Max();
        //  result = 5
        return result;
    }

    public int Sample2()
    {
        var numbers = new List<int>() { 1, 2, 5, 4, 3 };
        var result = numbers.Max(x => x + 1);
        //  result = 6
        return result;
    }

    public string Sample3()
    {
        var letters = new List<string>() { "A", "C", "d", "B", "D" };
        var result = letters.Max(x => x + 1);
        //  result = "D1"
        return result;
    }

    public string Sample4()
    {
        var letters = new List<string>() { "A", "C", "d", "B", "D" };
        var result = letters.Max(StringComparer.OrdinalIgnoreCase);
        //  result = "d"
        return result;
    }
}