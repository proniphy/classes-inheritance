using System;
using MachineBuilder.helpers;

namespace MachineBuilder.machines
{
    public class Bicycle : Vehicle
    {
        public Purpose Purpose { get; private set; }
        public Bicycle(int purpose, int wheels) : base(wheels)
        {
            Purpose = (Purpose) purpose;
        }
        protected void Ride()
        {
            Console.WriteLine("Bicycle is running!");
        }
    }
}
