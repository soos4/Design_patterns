using System;
using System.Collections.Generic;

namespace Adapter
{
    public class ShopAdapter : Listable
    {
        private Shop adaptedShop;

        public ShopAdapter()
        {
            adaptedShop = new Shop();
        }

        public string[] GetProducts()
        {
            return adaptedShop.GetListOfProducts().ToArray();
        }
    }
}