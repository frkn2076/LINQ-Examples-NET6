namespace LINQ_Examples_NET6.Samples
{
    class SelectExample
    {
        public void Sample1()
        {
            var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
            var result = colors.Select(x => x.Length);
            //  result = IEnumerable<int> { 3, 5, 4, 5 };
        }

        public void Sample2()
        {
            var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
            var result = colors.Select((v, i) => $"{v}-{i}" );
            //  result = IEnumerable<int> { "Red-0", "Green-1", "Blue-2", "Black-3" };
        }
    }
}
