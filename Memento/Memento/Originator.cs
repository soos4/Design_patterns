using System;
using System.Threading;

namespace Memento
{
    public class Originator
    {
        // For the sake of simplicity, the originator's state is stored inside a
        // single variable.
        private string state;

        public Originator(string state)
        {
            this.state = state;
            Console.WriteLine("Originator: My initial state is: " + this.state);
        }

        // The Originator's business logic may affect its internal state.
        // Therefore, the client should backup the state before launching
        // methods of the business logic via the save() method.
        public void DoSomething()
        {
            Console.WriteLine("Originator: I'm doing something important.");
            this.state = this.GenerateRandomString(30);
            Console.WriteLine("Originator: and my state has changed to: " + this.state);
        }

        private string GenerateRandomString(int length = 10)
        {
            string allowedSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string result = string.Empty;

            while (length > 0)
            {
                result += allowedSymbols[new Random().Next(0, allowedSymbols.Length)];

                Thread.Sleep(12);

                length--;
            }

            return result;
        }

        // Saves the current state inside a memento.
        public Memento Save()
        {
            return new DefaultMemento(this.state);
        }

        // Restores the Originator's state from a memento object.
        public void Restore(Memento memento)
        {
            if (!(memento is DefaultMemento))
            {
                throw new Exception("Unknown memento class " + memento.ToString());
            }

            this.state = ((DefaultMemento) memento).GetState();
            Console.Write("Originator: My state has changed to: " + this.state);
        }
    }
}
