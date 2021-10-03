namespace LINQ_Examples_NET6.Samples
{
    class PrependExample
    {
        public void Sample1()
        {
            var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
            var result = colors.Prepend("White");
            //  result = List<string> { "White", "Red", "Green", "Blue", "Black" }
        }
    }
}
