using System;

namespace Proxy
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Math math = new MathProxy();

            Console.WriteLine(math.Add(15, 24));
            Console.WriteLine(math.Div(10, 2));
            Console.WriteLine(math.Mul(30, 4));
            Console.WriteLine(math.Sub(15, 12));
            Console.WriteLine(math.Mul(32, 2));
            Console.WriteLine(math.Add(10, 13));
            Console.WriteLine(math.Add(43, 51));
        }
    }
}