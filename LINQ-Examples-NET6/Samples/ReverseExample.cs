using System.Collections.Generic;
using System.Linq;

namespace LINQ_Examples_NET6.Samples
{
    class ReverseExample
    {
        public void Sample1()
        {
            IEnumerable<string> colors = new List<string>() { "Red", "Green", "Blue", "Black" };
            colors = colors.Reverse();
            //  colors = IEnumerable<string> { "Black", "Blue", "Green", "Red" }
        }
    }
}
