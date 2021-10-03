namespace LINQ_Examples_NET6.Samples
{
    class CastExample
    {
        public void Sample1()
        {
            var numbers = new List<object>() { 1, 2, 3, 4, 5 };
            var result = numbers.Cast<int>();
            //  result = IEnumerable<int> { 1, 2, 3, 4, 5 }
        }
    }
}
