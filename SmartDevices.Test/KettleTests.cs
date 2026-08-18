using System;
using System.Collections.Generic;
using System.Text;
using SmartDevices.Devices;

namespace SmartDevices.Test
{
    public class KettleTests
    {
        [Fact]

        public void Kettle_ShouldHave2200Watts() 
        
        {
            //Arrange

            Kettle kettle = new Kettle("Kitchen Kettle");

            // Act 
            double watts = kettle.RatedWatts;

            //Assert
            Assert.Equal(2200, watts);       
        }

        [Fact]

        public void RecordHour_ShouldAdd2200WattsOfEnergy_WhenKettleIsOn()
        
        { // Arrange
            Kettle kettle = new Kettle("Kitchen Kettle");
            kettle.TurnOn();

            //Act 
            kettle.RecordHour();

            // Assert
            Assert.Equal(2.2, kettle.TotalKilowattHours);

        
        }


        [Fact]

        public void NewKettle_ShouldBeOff()
        {
            // Arrange
            Kettle kettle = new Kettle("Kitchen Kettle");

            //Act

            bool result = kettle.IsOn;

            //Assert
            Assert.False(result);

        }

        [Fact]

        public void RecordHour_ShouldAddNoEnergy_WhenKettleIsOff()
        {
            //Arrange
            Kettle kettle = new Kettle("Kitchen Kettle");


            // Act
            kettle.RecordHour();

            //Assert
            Assert.Equal(0, kettle.TotalKilowattHours);
        
        }
    }// End of class
}
