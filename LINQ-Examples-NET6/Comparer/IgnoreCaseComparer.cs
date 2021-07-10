using System;
using System.Collections.Generic;

namespace LINQ_Examples_NET6.Comparer
{
    class IgnoreCaseComparer : IEqualityComparer<string>
    {
        public bool Equals(string left, string right)
        {
            if (left is null ^ right is null)
                return false;

            return left is null || left.Equals(right, StringComparison.OrdinalIgnoreCase);
        }

        public int GetHashCode(string obj) => obj == null ? 0 : obj.ToLower().GetHashCode();
    }
}
