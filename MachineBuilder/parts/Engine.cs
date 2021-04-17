namespace MachineBuilder.parts
{
    public class Engine
    {
        private int serialNumber;
        public int Volume { get; set; }
        public float Power { get; set; }
        public int MaxRPM { get; set; }
        public Engine(int volume, float power, int maxRPM)
        {
            Volume = volume;
            Power = power;
            MaxRPM = maxRPM;
        }

        private class SportEngine : Engine
        {
            public SportEngine(int volume, float power, int maxRPM) : base(volume, power, maxRPM)
            {
            }
        }
    }
}
