namespace LINQ_Examples_NET6.Samples
{
    internal class ToHashSetExample
    {
        public void Sample1()
        {
            var colors = new List<string>() { "Red", "Green", "Blue", "Black", "red" };
            var result = colors.ToHashSet();
            //  result = HashSet<string> { "Red", "Green", "Blue", "Black", "red" }
        }

        public void Sample2()
        {
            var colors = new List<string>() { "Red", "Green", "Blue", "Black", "red" };
            var result = colors.ToHashSet(StringComparer.OrdinalIgnoreCase);
            //  result = HashSet<string> { "Red", "Green", "Blue", "Black" }
        }
    }
}
