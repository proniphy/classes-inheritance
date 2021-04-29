using MachineBuilder.helpers;

namespace MachineBuilder.machines
{
    public class Bicycle : Vehicle
    {        
        public Purpouse Purpouse { get; set; }
        public int Gears { get; set; }
        public Bicycle(int purpouse, int wheels) : base(wheels)
        {
            Purpouse = (Purpouse) purpouse;
        }
        public Bicycle(int purpouse, int wheels, int gears):this(purpouse, wheels)
        {
            Gears = gears;
            System.Console.WriteLine("This new bicycle have {0} gears.", gears);
        }
    }
}
