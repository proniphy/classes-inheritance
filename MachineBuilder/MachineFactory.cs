namespace MachineBuilder
{
    class MachineFactory
    {
        static void Main(string[] args)
        {
            MachineConstructor myMachineBuilder = new MachineConstructor("Steel Machines");
            var myBike = myMachineBuilder.CreateMotorBike(2, 2, 200, 300f, 2000);
            myBike.ForceEngine(2001);
            myBike.Engine.ShowSerialNumber();
            myBike.ForceEngine(1500);
        }
    }
}
