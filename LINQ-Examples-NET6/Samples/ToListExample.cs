namespace LINQ_Examples_NET6.Samples
{
    internal class ToListExample
    {
        public void Sample1()
        {
            IEnumerable<string> colors = new List<string>() { "Red", "Green", "Blue", "Black" };
            var result = colors.ToList();
            //  result = List<string> { "Red", "Green", "Blue", "Black" }
        }
    }
}
