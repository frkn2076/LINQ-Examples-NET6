using System.Collections.Generic;
using System.Linq;

namespace LINQ_Examples_NET6.Samples
{
    class SkipWhileExample
    {
        public void Sample1()
        {
            var colors = new List<string>() { "Red", "Green", "Blue", "Black", "White" };
            var result = colors.SkipWhile(x => x.Length < 5);
            //  result = IEnumerable<string>() { "Green", "Blue", "Black", "White" }
        }

        public void Sample2()
        {
            var colors = new List<string>() { "Red", "Green", "Blue", "Black", "White" };
            var result = colors.SkipWhile((v,i) => v.Length - i > 2);
            //  result = IEnumerable<string>() { "Blue", "Black", "White" }
        }
    }
}
