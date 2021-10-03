namespace LINQ_Examples_NET6.Samples;
class CountExample
{
    public void Sample1()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result = colors.Count();
        //  result = 4
    }

    public void Sample2()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result = colors.Count(item => item.Length == 5);
        //  result = 2
    }
}