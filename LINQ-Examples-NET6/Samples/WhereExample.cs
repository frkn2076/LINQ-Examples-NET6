namespace LINQ_Examples_NET6.Samples;
internal class WhereExample
{
    public void Sample1()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result = colors.Where(x => x.Length > 4);
        //  result = IEnumerable<string> { "Green", "Black" }
    }

    public void Sample2()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result = colors.Where((v,i) => v.Length - i > 2);
        //  result = IEnumerable<string> { "Red", "Green" }
    }
}
