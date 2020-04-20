using System;
using System.Collections.Generic;

namespace Memento
{
    public class Caretaker
    {
        private List<Memento> mementos = new List<Memento>();

        private Originator originator = null;

        public Caretaker(Originator originator)
        {
            this.originator = originator;
        }

        public void Backup()
        {
            Console.WriteLine("\nCaretaker: Saving Originator's state...");
            this.mementos.Add(this.originator.Save());
        }

        public void Undo()
        {
            if (this.mementos.Count == 0)
            {
                return;
            }

            Memento memento = this.mementos[mementos.Count - 1];
            this.mementos.Remove(memento);

            Console.WriteLine("Caretaker: Restoring state to: " + memento.GetName());

            try
            {
                this.originator.Restore(memento);
            }
            catch (Exception)
            {
                this.Undo();
            }
        }

        public void ShowHistory()
        {
            Console.WriteLine("Caretaker: Here's the list of mementos:");

            foreach (Memento memento in this.mementos)
            {
                Console.WriteLine(memento.GetName());
            }
        }
    }
}
