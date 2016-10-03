using System;
using System.Collections.Generic;

namespace _10_Collections
{
    public class StockNameComparator : IComparer<IAsset>
    {
        public int Compare(IAsset a, IAsset b)
        {
            return a.GetName().CompareTo(b.GetName());
        }
    }
}