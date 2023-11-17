using System;
using System.Collections.Generic;

namespace Adapter
{
    public class Shop
    {
        public List<string> GetListOfProducts()
        {
            List<string> products = new List<String>
            {
                "Gaming Consoles",
                "Television",
                "Books",
                "Musical Instruments"
            };

            return products;
        }
    }
}