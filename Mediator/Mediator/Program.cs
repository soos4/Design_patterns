using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GroupMediator mediator = new MessageGroupMediator();

            List<User> users = new List<User>
            {
                new User(mediator, "John"),
                new User(mediator, "Adele"),
                new User(mediator, "Steve"),
                new User(mediator, "Tim"),
                new User(mediator, "Melinda"),
                new User(mediator, "Julia"),
                new User(mediator, "Alan"),
                new User(mediator, "Dave")
            };

            foreach (User user in users)
            {
                mediator.RegisterUser(user);
            }

            users[0].Send("Hello");
            Console.WriteLine();

            users[2].Send("What's up?");
            Console.WriteLine();

            User olivia = new User(mediator, "Olivia");
            users.Add(olivia);
            mediator.RegisterUser(olivia);

            users[2].Send("Doing great?");
        }
    }
}