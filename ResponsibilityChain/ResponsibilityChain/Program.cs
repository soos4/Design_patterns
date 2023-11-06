using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsibilityChain
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Approver headChef = new HeadChef();
            Approver purchasingManager = new PurchasingManager();
            Approver generalManager = new GeneralManager();

            List<PurchaseOrder> orders = new List<PurchaseOrder>
            {
                new PurchaseOrder(1, 10, 800, "pen"),
                new PurchaseOrder(2, 2, 1500, "painting"),
                new PurchaseOrder(3, 1, 8000, "statue"),
                new PurchaseOrder(4, 1, 20000, "property")
            };

            headChef.SetSupervisor(purchasingManager);
            purchasingManager.SetSupervisor(generalManager);

            foreach (PurchaseOrder order in orders)
            {
                headChef.ProcessRequest(order);
            }
        }
    }
}