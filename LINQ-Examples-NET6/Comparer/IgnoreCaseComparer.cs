using System;
using System.Collections.Generic;

namespace LINQ_Examples_NET6.Comparer
{
    public class IgnoreCaseComparer : IComparer<string>
    {
        public int Compare(string x, string y) => string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
    }
}
