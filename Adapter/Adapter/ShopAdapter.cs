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

        public List<string> GetProducts()
        {
            return adaptedShop.GetListOfProducts();
        }
    }
}
