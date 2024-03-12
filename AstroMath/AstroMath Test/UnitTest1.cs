using AstroMath;

namespace AstroMath_Test
{
    [TestClass]
    public class UnitTest1
    {
        public StarCalculations starCalculations = new();

        [TestMethod]
        public void TestMethod1()
        {
            var tempKelvin = starCalculations.TemperatureK(27);
            var expectedOutput = 300;

            Assert.AreEqual(tempKelvin, expectedOutput);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var starCalc = Convert.ToInt32(starCalculations.StarVelocity(500.1, 500.0));
            var expectedOutput = 59958;

            Assert.AreEqual(starCalc, expectedOutput);
        }
        [TestMethod]
        public void TestMethod3()
        {
            var starDistance = starCalculations.StarDistance(0.547).ToString("0.##");
            var expectedOutput = "1.83";

            Assert.AreEqual(starDistance, expectedOutput );
        }
        [TestMethod]
        public void TestMethod4()
        {
            var eventHorizon = Convert.ToInt64( starCalculations.EventHorizon(8.2 * Math.Pow(10, 36)));
            var expectedOutput = 12178355418;

            Assert.AreEqual(eventHorizon, expectedOutput);
        }
    }
}