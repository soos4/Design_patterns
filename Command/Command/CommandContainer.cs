using System;
using System.Collections.Generic;

namespace Command
{
    public class CommandContainer
    {
        private static CommandContainer instance;

        private List<Command> commands;

        private CommandContainer()
        {
            commands = new List<Command>();
        }

        public static CommandContainer GetInstance()
        {
            if (instance == null)
            {
                instance = new CommandContainer();
            }

            return instance;
        }

        public void StoreAndExecute(Command command)
        {
            commands.Add(command);
            Console.WriteLine("Executing command " + (commands.Count - 1));
            command.Execute();
        }

        public void Undo()
        {
            Console.WriteLine("Undoing command " + (commands.Count - 1));
            commands[commands.Count - 1].Undo();
            commands.Remove(commands[commands.Count - 1]);
        }
    }
}