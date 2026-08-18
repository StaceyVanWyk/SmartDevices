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

        [Fact]
        public void Report_ShouldIncludeTemperatureInformation() 
        {

            // Arrange 
            Thermostat thermostat = new Thermostat("Living Room Thermostat");

       
            thermostat.SetTargetTemperature(21);

            //Act 
            string report = thermostat.Report();

            //Assert

            Assert.Contains("Living Room Thermostat", report);
            Assert.Contains("21", report);
        }

        [Fact]

        public void NewThermostat_ShouldHaveInitialTemperature()
        {

            //Arrange
            Thermostat thermostat = new Thermostat("Living Room Thermostat");


            //Act
            double target = thermostat.TargetTemperature;
            double current = thermostat.CurrentTemperature;

            //Assert
            Assert.Equal(21, target);
            Assert.Equal(20, current);
        }

        [Fact]

        public void SetTargetTemperature_ShouldUpdateTarget()
        {

            //Arrange
            Thermostat thermostat = new Thermostat("Living Room Thermostat");


            //Act 
            thermostat.SetTargetTemperature(21);
            thermostat.SetTargetTemperature(20);

        }

    }// End of Class
}
