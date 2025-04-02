using MachineBuilder.machines;
using MachineBuilder.parts;

namespace MachineBuilder
{
    public class MachineConstructor
    {
        public int MachineCounter { get; private set; }
        public string Brand { get; private set; }
        public MachineConstructor(string brand)
        {
            Brand = brand;
            MachineCounter = 0;
        }

        public MotorBike CreateMotorBike(int purpose, int wheels, int volume, float power, int maxRPM)
        {
            MotorBike myBike = new MotorBike(purpose, wheels);
            myBike.Engine = new Engine(volume, power, maxRPM);
            MachineCounter++;

            return myBike;
        }
    }
}
