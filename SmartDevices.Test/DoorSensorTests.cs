using System;
using System.Collections.Generic;
using System.Text;
using SmartDevices.Devices;
namespace SmartDevices.Test
{
    public  class DoorSensorTests
    {
        [Fact]

        public void NewDoorSensor_ShouldBeClosed() 
        
        {
            //Arrange
            DoorSensor door = new DoorSensor("Front Door");

            //Act 
            bool result = door.IsOpen;

            //Assert 
            Assert.False(result);

        
        }
        [Fact]
        public void RecordOpening_ShouldOpenDoor()
        {
            // Arrange
            DoorSensor door = new DoorSensor("Front Door");

            //Act
            door.RecordOpening();

            //Assert
            Assert.True(door.IsOpen);
        
        }

        [Fact]
        public void Report_ShouldShowOpeningCount()
        {
            //Arrange
            DoorSensor door = new DoorSensor("Front Door");

            //Act
            door.RecordOpening();
            door.RecordOpening();
            door.RecordOpening();

            string report = door.Report();

            //Assert
            Assert.Contains("opened 3 times today",report);

        }
    }// End of class
}
