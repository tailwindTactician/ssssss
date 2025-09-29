             Lamp lamp = new Lamp();
            lamp.TurnOn();
            lamp.SetBrightness(80);
            lamp.TurnOff();

            Console.WriteLine();

           
            Thermostat thermostat = new Thermostat();
            thermostat.TurnOn();
            thermostat.SetTemperature(25.5);
            thermostat.TurnOff();

            Console.WriteLine();

            Lock smartLock = new Lock();
            smartLock.TurnOn();   
            smartLock.TurnOff();  