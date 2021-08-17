using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Examples_NET6.Samples
{
    public class LastOrDefaultExample
    {
        public void Sample1()
        {
            var colors = new List<string>() { "Red", "Blue", "Purple", "Black" };
            var result = colors.LastOrDefault();
            //  result = "Black"

            var colors2 = new List<string>();
            var result2 = colors2.LastOrDefault();
            //  result = null
        }

        public void Sample2()
        {
            var colors = new List<string>() { "Red", "Blue", "Purple", "Black" };
            var result = colors.LastOrDefault("White");
            //  result = "Black"

            var colors2 = new List<string>();
            var result2 = colors2.LastOrDefault("White");
            //  result = "White"
        }

        public void Sample3()
        {
            var colors = new List<string>() { "Red", "Blue", "Purple", "Black" };
            var result = colors.LastOrDefault(x => x.Length < 5);
            //  result = "Blue"

            var colors2 = new List<string>();
            var result2 = colors2.LastOrDefault(x => x.Length < 5);
            //  result = null
        }

        public void Sample4()
        {
            var colors = new List<string>() { "Red", "Blue", "Purple", "Black" };
            var result = colors.LastOrDefault(x => x.Length < 5, "White");
            //  result = "Blue"

            var colors2 = new List<string>() { "Purple" };
            var result2 = colors2.LastOrDefault(x => x.Length < 5, "White");
            //  result = null
        }
    }
}
