namespace LINQ_Examples_NET6.Samples
{
    class ContainsExample
    {
        public void Sample1()
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5 };
            var result = numbers.Contains<int>(1);
            //  result = 1 == 3 || 2 == 3 || 3 == 3 || 4 == 3 || 5 == 3
        }

        public void Sample2()
        {
            var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
            var result = colors.Contains("RED", StringComparer.OrdinalIgnoreCase);
            //  result = true
        }
    }
}
