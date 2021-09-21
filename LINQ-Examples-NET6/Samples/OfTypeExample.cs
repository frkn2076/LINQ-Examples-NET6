using System.Collections;
using System.Linq;

namespace LINQ_Examples_NET6.Samples
{
    public class OfTypeExample
    {
        public void Sample1()
        {
            var items = new ArrayList() { "White", 1, 2.0, "George" };
            var result = items.OfType<string>();
            //  IEnumerable<string> { "White", "George" }
        }
    }
}
