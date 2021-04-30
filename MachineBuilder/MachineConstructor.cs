using MachineBuilder.machines;
using MachineBuilder.parts;

namespace MachineBuilder
{
    public class MachineConstructor
    {
        public static int machineCounter = 0;
        public string Brand { get; set; }
        public MachineConstructor(string brand)
        {
            Brand = brand;
        }

        public MotorBike CreateMotorBike(int purpouse, int wheels, int volume, float power, int maxRPM)
        {
            MotorBike myBike = new MotorBike(purpouse, wheels);
            myBike.Engine = new Engine(volume, power, maxRPM);

            return myBike;
        }

        public Automobile CreateAutomobile(int power, int price, int wheels)
        {
            Automobile myAutomobile = new Automobile(power, price, wheels);
            return myAutomobile;
        }
    }
}
