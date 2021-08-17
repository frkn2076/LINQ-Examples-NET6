using System.Collections.Generic;
using System.Linq;

namespace LINQ_Examples_NET6.Samples
{
    public class LongCountExample
    {
        public void Sample1()
        {
            var colors = new List<string>() { "Red", "Blue", "Purple", "Black" };
            var result = colors.LongCount();
            //  result = 4
        }

        public void Sample2()
        {
            var colors = new List<string>() { "Red", "Blue", "Purple", "Black" };
            var result = colors.LongCount(x => x.Length > 3);
            //  result = 3
        }
    }
}
