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

            var myAutomobile1 = myMachineBuilder.CreateAutomobile(200, 9100, 4);
            myAutomobile1.PricePerHorsePower(myAutomobile1.Price, myAutomobile1.Power);
            myAutomobile1.IsLowTax(myAutomobile1.Power);
        }
    }
}
