using System;

namespace Builder
{
    public class MotorCycleBuilder : VehicleBuilder
    {
        public MotorCycleBuilder()
        {
            vehicle = new Vehicle("MotorCycle");
        }

        public override VehicleBuilder BuildFrame()
        {
            vehicle["frame"] = "MotorCycle Frame";

            return this;
        }

        public override VehicleBuilder BuildEngine()
        {
            vehicle["engine"] = "500 cc";

            return this;
        }

        public override void BuildWheels()
        {
            vehicle["wheels"] = "2";
        }

        public override void BuildDoors()
        {
            vehicle["doors"] = "0";
        }
    }
}