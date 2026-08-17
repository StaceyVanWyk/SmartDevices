using System;
using System.Collections.Generic;
using System.Text;


namespace SmartDevices.Devices
{
    public  class SecurityCamera : SwitchableDevice
    {

        public SecurityCamera(string name) : base(name) 
        
        {
        
        }

        public override double RatedWatts => 12;


        public override string Report()
        {
            return $"{Name} | {Status} | {RatedWatts}W | {TotalKilowattHours:F3} kWh";
        }
    }// End of Class
}
