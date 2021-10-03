namespace LINQ_Examples_NET6.Samples;
class FirstExample
{
    public void Sample1()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result = colors.First();
        //  result = "Red"
    }

    public void Sample2()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result1 = colors.First(x => x.Length > 4);
        //  result1 = "Green"
        try
        {
            var result2 = colors.First(x => x.Length > 7);
        }
        catch (Exception)
        {
            // throws exception "Sequence contains no matching element"
        }
    }
}