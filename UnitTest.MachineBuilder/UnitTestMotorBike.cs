using Microsoft.VisualStudio.TestTools.UnitTesting;
using MachineBuilder;
using MachineBuilder.machines;
using MachineBuilder.helpers;

namespace UnitTest.MachineBuilder
{
    [TestClass]
    public class UnitTestMotorBike
    {
        // Initialization
        MachineConstructor vehicleBuilder = new MachineConstructor("Heavy Metal");

        [TestMethod]
        public void TestIfMotorBikeIsProperlyInitialized()
        {
            // Initialization
            MotorBike myMotor = vehicleBuilder.CreateMotorBike(2, 2, 150, 20f, 2000);

            // Assertion
            Assert.AreEqual(myMotor.Wheels, 2);
            Assert.AreEqual(myMotor.Purpouse, Purpouse.Travel);
            Assert.AreEqual(myMotor.Engine.Volume, 150f);
            Assert.AreEqual(myMotor.Engine.Power, 20f);
            Assert.AreEqual(myMotor.Engine.MaxRPM, 2000);
        }

        [TestMethod]
        public void TestIfMotorBikeMakeNoiseMethod()
        {
            // Initialization
            MotorBike myMotor = vehicleBuilder.CreateMotorBike(2, 2, 150, 20f, 2000);

            // Action
            bool isFailed = myMotor.ForceEngine(myMotor.Engine.MaxRPM + 1);

            // Assertion
            Assert.AreEqual(isFailed, true);
        }
    }
}
