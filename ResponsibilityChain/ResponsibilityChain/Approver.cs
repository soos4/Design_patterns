using System;
namespace ResponsibilityChain
{
    public abstract class Approver
    {
        protected Approver supervisor;

        public void SetSupervisor(Approver supervisor)
        {
            this.supervisor = supervisor;
        }

        public abstract void ProcessRequest(PurchaseOrder purchase);
    }
}
