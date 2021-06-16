using System.Collections.Generic;
using System.Linq;

namespace LINQ_Examples_NET6.Samples
{
    class AppendExample
    {
        public void Sample1()
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5 };
            var result = numbers.Append(10);
            //  result = IEnumerable<int> { 1, 2, 3, 4, 5, 10 }
        }
    }
}
