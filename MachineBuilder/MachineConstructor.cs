using MachineBuilder.helpers;
using MachineBuilder.machines;
using MachineBuilder.parts;

namespace MachineBuilder
{
    public class MachineConstructor
    {
        private string brand;
        public static int machineCounter = 0;
        public string Brand
        {
            get
            {
                return brand;
            }
            private set
            {
                Validator.ValidateString(value);
                brand = value;
            }
        }
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
    }
}
