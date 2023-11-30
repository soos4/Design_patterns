using System;
using System.Collections.Generic;

namespace Observer
{
    public class Stock
    {
        private string symbol;
        private double price;
        private List<Subscriber> subscribers = new List<Subscriber>();

        public Stock(string symbol, double price)
        {
            this.symbol = symbol;
            this.price = price;
        }

        public void Attach(Subscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void Detach(Subscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }

        public void Notify()
        {
            foreach (Subscriber subscriber in subscribers)
            {
                subscriber.Update(this);
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