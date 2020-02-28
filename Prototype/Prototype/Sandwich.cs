using System;
namespace Prototype
{
    public class Sandwich : Food
    {
        private bool cheese;
        private string veggies;

        public Sandwich(string meat, bool cheese, string veggies)
        {
            this.meat = meat;
            this.cheese = cheese;
            this.veggies = veggies;
        }

        public override Food Clone()
        {
            return MemberwiseClone() as Food;
        }

        public override string ToString()
        {
            return "Sandwich: " + this.meat + " + cheese: " + cheese + " + " + veggies;
        }
    }
}
