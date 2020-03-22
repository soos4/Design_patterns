using System;
namespace ResponsibilityChain
{
    public class PurchasingManager : Approver
    {
        public override void ProcessRequest(PurchaseOrder purchase)
        {
            if (purchase.Price < 2500)
            {
                Console.WriteLine("{0} approved purchase request #{1}", this.GetType().Name, purchase.RequestNumber);
            }
            else if (supervisor != null)
            {
                supervisor.ProcessRequest(purchase);
            }
        }
    }
}
