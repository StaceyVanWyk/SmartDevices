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
        }g
    }// End of class
}
