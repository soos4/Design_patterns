using System;
namespace Builder
{
    public class TransportAdapter : Showable
    {
        private Transport transport;

        public TransportAdapter(Vehicle vehicle)
        {
            string type = vehicle.GetVehicleType();
            string frame = vehicle["frame"];
            string engine = vehicle["engine"];
            int doors = Int32.Parse(vehicle["doors"]);
            int wheels = Int32.Parse(vehicle["wheels"]);

            transport = new Transport(type, frame, engine, doors, wheels);
        }

        public void Show()
        {
            Console.WriteLine(transport.GetType());
            Console.WriteLine(transport.GetFrame());
            Console.WriteLine(transport.GetEngine());
            Console.WriteLine(transport.GetDoors());
            Console.WriteLine(transport.GetWheels());
        }
    }
}
