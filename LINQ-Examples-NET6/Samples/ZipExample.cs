namespace LINQ_Examples_NET6.Samples;
internal class ZipExample
{
    public void Sample1()
    {
        var colors1 = new List<string>() { "Red", "Green", "Blue", "Black" };
        var colors2 = new List<string>() { "Purple", "White", "Blue", "Red" };
        var result = colors1.Zip(colors2);
        //  result = IEnumerable<(string,string)>() { ("Red", "Purple"), ("Green", "White"),  ("Blue", "Blue"), ("Black", "Red") }
    }

    public void Sample2()
    {
        var colors1 = new List<string>() { "Red", "Green", "Blue", "Black" };
        var colors2 = new List<string>() { "Purple", "White", "Blue", "Red" };
        var colors3 = new List<string>() { "Yellow", "Brown", "White", "Gray" };
        var result = colors1.Zip(colors2, colors3);
        //  result = IEnumerable<(string,string)>() { ("Red", "Purple", "Yellow"), ("Green", "White", "Brown"),  ("Blue", "Blue", "White"), ("Black", "Red", "Gray") }
    }

    public void Sample3()
    {
        var colors1 = new List<string>() { "Red", "Green", "Blue", "Black" };
        var colors2 = new List<string>() { "Purple", "White", "Blue", "Red" };
        var result = colors1.Zip(colors2, (res1, res2) => $"{res1}:{res2}");
        //  result = IEnumerable<string>() { "Red:Purple", "Green:White", "Blue:Blue", "Black:Red" }
    }
}
