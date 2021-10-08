using LINQ_Examples_NET6.Custome;

namespace LINQ_Examples_NET6.Samples;
internal class TryGetNonEnumeratedCountExample
{
    public void Sample1()
    {
        var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
        var result = colors.TryGetNonEnumeratedCount(out int count1);
        //  result = true (no iteration needed to find count)
        //  count1 = 4    (no iteration needed so returned count)

        var customeItems = new CustomeItems();
        var result2 = customeItems.TryGetNonEnumeratedCount(out int count2);
        //  result2 = false (iteration needed to find count)
        //  count2  = 0     (iteration need so didn't return the count)
    }
}
