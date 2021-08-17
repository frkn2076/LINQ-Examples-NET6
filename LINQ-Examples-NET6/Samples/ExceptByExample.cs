using LINQ_Examples_NET6.Comparer;
using LINQ_Examples_NET6.Models;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Examples_NET6.Samples
{
    class ExceptByExample
    {
        public void Sample1()
        {
            var first = new List<Person>() { new("Leonardo", "Dicaprio"), new("Tom", "Hanks"), new("TOM", "Sawyer"), new("Tom", "Hiddlestone") };
            var second = new List<string>() { "Tom", "Hugh" };
            var result = first.ExceptBy(second, x => x.Name);
            //  result = IEnumerable<User>() { new("Leonardo", "Dicaprio"), new("TOM", "Sawyer") }
        }

        public void Sample2()
        {
            var first = new List<Person>() { new("Leonardo", "Dicaprio"), new("Tom", "Hanks"), new("TOM", "Sawyer"), new("Tom", "Hiddlestone") };
            var second = new List<string>() { "ToM", "HUGh" };
            var result = first.ExceptBy(second, x => x.Name, new IgnoreCaseEqualityComparer());
            //  result = IEnumerable<User>() { new("Leonardo", "Dicaprio") }
        }
    }
}
