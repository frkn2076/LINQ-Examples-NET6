using System.Collections.Generic;
using System.Linq;

namespace LINQ_Examples_NET6.Samples
{
    class ConcatExample
    {
        public void Sample1()
        {
            var numbers1 = new List<int>() { 1, 2 };
            var numbers2 = new List<int>() { 3, 4, 5 };
            var result = numbers1.Concat(numbers2);
            //  result = IEnumerable<int> { 1, 2, 3, 4, 5 }
        }
    }
}
