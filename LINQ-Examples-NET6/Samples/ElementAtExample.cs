using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Examples_NET6.Samples
{
    class ElementAtExample
    {
        public void Sample1()
        {
            var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
            var result = colors.ElementAt(1);
            //  result = "Green"
        }

        public void Sample2()
        {
            var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
            var result = colors.ElementAt(new Index(2, true));
            //  result = "Blue"
        }
    }
}
