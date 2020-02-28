using System;
namespace Composite
{
    public abstract class Gift
    {
        protected string name;
        protected int price;

        public Gift(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public abstract int CalculateTotalPrice();
    }
}
