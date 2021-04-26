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
            
            var denisBike = myMachineBuilder.CreateMotorBike(1, 2, 2000, 600f, 4000);
            System.Console.WriteLine("Denis Info");
            denisBike.ForceEngine(2500);
            denisBike.Engine.ShowSerialNumber();
            denisBike.ForceEngine(8000);

            var iiiBike = myMachineBuilder.CreateMotorBike(5, 2, 1000, 140, 10000);
            iiiBike.TravelDistance(500);
        }
    }
}
