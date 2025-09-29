    public class Lamp : IDevice
    {
        public bool IsOn { get; private set; }
        public int Brightness { get; private set; }

        public void TurnOn()
        {
            IsOn = true;
            Brightness = 50; 
            Console.WriteLine("Lamp is turned on at brightness 50%");
        }

        public void TurnOff()
        {
            IsOn = false;
            Brightness = 0;
            Console.WriteLine("Lamp is turned off");
        }

        public void SetBrightness(int value)
        {
            if (IsOn)
            {
                Brightness = Math.Clamp(value, 0, 100);
                Console.WriteLine($"Lamp brightness set to {Brightness}%");
            }
            else
            {
                Console.WriteLine("Lamp is off. Cannot change brightness.");
            }
        }
    }

