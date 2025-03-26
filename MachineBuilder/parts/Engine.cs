using System;

namespace MachineBuilder.parts
{
    public class Engine
    {
        private Guid SerialNumber { get; set; }
        public int Volume { get; private set; }
        public float Power { get; private set; }
        public int MaxRPM { get; private set; }
        public bool Turbo { get; private set; }
        public Engine(int volume, float power, int maxRPM)
        {
            Volume = volume;
            Power = power;
            MaxRPM = maxRPM;
            SerialNumber = Guid.NewGuid();
        }
        public Engine(int volume, float power, int maxRPM, bool turbo) : this(volume, power, maxRPM)
        {
            Turbo = turbo;
        }

        public Guid ShowSerialNumber()
        {
            Console.WriteLine("Engine serial number: {0}", SerialNumber);
            return SerialNumber;
        }
    }
}
