using System;
namespace Prototype
{
    public abstract class Food
    {
        protected String meat;

        public void SetMeat(String meat)
        {
            this.meat = meat;
        }

        public abstract Food Clone();
    }
}
