using System;
namespace State
{
    public class Account
    {
        private State state;
        private string owner;

        // Constructor

        public Account(string owner)
        {
            // New accounts are 'Silver' by default

            this.owner = owner;
            this.state = new SilverState(0.0, this);
        }

        // Properties

        public double Balance
        {
            get { return state.Balance; }
        }

        public State State
        {
            get { return state; }
            set { state = value; }
        }

        public void Deposit(double amount)
        {
            state.Deposit(amount);
            Console.WriteLine("Deposited " + amount + " --- ");
            Console.WriteLine(" Balance = " + this.Balance);
            Console.WriteLine(" Status = " + this.State.GetType().Name);
            Console.WriteLine();
        }

        public void Withdraw(double amount)
        {
            state.Withdraw(amount);
            Console.WriteLine("Withdrew {0:C} " + amount + " --- ");
            Console.WriteLine(" Balance = " + this.Balance);
            Console.WriteLine(" Status = " + this.State.GetType().Name);
            Console.WriteLine();
        }

        public void PayInterest()
        {
            state.PayInterest();
            Console.WriteLine("Interest Paid --- ");
            Console.WriteLine(" Balance = " + this.Balance);
            Console.WriteLine(" Status = " + this.State.GetType().Name);
            Console.WriteLine();
        }
    }
}
