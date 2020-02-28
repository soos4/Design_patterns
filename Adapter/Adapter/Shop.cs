using System;
using System.Collections.Generic;

namespace Adapter
{
    public class Shop
    {
        public List<string> GetListOfProducts()
        {
            List<string> products = new List<string>();

            products.Add("Gaming Consoles");
            products.Add("Television");
            products.Add("Books");
            products.Add("Musical Instruments");

            return products;
        }
    }
}
