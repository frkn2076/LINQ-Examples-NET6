using LINQ_Examples_NET6.Comparer;
using LINQ_Examples_NET6.Models;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Examples_NET6.Samples
{
    class ThenByExample
    {
        public void Sample1()
        {
            var actors = new List<Person>() { new("Leonardo", "Dicaprio"), new("Tom", "Hanks"), new("Tom", "Sawyer"), new("Tom", "Hiddlestone") };
            var result = actors.OrderBy(x => x.Name).ThenBy(x => x.Surname);
            //  result = IOrderedEnumerable<Person>  { new("Leonardo", "Dicaprio"), new("Tom", "Hanks"), new("Tom", "Hiddlestone"), new("Tom", "Sawyer") }
        }

        public void Sample2()
        {
            var actors = new List<Person>() { new("Leonardo", "Dicaprio"), new("Tom", "Hanks"), new("Tom", "Sawyer"), new("Tom", "Hiddlestone") };
            var result = actors.OrderBy(x => x.Name).ThenBy(x => x.Surname, new LengthComparer());
            //  result = IOrderedEnumerable<Person>  { new("Leonardo", "Dicaprio"), new("Tom", "Hanks"), new("Tom", "Sawyer"), new("Tom", "Hiddlestone") }
        }
    }
}
