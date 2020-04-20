using System;
namespace Iterator
{
    public interface AbstractIterator
    {
        Item First();
        Item Next();
        bool IsDone { get; }
        int Step { get; set; }
        Item CurrentItem { get; }
    }
}
