using System;
using System.Collections.Generic;

namespace Builder
{
    public class TransportDb
    {
        private List<Transport> db = new List<Transport>();

        public void Add(Transport transport)
        {
            db.Add(transport);
        }

        public List<Transport> GetAll()
        {
            return this.db;
        }

        public int GetSize()
        {
            return db.Count;
        }

        public Transport Get(int i)
        {
            if (i < db.Count)
            {
                return db[i];
            }

            return null;
        }
    }
}
