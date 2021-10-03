using System;
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
            //  result = IEnumerable<IGrouping<int, string>>  { { Key: 3, ["Red"] }, { Key: 5, ["Green", "Black"] }, { Key: 4, ["Blue"] } }
        }

        public void Sample2()
        {
            var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
            var result = colors.GroupBy(x => x.Length, x => x.Substring(0, 1)).ToList();
            //  result = IEnumerable<IGrouping<int, char>>  { { Key: 3, ['R'] }, { Key: 5, ['G', 'B'] }, { Key: 4, ['B'] } }
        }

        public void Sample3()
        {
            var colors = new List<string>() { "Red", "Green", "blue", "Black" };
            var result = colors.GroupBy(x => x.Substring(0, 1), StringComparer.OrdinalIgnoreCase).ToList();
            //  result = IEnumerable<IGrouping<string, string>>  { { Key: "R", ["Red"] }, { Key: "G", ["Green"] }, { Key: "b", ["blue", "Black"] } }
        }

        public void Sample4()
        {
            var colors = new List<string>() { "Red", "Green", "blue", "Black" };
            var result = colors.GroupBy(x => x.Substring(0, 1), x => x.Substring(0, 1), StringComparer.OrdinalIgnoreCase).ToList();
            //  result = IEnumerable<IGrouping<string, char>>  { { Key: "R", ['R'] }, { Key: "G", ['G'] }, { Key: "b", ['b', 'B'] } }
        }
    }
}
