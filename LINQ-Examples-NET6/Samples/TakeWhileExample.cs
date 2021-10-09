namespace LINQ_Examples_NET6.Samples;
public class TakeWhileExample
{
    public IEnumerable<string> Sample1()
    {
        var colors = new List<string>() { "Green", "Blue", "Red", "Black", "White" };
        var result = colors.TakeWhile(x => x.Length > 3);
        //  result = IEnumerable<string>() { "Green", "Blue" }
        return result;
    }

    public IEnumerable<string> Sample2()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black", "White" };
        var result = colors.TakeWhile((v, i) => v.Length + i < 7);
        //  result = IEnumerable<string>() { "Red", "Green", "Blue" }
        return result;
    }
}