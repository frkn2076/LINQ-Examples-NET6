using System.Collections.Generic;
using System.Linq;

namespace LINQ_Examples_NET6.Samples
{
    class SumExample
    {
        public void Sample1()
        {
            var numbers = new List<int>() { 1, 2, 5, 4, 3 };
            var result = numbers.Sum();
            //  result = 15
        }

        public void Sample2()
        {
            var numbers = new List<int>() { 1, 2, 5, 4, 3 };
            var result = numbers.Sum(x => x + 1);
            //  result = 20
        }
    }
}
