using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Gift phone = new SingleGift("Phone", 256);
            phone.CalculateTotalPrice();
            Console.WriteLine();

            //composite gift
            GiftBox rootBox = new GiftBox("RootBox", 0);

            Gift truckToy = new SingleGift("TruckToy", 289);
            Gift plainToy = new SingleGift("PlainToy", 587);
            rootBox.Add(truckToy);
            rootBox.Add(plainToy);

            GiftBox childBox = new GiftBox("ChildBox", 0);

            Gift soldierToy = new SingleGift("SoldierToy", 200);
            childBox.Add(soldierToy);

            rootBox.Add(childBox);

            Console.WriteLine("Total price of this composite present is: " + rootBox.CalculateTotalPrice());
        }
    }
}
