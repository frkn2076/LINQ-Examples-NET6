using System.Collections.Generic;
using System.Linq;

namespace LINQ_Examples_NET6.Samples
{
    class AllExample
    {
        public void Sample1()
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5 };
            var result = numbers.All(value => value < 10);
            //  result = (1 < 10) && (2 < 10) && (3 < 10) && (4 < 10) && (5 < 10)
        }
    }
}
