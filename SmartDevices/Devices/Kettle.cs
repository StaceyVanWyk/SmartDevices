using System;
using System.Collections.Generic;
using System.Text;

namespace SmartDevices.Devices
{
    public class Kettle : SwitchableDevice
    {

        public Kettle(string name) : base(name)
        { 
        
        }

        public override double RatedWatts => 2200;


        public override string Report() {
            return $"{Name} | {Status} | {RatedWatts}W | {TotalKilowattHours:F3} kWh";


        }
    }//Ending of class
}
