using System;
namespace Facade
{
    public class Customer
    {
        private string name;

        public Customer(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }
    }
}
