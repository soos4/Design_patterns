using System;

namespace Observer
{
    public class Investor : Subscriber
    {
        private string name;

        public Investor(string name)
        {
            this.name = name;
        }

        public void Update(Stock stock)
        {
            Console.WriteLine("Notified " + name + " of " + stock.Symbol + "'s change to " + stock.Price);
        }
    }
}