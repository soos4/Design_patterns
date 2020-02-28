using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Listable adapter = new ShopAdapter();
            foreach (string product in adapter.GetProducts())
            {
                Console.WriteLine(product);
            }
            Console.ReadLine();
        }
    }
}
