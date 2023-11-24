namespace State
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Account account = new Account("Joe");

            account.Deposit(500);
            account.PayInterest();
            account.Deposit(1200);
            account.PayInterest();
            account.Withdraw(1400);
            account.PayInterest();
            account.Withdraw(1000);
            account.PayInterest();
            account.Withdraw(200);
            account.Deposit(1000);
        }
    }
}