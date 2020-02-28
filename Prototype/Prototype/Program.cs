using System;
using System.Collections.Generic;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Food> orders = new Dictionary<string, Food>();

            orders.Add("Customer1", new Sandwich("pork", true, "tomato, onion"));
            orders.Add("Customer2", orders["Customer1"].Clone());

            orders["Customer1"].SetMeat("lamb");

            orders.Add("Customer3", new Gyros("chicken", "tomato"));
            orders.Add("Customer4", orders["Customer3"].Clone());

            foreach (Food order in orders.Values)
            {
                Console.WriteLine(order);
            }
        }
    }
}
