    public class Lock : IDevice
    {
        public bool IsLocked { get; private set; }

        public void TurnOn()
        {
            LockDoor();
        }

        public void TurnOff()
        {
            UnlockDoor();
        }

        public void LockDoor()
        {
            IsLocked = true;
            Console.WriteLine("Door is locked");
        }

        public void UnlockDoor()
        {
            IsLocked = false;
            Console.WriteLine("Door is unlocked");
        }
    }

