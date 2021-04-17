using MachineBuilder.helpers;

namespace MachineBuilder.machines
{
    public class Vehicle
    {
        private int wheels;
        public int Wheels
        {
            get
            {
                return wheels;
            }
            private set
            {
                Validator.ValidateIfPositive(value);
                wheels = value;
            }
        }

        public Vehicle(int wheels)
        {
            Wheels = wheels;
        }
    }
}
