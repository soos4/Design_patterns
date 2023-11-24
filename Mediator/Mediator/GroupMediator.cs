using System;

namespace Mediator
{
    public interface GroupMediator
    {
        void SendMessage(string msg, User sender);
        void RegisterUser(User user);
    }
}