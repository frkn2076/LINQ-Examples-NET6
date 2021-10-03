namespace LINQ_Examples_NET6.Samples
{
    class SkipExample
    {
        public void Sample1()
        {
            var colors = new List<string>() { "Red", "Green", "Blue", "Black", "White" };
            var result = colors.Skip(2);
            //  result = IEnumerable<string>() { "Blue", "Black", "White" }
        }
    }
}
