using System;
using System.Collections.Generic;

namespace Observer
{
    public class Stock
    {
        private string symbol;
        private double price;
        private List<Subscriber> subscricers = new List<Subscriber>();

        public Stock(string symbol, double price)
        {
            this.symbol = symbol;
            this.price = price;
        }

        public void Attach(Subscriber subscricer)
        {
            subscricers.Add(subscricer);
        }

        public void Detach(Subscriber subscricer)
        {
            subscricers.Remove(subscricer);
        }

        public void Notify()
        {
            foreach (Subscriber subscricer in subscricers)
            {
                subscricer.Update(this);
            }

            Console.WriteLine("");
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (price != value)
                {
                    price = value;
                    Notify();
                }
            }
        }

        public string Symbol
        {
            get { return symbol; }
        }
    }
}
