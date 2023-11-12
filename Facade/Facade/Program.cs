using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Customer customer1 = new Customer("John");
            Mortgage mortgage = new Mortgage();

            Console.WriteLine("Checking if customer is eligible for 5000:");
            bool isEligible = mortgage.IsEligible(customer1, 5000);
            Console.WriteLine(isEligible);

            Console.WriteLine("Checking if customer is eligible for 20000:");
            isEligible = mortgage.IsEligible(customer1, 20000);
            Console.WriteLine(isEligible);
        }
    }
}