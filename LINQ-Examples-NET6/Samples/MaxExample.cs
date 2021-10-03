namespace LINQ_Examples_NET6.Samples;
public class MaxExample
{
    public void Sample1()
    {
        var numbers = new List<int>() { 1, 2, 5, 4, 3 };
        var result = numbers.Max();
        //  result = 5
    }

    public void Sample2()
    {
        var numbers = new List<int>() { 1, 2, 5, 4, 3 };
        var result = numbers.Max(x => x + 1);
        //  result = 6
    }

    public void Sample3()
    {
        var letters = new List<string>() { "A", "C", "d", "B", "D" };
        var result = letters.Max(x => x + 1);
        //  result = "D1"
    }

    public void Sample4()
    {
        var letters = new List<string>() { "A", "C", "d", "B", "D" };
        var result = letters.Max(StringComparer.OrdinalIgnoreCase);
        //  result = "d"
    }
}