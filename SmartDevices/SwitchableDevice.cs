using SmartDevices.Devices;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartDevices
{
    public abstract class SwitchableDevice : Device
    {



        public SwitchableDevice(string name) : base(name)
        {

        }

        // Adding IsOn property

        public bool IsOn { get; private set; }




        // TurnOn changes IsOn and updates Status

        public void TurnOn()
        {

            IsOn = true;
            Status = "On";
        }

        public void TurnOff()
        {
            IsOn = false;
            Status = "Off";

        }

        // Toggle uses IsOn, TurnOn, TurnOff methods

        public void Toggle()
        {
            if (IsOn)
            {
                TurnOff();
            }
            else
            {
                TurnOn();
            }

        }


        public abstract double RatedWatts { get; }


        public double TotalKilowattHours { get; private set; }

        public void RecordHour()
        {
            if (IsOn)
            {

                TotalKilowattHours += RatedWatts / 1000;

            }
        }

    }


}