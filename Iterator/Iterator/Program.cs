using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Collection collection = new Collection();
            for (int i = 0; i < 30; i++)
            {
                collection[i] = new Item($"element{i}");
            }

            AbstractIterator iterator = collection.CreateIterator();
            Item item;
            item = iterator.First();
            Console.WriteLine(item.Name);

            for (int i = 0; i < 10; i++)
            {
                item = iterator.Next();
                Console.WriteLine(item.Name);
            }

            iterator.Step = 2;

            for (int i = 0; i < 5; i++)
            {
                item = iterator.Next();
                Console.WriteLine(item.Name);
            }
        }
    }
}