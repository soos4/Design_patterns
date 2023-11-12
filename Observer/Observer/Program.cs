namespace Observer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Investor investor1 = new Investor("George");
            Investor investor2 = new Investor("Karen");

            Stock ibm = new Stock("IBM", 2540);
            ibm.Attach(investor1);
            ibm.Attach(investor2);

            Stock microsoft = new Stock("MSFT", 3900);
            microsoft.Attach(investor1);
            microsoft.Attach(investor2);

            ibm.Price += 15;
            ibm.Price += 20;
            ibm.Price -= 19;
            microsoft.Price += 20;
            microsoft.Price -= 42;

            ibm.Detach(investor1);

            ibm.Price -= 12;
            microsoft.Price += 18;

            microsoft.Detach(investor2);

            ibm.Price += 33;
            microsoft.Price += 4;

            ibm.Attach(investor1);

            ibm.Price += 1;
            microsoft.Price -= 5;
        }
    }
}