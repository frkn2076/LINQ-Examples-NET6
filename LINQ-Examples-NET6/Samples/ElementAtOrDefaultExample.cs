using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Examples_NET6.Samples
{
    class ElementAtOrDefaultExample
    {
        public void Sample1()
        {
            var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
            var result = colors.ElementAtOrDefault(1);
            //  result = "Green"
            var result2 = colors.ElementAtOrDefault(7);
            //  result2 = null
        }

        public void Sample2()
        {
            var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
            var result = colors.ElementAtOrDefault(new Index(2, true));
            //  result = "Blue"
            var result2 = colors.ElementAtOrDefault(new Index(5, true));
            //  result2 = null
        }
    }
}
