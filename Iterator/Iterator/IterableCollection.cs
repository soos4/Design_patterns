using System;
namespace Iterator
{
    public interface IterableCollection
    {
        AbstractIterator CreateIterator();
    }
}
