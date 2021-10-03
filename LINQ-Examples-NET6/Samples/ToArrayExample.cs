namespace LINQ_Examples_NET6.Samples
{
    class ToArrayExample
    {
        public void Sample1()
        {
            IEnumerable<string> colors = new List<string>() { "Red", "Green", "Blue", "Black" };
            var result = colors.ToArray();
            //  result = string[] { "Red", "Green", "Blue", "Black" }
        }
    }
}
