using SmartDevices.Devices;

namespace SmartDevices
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Creating a list
            List<Device> devices = new List<Device>();

            Light light = new Light("Kitchen Light");
            Kettle kettle = new Kettle("Kettle");
            SecurityCamera camera = new SecurityCamera("Front camera");
            Thermostat thermostat = new Thermostat("Themostat");
            DoorSensor door = new DoorSensor("Front Door");

            devices.Add(light);
            devices.Add(kettle);
            devices.Add(camera);
            devices.Add(thermostat);
            devices.Add(door);

            light.TurnOn();
            camera.TurnOn();

        }
    }
}
