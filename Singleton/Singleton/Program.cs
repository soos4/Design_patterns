using System;
using System.Collections.Generic;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Database db1 = Database.GetInstance();
            List<int> db1Data = db1.GetAllData();
            db1Data[5] = 9;
            foreach (int number in db1Data)
            {
                Console.WriteLine(number);
            }

            Database db2 = Database.GetInstance();
            List<int> db2Data = db2.GetAllData();
            //db2Data[5] = 9;
            foreach (int number in db2Data)
            {
                Console.WriteLine(number);
            }
        }
    }
}
