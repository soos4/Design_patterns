using System;
using System.Collections.Generic;

namespace Composite
{
    public class GiftBox : Gift, GiftOperations
    {
        private List<Gift> gifts;

        public GiftBox(string name, int price) : base(name, price)
        {
            gifts = new List<Gift>();
        }

        public void Add(Gift gift)
        {
            gifts.Add(gift);
        }

        public void Remove(Gift gift)
        {
            gifts.Remove(gift);
        }

        public override int CalculateTotalPrice()
        {
            int total = 0;

            Console.WriteLine(name + " contains the following products with prices:");

            foreach (Gift gift in gifts)
            {
                total += gift.CalculateTotalPrice();
            }

            return total;
        }
    }
}
