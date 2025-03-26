using MachineBuilder.parts;
using System;

namespace MachineBuilder.machines
{
    public class MotorBike : Bicycle
    {
        public const float speedConst = 0.5f;
        public Engine Engine { get; set; }
        public GearBox GearBox { get; private set; }
        public MotorBike(int purpose, int wheels) : base(purpose, wheels)
        {
            GearBox = new GearBox();
        }
        public MotorBike(int purpose, int wheels, int volume, float power, int maxRPM)
            : this(purpose, wheels)
        {
            Engine = new Engine(volume, power, maxRPM);
        }
        public bool ForceEngine(int rpm)
        {
            bool hasEngineFail = false;
            if (rpm > Engine.MaxRPM)
            {
                Console.WriteLine("Engine broke at {0} rpm!", rpm);
                hasEngineFail = true;
            }
            else
            {
                Console.WriteLine("Engine made some noise with {0}", rpm);
            }
            return hasEngineFail;
        }
        public static float CalculateSpeed(int rpm, int gear)
        {
            float speed = speedConst * rpm * gear;
            return speed;
        }
        public void RideBike()
        {
            this.Ride();
        }
    }
}
