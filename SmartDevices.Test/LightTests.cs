using SmartDevices.Devices;

namespace SmartDevices.Test
{
    public class LightTests
    {
        [Fact]
        public void NewLight_ShouldBeOff()
        {

            //Arrange

            Light light = new Light("Kitchen Light");

            //Act
            bool result = light.IsOn;

            //Assert 
            Assert.False(result);

        }


        [Fact]

        public void TurnOn_ShouldTurnLightOn()
       
        {
            // Arrange

            Light light = new Light("Kitchen Light");

            //Act
            light.TurnOn();

            //Assert
            Assert.True(light.IsOn);
            Assert.Equal("On", light.Status);
        
        }
        [Fact]

        public void TurnOff_ShouldTurnLightOff()
        
        { // Arrange
            Light light = new Light("Kitchen Light");

            // Act

            light.TurnOff();

            //Assert
            Assert.False(light.IsOn);
            Assert.Equal("Off", light.Status);
        
        }

        [Fact]

        public void Toggle_ShouldTurnLightOn_WhenLightIsOff() 
        
        {
            // Arrange
            Light light = new Light("Kitchen Light");

            //Act
            light.Toggle();

            //Assert
            Assert.True(light.IsOn);
            Assert.Equal("On", light.Status);
        
        }

        [Fact]

        public void Toggle_ShouldTurnLightOff_WhenLightIsOn() 
        
        {
            // Arrange
            Light light = new Light("Kitchen Light");
            light.TurnOn();

            //Act

            light.Toggle();

            //Assert
            Assert.False(light.IsOn);
            Assert.Equal("Off", light.Status);
        
        }

        [Fact]

        public void RecordHour_ShouldAddEngery_WhenLightIsOn()
        {

            // Arrange
            Light light = new Light("Kitchen Light");
            light.TurnOn();

            //Act
            light.RecordHour();

            //Assert
            Assert.Equal(0.009, light.TotalKilowattHours);

        
        }
        [Fact]
        public void RecordHour_ShouldAddNoEnegery_WhenLightIsOff()
        {
            //Arrange
            Light light = new Light("Kitchen Light");

            //Act

            light.RecordHour();

            //Assert
            Assert.Equal(0, light.TotalKilowattHours);
        }
    }//Ending of class
}
