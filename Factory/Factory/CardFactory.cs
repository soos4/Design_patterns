using System;
namespace Factory
{
    public abstract class CardFactory
    {
        public abstract CreditCard GetCreditCard();
    }
}
