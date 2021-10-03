namespace LINQ_Examples_NET6.Samples;
class ExceptExample
{
    public void Sample1()
    {
        var first = new List<string>() { "Red", "Green", "Blue", "Black" };
        var second = new List<string>() { "Black", "Blue", "White", "Yellow" };
        var result = first.Except(second);
        //  result = IEnumerable<string> { "Red", "Green" }
    }

    public void Sample2()
    {
        var first = new List<string>() { "Red", "Green", "Blue", "Black" };
        var second = new List<string>() { "BLACK", "BLue", "White", "Yellow" };
        var result = first.Except(second, StringComparer.OrdinalIgnoreCase);
        //  result = IEnumerable<string> { "Red", "Green" }
    }
}