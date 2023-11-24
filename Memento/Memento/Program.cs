namespace Memento
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Originator originator = new Originator("starting_state");
            Caretaker caretaker = new Caretaker(originator);

            caretaker.Backup();

            originator.DoSomething();
            caretaker.Backup();

            originator.DoSomething();
            caretaker.Backup();

            originator.DoSomething();
            caretaker.Backup();

            caretaker.ShowHistory();

            caretaker.Undo();
            caretaker.Undo();

            caretaker.ShowHistory();
        }
    }
}