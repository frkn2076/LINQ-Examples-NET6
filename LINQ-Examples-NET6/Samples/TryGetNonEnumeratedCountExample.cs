using LINQ_Examples_NET6.Custome;

namespace LINQ_Examples_NET6.Samples;
public class TryGetNonEnumeratedCountExample
{
    public (bool, int) Sample1()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result = colors.TryGetNonEnumeratedCount(out int count);
        //  result = true (no iteration needed to find count)
        //  count = 4    (no iteration needed so returned count)
        return (result, count);
    }

    public (bool, int) Sample2()
    {
        var customeItems = new CustomeItems();
        var result = customeItems.TryGetNonEnumeratedCount(out int count);
        //  result = false (iteration needed to find count)
        //  count  = 0     (iteration need so didn't return the count)
        return (result, count);
    }
}
