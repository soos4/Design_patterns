using System;

namespace Proxy
{
    public class MathProxy : Math
    {
        private Math _math = new SimpleMath();

        private int addCounter = 0;
        private int subCounter = 0;
        private int mulCounter = 0;
        private int divCounter = 0;

        public double Add(double x, double y)
        {
            addCounter++;
            Console.WriteLine("This is the " + addCounter + ". time calling add");
            return _math.Add(x, y);
        }

        public double Sub(double x, double y)
        {
            subCounter++;
            Console.WriteLine("This is the " + subCounter + ". time calling sub");
            return _math.Sub(x, y);
        }

        public double Mul(double x, double y)
        {
            mulCounter++;
            Console.WriteLine("This is the " + mulCounter + ". time calling mul");
            return _math.Mul(x, y);
        }

        public double Div(double x, double y)
        {
            divCounter++;
            Console.WriteLine("This is the " + divCounter + ". time calling div");
            return _math.Div(x, y);
        }
    }
}