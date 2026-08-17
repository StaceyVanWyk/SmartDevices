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
            string status ;

            if (IsOpen)
            {
                status = "Open";
            }
            else
            {
                status = "Closed";
            }


            return $"{Name} | {status} | opened {openingCount} times today";
        }

        public bool IsOpen { get; private set; }

        // counter
        private int openingCount;

        public void RecordOpening() 
        {
            IsOpen = true;
            openingCount++;
        }

    }// End of class

}
