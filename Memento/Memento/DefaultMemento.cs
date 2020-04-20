using System;
namespace Memento
{
    public class DefaultMemento : Memento
    {
        private string state;

        private DateTime date;

        public DefaultMemento(string state)
        {
            this.state = state;
            this.date = DateTime.Now;
        }

        // The Originator uses this method when restoring its state.
        public string GetState()
        {
            return this.state;
        }

        // The rest of the methods are used by the Caretaker to display
        // metadata.
        public string GetName()
        {
            return this.date + " / " + (this.state.Substring(0, 9)) + "...";
        }

        public DateTime GetDate()
        {
            return this.date;
        }
    }
}
