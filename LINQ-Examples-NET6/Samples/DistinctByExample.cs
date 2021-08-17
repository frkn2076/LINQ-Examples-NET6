using LINQ_Examples_NET6.Comparer;
using LINQ_Examples_NET6.Models;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Examples_NET6.Samples
{
    class DistinctByExample
    {
        public void Sample1()
        {
            var actors = new List<Person>() { new("Leonardo", "Dicaprio"), new("Tom", "Hanks"), new("Tom", "Sawyer"), new("Tom", "Hiddlestone") };
            var result = actors.DistinctBy(x => x.Name);
            //  result = List<User>() { new("Leonardo", "Dicaprio"), new("Tom", "Hanks") }
        }
        
        public void Sample2()
        {
            var colors = new List<Person>() { new("Leonardo", "Dicaprio"), new("Tom", "Hanks"), new("TOM", "Sawyer"), new("tom", "Hiddlestone") };
            var result = colors.DistinctBy(x => x.Name, new IgnoreCaseComparer());
            //  result = IEnumerable<User>() { new("Leonardo", "Dicaprio"), new("Tom", "Hanks") }
        }
    }

}
