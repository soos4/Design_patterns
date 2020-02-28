using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            CardFactory factory1 = new MoneyBackFactory(5000, 10);
            CardFactory factory2 = new TitaniumFactory(5000, 10);

            CreditCard creditCard1 = factory1.GetCreditCard();

            Console.WriteLine("\nYour card details are below : \n");
            Console.WriteLine("Card Type: {0}\nCredit Limit: {1}\nAnnual Charge: {2}",
                creditCard1.CardType, creditCard1.CreditLimit, creditCard1.AnnualCharge);

            creditCard1 = factory2.GetCreditCard();

            Console.WriteLine("\nYour card details are below : \n");
            Console.WriteLine("Card Type: {0}\nCredit Limit: {1}\nAnnual Charge: {2}",
                creditCard1.CardType, creditCard1.CreditLimit, creditCard1.AnnualCharge);
        }
    }
}
