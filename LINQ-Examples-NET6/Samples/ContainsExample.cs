using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Examples_NET6.Samples
{
    class ContainsExample
    {
        public void Sample1()
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5 };
            var result = numbers.Contains<int>(1);
            //  result = 1 == 3 || 2 == 3 || 3 == 3 || 4 == 3 || 5 == 3
        }

        public void Sample2()
        {
            var colors = new List<string>() { "Red", "Green", "Blue", "Black" };
            var result = colors.Contains("RED", IgnoreCaseComparer.Create());
            //  result = Compares given string with the items according to IgnoreCaseComparer.
        }
    }

    class IgnoreCaseComparer : IEqualityComparer<string>
    {
        public static IgnoreCaseComparer Create() => new();

        public bool Equals(string left, string right)
        {
            if (ReferenceEquals(left, null) ^ ReferenceEquals(right, null))
                return false;

            return ReferenceEquals(left, null) || left.Equals(right, StringComparison.OrdinalIgnoreCase);
        }

        public int GetHashCode(string obj) => obj.GetHashCode();
    }
}
