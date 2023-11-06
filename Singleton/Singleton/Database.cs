using System;
using System.Collections.Generic;

namespace Singleton
{
    public class Database
    {
        private static Database instance = null;
        private static readonly object padlock = new object();

        private List<int> data;

        private Database()
        {
            data = new List<int>();
            for (int i = 0; i < 20; i += 2)
            {
                data.Add(i);
            }
        }

        public static Database GetInstance()
        {
            lock (padlock)
            {
                if (Database.instance == null)
                {
                    instance = new Database();
                }

                return instance;
            }
        }

        public List<int> GetAllData()
        {
            return data;
        }
    }
}