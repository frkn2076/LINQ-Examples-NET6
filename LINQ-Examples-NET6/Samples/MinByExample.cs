using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Examples_NET6.Samples
{
    public class MinByExample
    {
        public void Sample1()
        {
            var colors = new List<string>() { "Red", "Blue", "Purple", "Black" };
            var result = colors.MinBy(x => x.Length);
            //  result = "Red"
        }

        public void Sample2()
        {
            var colors = new List<string>() { "Gray", "Blue", "lack", "Purple" };
            var result = colors.MinBy(x => x.Substring(0, 1), StringComparer.OrdinalIgnoreCase);
            //  result = "Blue"
        }
    }
}
