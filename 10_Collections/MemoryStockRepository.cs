using System;
using System.Collections;
using System.Collections.Generic;

namespace _10_Collections
{
    internal class MemoryStockRepository : IStockRepository
    {
        private long id = 0;
        private Dictionary<long, Stock> assetList = new Dictionary<long, Stock>();
        public Stock LoadStock(long id)
        {
            return assetList[id];
        }

        public long NextId()
        {
            return ++id;
        }

        public void SaveStock(Stock asset)
        {
            asset.Id = NextId();
            assetList.Add(asset.Id, asset);
        }

        public ICollection FindAllStocks()
        {
            return assetList;
        }

        public void Clear()
        {
            assetList.Clear();
        }
    }
}