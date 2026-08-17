using System;
using System.Collections.Generic;
using System.Text;

namespace SmartDevices.Devices
{
    public class DoorSensor : Device

    {

        public DoorSensor(string name) : base(name) {
        }

        public override string Report()
        {
            return "";
        }

        public bool IsOpen { get; private set; }

        // counter
        private int openingCount;

    }// End of class

}
