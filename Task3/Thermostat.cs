    public class Thermostat : IDevice
    {
        public bool IsOn { get; private set; }
        public double Temperature { get; private set; }

        public void TurnOn()
        {
            IsOn = true;
            Temperature = 22.0; 
            Console.WriteLine("Thermostat is turned on. Default temperature set to 22°C");
        }

        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine("Thermostat is turned off");
        }

        public void SetTemperature(double value)
        {
            if (IsOn)
            {
                Temperature = value;
                Console.WriteLine($"Thermostat temperature set to {Temperature}°C");
            }
            else
            {
                Console.WriteLine("Thermostat is off. Cannot change temperature.");
            }
        }
    }
