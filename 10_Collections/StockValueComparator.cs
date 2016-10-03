using System;
using System.Collections.Generic;

namespace _10_Collections
{
    public class StockValueComparator : IComparer<IAsset>
    {
        public int Compare(IAsset a, IAsset b)
        {
            return b.GetValue().CompareTo(a.GetValue());
        }
    }
}