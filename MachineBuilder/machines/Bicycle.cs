using MachineBuilder.helpers;

namespace MachineBuilder.machines
{
    public class Bicycle : Vehicle
    {
        public Purpouse Purpouse { get; set; }
        public Bicycle(int purpouse, int wheels) : base(wheels)
        {
            Purpouse = (Purpouse) purpouse;
        }
    }
}
