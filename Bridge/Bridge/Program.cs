using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            GUI gui1 = new SimpleGUI(new WindowsOS());

            GUI gui2 = new ProgrammerGUI(new LinuxOS());

            Console.WriteLine(gui1.GetInfo());
            Console.WriteLine(gui2.GetInfo());
        }
    }
}
