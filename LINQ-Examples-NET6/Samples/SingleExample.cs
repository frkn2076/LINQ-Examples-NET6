using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Examples_NET6.Samples
{
    class SingleExample
    {
        public void Sample1()
        {
            var colors1 = new List<string>() { "Red", "Green", "Blue", "Black" };
            try
            {
                var result1 = colors1.Single();
            }
            catch (Exception)
            {
                // ex = "Sequence contains more than one element"
            }

            var colors2 = new List<string>();
            try
            {
                var result2 = colors2.Single();
            }
            catch (Exception)
            {
                // ex = "Sequence contains no elements"
            }

            var colors3 = new List<string>() { "Blue" };
            var result3 = colors3.Single();
            //  result3 = "Blue"
        }

        public void Sample2()
        {
            var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
            try
            {
                var result1 = colors.Single(x => x.Length > 3);
            }
            catch (Exception)
            {
                // ex = "Sequence contains more than one element"
            }

            try
            {
                var result1 = colors.Single(x => x.Length > 7);
            }
            catch (Exception)
            {
                // ex = "Sequence contains no elements"
            }

            var result2 = colors.Single(x => x.Length == 3);
            //  result2 = "Red"
        }
    }
}
