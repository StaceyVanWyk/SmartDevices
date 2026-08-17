using System;
using System.Collections.Generic;
using System.Text;
using SmartDevices.Devices;

namespace SmartDevices.Test
{
    public class ThermostatTests
    {

        [Fact]
        public void SetTargetTemperatur_ShouldChangeTarget() 
        {
            // Arrange
            Thermostat thermostat = new Thermostat("Living Room Thernostat");

            // Act
            thermostat.SetTargetTemperature(21);

            // Assert
            Assert.Equal(21, thermostat.TargetTemperature);
        
        }


    }// End of Class
}
