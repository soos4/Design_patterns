using System;
namespace Memento
{
    public interface Memento
    {
        string GetName();

        //string GetState();

        DateTime GetDate();
    }
}
