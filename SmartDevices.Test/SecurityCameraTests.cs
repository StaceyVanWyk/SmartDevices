using System;
using System.Collections.Generic;
using System.Text;
using SmartDevices.Devices;

namespace SmartDevices.Test
{
    public  class SecurityCameraTests
    {

        [Fact]
        public void SecurityCamera_ShouldHave12Watts()
        {
            //Arrange 
            SecurityCamera camera = new SecurityCamera("Front Camera");

            // Act
            double watts = camera.RatedWatts;

            //Assert
            Assert.Equal(12, watts);
        }

        [Fact]

        public void RecordHour_ShouldAddEnergy_WhenCameraIsOn()
        {
            //Arrange
            SecurityCamera camera = new SecurityCamera("Front Camera");
            camera.TurnOn();

            //Act
            camera.RecordHour();

            //Assert
            Assert.Equal(0.012, camera.TotalKilowattHours);
        
        }
    }// End of class
}
