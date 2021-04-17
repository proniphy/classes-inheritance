using System;

namespace MachineBuilder.parts
{
    public class Engine
    {
        private Guid serialNumber;
        public int Volume { get; set; }
        public float Power { get; set; }
        public int MaxRPM { get; set; }
        public Engine(int volume, float power, int maxRPM)
        {
            Volume = volume;
            Power = power;
            MaxRPM = maxRPM;
            serialNumber = Guid.NewGuid();
        }

        private class SportEngine : Engine
        {
            public SportEngine(int volume, float power, int maxRPM) : base(volume, power, maxRPM)
            {
            }
        }
        public Guid ShowSerialNumber()
        {
            Console.WriteLine("Engine serial number: {0}", serialNumber);
            return serialNumber;
        }
    }
}
