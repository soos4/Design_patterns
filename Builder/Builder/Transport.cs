using System;
namespace Builder
{
    public class Transport
    {
        private string type;
        private string frame;
        private string engine;
        private int doors;
        private int wheels;

        public Transport(string type, string frame, string engine, int doors, int wheels)
        {
            this.type = type;
            this.frame = frame;
            this.engine = engine;
            this.doors = doors;
            this.wheels = wheels;
        }

        public string GetType()
        {
            return this.type;
        }

        public string GetFrame()
        {
            return this.frame;
        }

        public string GetEngine()
        {
            return this.engine;
        }

        public int GetDoors()
        {
            return this.doors;
        }

        public int GetWheels()
        {
            return this.wheels;
        }
    }
}
