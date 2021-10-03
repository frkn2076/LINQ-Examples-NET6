namespace LINQ_Examples_NET6.Samples
{
    class SkipLastExample
    {
        public void Sample1()
        {
            var colors = new List<string>() { "Red", "Green", "Blue", "Black", "White" };
            var result = colors.SkipLast(2);
            //  result = IEnumerable<string>() { "Red", "Green", "Blue" }
        }
    }
}
