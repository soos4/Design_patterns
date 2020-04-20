using System;
namespace Mediator
{
    public abstract class AbstractUser
    {
        protected GroupMediator mediator;
        protected string name;

        public AbstractUser(GroupMediator mediator, string name)
        {
            this.mediator = mediator;
            this.name = name;
        }

        public abstract void Send(string message);
        public abstract void Receive(string message);
    }
}
