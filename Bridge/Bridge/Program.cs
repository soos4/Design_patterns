using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            GUI gui1 = new SimpleGUI(new WindowsOS());

            GUI gui2 = new ProgrammerGUI(new LinuxOS());

            GUI gui3 = new ProgrammerGUI(new MobileOS());

            Console.WriteLine(gui1.GetInfo());
            Console.WriteLine(gui2.GetInfo());
            System.Console.WriteLine(gui3.GetInfo());
        }
    }
}