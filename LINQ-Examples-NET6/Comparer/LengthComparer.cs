using System.Collections.Generic;

namespace LINQ_Examples_NET6.Comparer
{
    public class LengthComparer : IComparer<string>
    {
        public int Compare(string x, string y) => (x?.Length ?? 0).CompareTo(y?.Length ?? 0);
    }
}
