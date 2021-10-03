namespace LINQ_Examples_NET6.Samples
{
    class AsEnumerableExample
    {
        public void Sample1()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            var result = numbers.AsEnumerable();
            //  result = IEnumerable<int> { 1, 2, 3, 4, 5 }
        }
    }
}
