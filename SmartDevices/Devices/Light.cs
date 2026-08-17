using System;
using System.Collections.Generic;
using System.Text;

namespace SmartDevices.Devices
{
    public class Light : SwitchableDevice
    {

        public Light (string name ) : base (name)
        
        {
        
        }

        public override double RatedWatts => 9;

        public override string Report() {

            return $"{Name} | {Status} | {RatedWatts}W | {TotalKilowattHours:F3} KWh";


        }


    }// end of class

    
}
