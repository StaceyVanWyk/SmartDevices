using System;
using System.Collections.Generic;
using System.Text;

namespace SmartDevices.Devices
{
    public  class Thermostat : Device
    {

        public Thermostat(string name) : base(name) 
        {
            TargetTemperature = 21;
            CurrentTemperature = 20;
        }

        public double TargetTemperature { get; private set; }

        public double CurrentTemperature { get; private set; }


        public override string Report()
        { 
          return $"{Name} | Target: {TargetTemperature}°C | Current: {CurrentTemperature}°C";
        }


        public void SetTargetTemperature(double temperature)
        {
            TargetTemperature = temperature;

        
        }

       
    }//End of class
}
