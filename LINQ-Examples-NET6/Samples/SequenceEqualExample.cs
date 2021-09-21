using LINQ_Examples_NET6.Comparer;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Examples_NET6.Samples
{
    class SequenceEqualExample
    {
        public void Sample1()
        {
            var colors1 = new List<string>() { "Red", "Green", "Blue", "Black" };
            var colors2 = new List<string>() { "Red", "Green", "Blue", "Black" };
            var colors3 = new List<string>() { "Black", "Red", "Green", "Blue",  };
            var result1 = Enumerable.SequenceEqual(colors1, colors2);
            var result2 = Enumerable.SequenceEqual(colors1, colors3);
            //  result1 = true
            //  result2 = false
        }

        public void Sample2()
        {
            var colors1 = new List<string>() { "Red", "Green", "Blue", "Black" };
            var colors2 = new List<string>() { "red", "GrEen", "Blue", "Black" };
            var result = Enumerable.SequenceEqual(colors1, colors2, new IgnoreCaseEqualityComparer());
            //  result = true
        }
    }
}
