using System;
namespace Composite
{
    public class SingleGift : Gift
    {
        public SingleGift(string name, int price) : base(name, price)
        {
        }

        public override int CalculateTotalPrice()
        {
            Console.WriteLine(name + " with the price " + price);

            return price;
        }
    }
}
