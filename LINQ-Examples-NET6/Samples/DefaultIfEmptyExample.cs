namespace LINQ_Examples_NET6.Samples
{
    class DefaultIfEmptyExample
    {
        public void Sample1()
        {
            var empty = new List<int>();
            var result = empty.DefaultIfEmpty();
            //  result = IEnumerable<int> { 0 }
        }
        
        public void Sample2()
        {
            var empty = new List<int>();
            var result = empty.DefaultIfEmpty(5);
            //  result = IEnumerable<int> { 5 }
        }
    }
}
