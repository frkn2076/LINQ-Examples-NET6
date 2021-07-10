using System.Collections.Generic;
using System.Linq;

namespace LINQ_Examples_NET6.Samples
{
    class FirstOrDefaultExample
    {
        public void Sample1()
        {
            var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
            var result = colors.FirstOrDefault();
            //  result = "Red"
            var colors2 = new List<string>() { };
            var result2 = colors2.FirstOrDefault();
            //  result = null
        }

        public void Sample2()
        {
            var colors = new List<string>() { };
            var result = colors.FirstOrDefault("White");
            //  result = "White"
        }

        public void Sample3()
        {
            var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
            var result = colors.FirstOrDefault(x => x.Length > 3);
            //  result = "Green"
            var result2 = colors.FirstOrDefault(x => x.Length > 5);
            //  result = null
        }

        public void Sample4()
        {
            var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
            var result = colors.FirstOrDefault(x => x.Length > 5, "White");
            //  result = "White"
        }
    }
}
