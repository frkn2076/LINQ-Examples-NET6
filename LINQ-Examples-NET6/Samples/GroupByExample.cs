using System.Collections.Generic;
using System.Linq;

namespace LINQ_Examples_NET6.Samples
{
    class GroupByExample
    {
        public void Sample1()
        {
            var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
            var result = colors.GroupBy(x => x.Length).ToList();
        }
    }
}
