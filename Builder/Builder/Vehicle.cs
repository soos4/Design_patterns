using System;
using System.Collections.Generic;

namespace Builder
{
    public class Vehicle : Showable
    {
        private string vehicleType;
        private Dictionary<string, string> parts = new Dictionary<string, string>();

        public Vehicle(string vehicleType)
        {
            this.vehicleType = vehicleType;
        }

        public string GetVehicleType()
        {
            return this.vehicleType;
        }

        public string this[string key]
        {
            get { return parts[key]; }
            set { parts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Vehicle Type: {0}", vehicleType);
            Console.WriteLine(" Frame : {0}", parts["frame"]);
            Console.WriteLine(" Engine : {0}", parts["engine"]);
            Console.WriteLine(" #Wheels: {0}", parts["wheels"]);
            Console.WriteLine(" #Doors : {0}", parts["doors"]);
        }
    }
}
