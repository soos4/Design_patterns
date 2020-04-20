using System;
namespace Mediator
{
    public interface GroupMediator
    {
        void SendMessage(string msg, User user);
        void RegisterUser(User user);
    }
}
