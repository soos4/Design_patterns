using System;
namespace Factory
{
        public class TitaniumFactory : CardFactory
        {
            private int _creditLimit;
            private int _annualCharge;

            public TitaniumFactory(int creditLimit, int annualCharge)
            {
                _creditLimit = creditLimit;
                _annualCharge = annualCharge;
            }

            public override CreditCard GetCreditCard()
            {
                return new TitaniumCreditCard(_creditLimit, _annualCharge);
            }
        }
}
