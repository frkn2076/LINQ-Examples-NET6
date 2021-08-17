using LINQ_Examples_NET6.Comparer;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Examples_NET6.Samples
{
    public class IntersectByExample
    {
        public void Sample1()
        {
            var colors1 = new List<string>() { "Red", "Blue", "White", "Black" };
            var colors2 = new List<string>() { "R", "b", "black", "Green" };

            var result = colors1.IntersectBy(colors2, x => x.Substring(0,1));
            //  result = IEnumerable<string> { "Red" } 
        }

        public void Sample2()
        {
            var colors1 = new List<string>() { "Red", "Blue", "White", "Black" };
            var colors2 = new List<string>() { "R", "b", "black", "Green" };

            var result = colors1.IntersectBy(colors2, x => x.Substring(0, 1), new IgnoreCaseComparer());
            //  result = IEnumerable<string> { "Red", "Blue" } 
        }
    }
}
