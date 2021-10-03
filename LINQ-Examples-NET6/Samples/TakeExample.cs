namespace LINQ_Examples_NET6.Samples;
class TakeExample
{
    public void Sample1()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black", "White" };
        var result = colors.Take(2);
        //  result = IEnumerable<string>() { "Red", "Green" }
    }

    public void Sample2()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black", "White" };
        var result = colors.Take(new Range(1, 4));
        //  result = IEnumerable<string>() { "Green", "Blue", "Black" }
    }
}