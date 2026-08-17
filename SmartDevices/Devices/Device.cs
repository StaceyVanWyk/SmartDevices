using System;
using System.Collections.Generic;
using System.Text;

namespace SmartDevices.Devices
{
    public abstract class Device
    {
        public string Name { get;  }

        public Device(string name) {

            Name = name;
        }

        public string Status {

            get;
            protected set;
        
        }


        public abstract string Report();
    }
}
