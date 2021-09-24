using System.Collections.Generic;
using System.Linq;

namespace LINQ_Examples_NET6.Samples
{
    class TakeLastExample
    {
        public void Sample1()
        {
            var colors = new List<string>() { "Red", "Green", "Blue", "Black", "White" };
            var result = colors.TakeLast(2);
            //  result = IEnumerable<string>() { "Black", "White" }
        }
    }
}
