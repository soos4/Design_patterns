using System;
namespace Prototype
{
    public class Gyros : Food
    {
        private string veggies;

        public Gyros(string meat, string veggies)
        {
            this.meat = meat;
            this.veggies = veggies;
        }

        public override Food Clone()
        {
            return MemberwiseClone() as Food;
        }

        public override string ToString()
        {
            return "Gyros: " + this.meat + " + " + veggies;
        }
    }
}
