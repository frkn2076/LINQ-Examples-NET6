namespace LINQ_Examples_NET6.Samples
{
    class LastExample
    {
        public void Sample1()
        {
            var colors = new List<string>() { "Red", "Blue", "White", "Black" };
            var result = colors.Last();
            //  result = "Black"
        }

        public void Sample2()
        {
            var colors = new List<string>() { "Red", "Blue", "White", "Black" };
            var result = colors.Last(x => x.Length < 5);
            //  result = "Blue"
        }
    }
}
