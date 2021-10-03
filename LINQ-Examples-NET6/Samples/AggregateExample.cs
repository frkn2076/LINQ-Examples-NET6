namespace LINQ_Examples_NET6.Samples
{
    class AggregateExample
    {
        public void Sample1()
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5 };
            var result = numbers.Aggregate((acc, value) => acc * value);
            //  result = (((1 * 2) * 3) * 4) * 5
        }

        public void Sample2()
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5 };
            var result = numbers.Aggregate(10, (acc, value) => acc * value);
            //  result = ((((10 * 1) * 2) * 3) * 4) * 5
        }


        public void Sample3()
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5 };
            var result = numbers.Aggregate(10, (acc, value) => acc * value, res => res / 2);
            //  result = (((((10 * 1) * 2) * 3) * 4) * 5) / 10
        }
    }
}
