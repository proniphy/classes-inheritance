namespace MachineBuilder
{
    class MachineFactory
    {
        static void Main(string[] args)
        {
            MachineConstructor mySteelMachinesBuilder = new MachineConstructor("Steel Machines");
            var myBike = mySteelMachinesBuilder.CreateMotorBike(2, 2, 200, 300f, 2000);
            myBike.ForceEngine(2001);
            myBike.RideBike();
            myBike.Engine.ShowSerialNumber();
            myBike.ForceEngine(1500);

            var denisBike = mySteelMachinesBuilder.CreateMotorBike(1, 2, 2000, 600f, 4000);
            System.Console.WriteLine("Denis Info");
            denisBike.ForceEngine(2500);
            denisBike.Engine.ShowSerialNumber();
            denisBike.ForceEngine(8000);

            System.Console.WriteLine($"\nTotal machines built: {mySteelMachinesBuilder.MachineCounter}");
        }
    }
}
