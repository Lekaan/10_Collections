using System;
using System.Collections.Generic;
using System.Linq;

namespace _10_Collections
{
    internal class Portfolio
    {
        private List<IAsset> assetList;

        public Portfolio()
        {
            assetList = new List<IAsset>();
        }

        public Portfolio(List<IAsset> stocks)
        {
            assetList = stocks;
        }

        internal double GetTotalValue()
        {
            double result = 0;
            foreach (IAsset asset in assetList)
                result += asset.GetValue();

            return result;
        }

        internal void AddAsset(IAsset asset)
        {
            assetList.Add(asset);
        }

        internal IList<IAsset> GetAssets()
        {
            return assetList;
        }

        internal IAsset GetAssetByName(string asset)
        {
            for (int i = 0; i < assetList.Count; i++)
            {
                if (assetList[i].GetName().Equals(asset))
                    return assetList[i];
            }

            return null;
        }

        internal IList<IAsset> GetAssetsSortedByName()
        {
            assetList.Sort(new StockNameComparator());
            return assetList;
        }

        internal IList<IAsset> GetAssetsSortedByValue()
        {
            assetList.Sort(new StockValueComparator());
            return assetList;

        }
    }
}