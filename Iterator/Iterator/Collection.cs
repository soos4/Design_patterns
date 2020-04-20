using System;
using System.Collections.Generic;

namespace Iterator
{
    public class Collection : IterableCollection
    {
        private List<Item> items = new List<Item>();

        public AbstractIterator CreateIterator()
        {
            return new Iterator(this);
        }

        // Gets item count
        public int Count
        {
            get { return items.Count; }
        }

        // Indexer
        public Item this[int index]
        {
            get { return items[index]; }
            set { items.Add(value); }
        }
    }
}
