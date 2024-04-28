using AstroMathFramework;
using System.ServiceModel;

namespace ConsoleServer
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    internal class AstroServer : IAstroContract
    {
        /// <summary>
        /// Creates an instance of the StarCalculations dll.
        /// </summary>
        readonly StarCalculations starCalculations = new StarCalculations();

        /// <summary>
        /// Calculates the velocity of a star based on observed and rest wavelengths.
        /// </summary>
        /// <param name="observed">The observed wavelength.</param>
        /// <param name="rest">The rest wavelength.</param>
        /// <returns>The velocity of the star.</returns>
        public double StarVelocity(double observed, double rest)
        {
            return starCalculations.StarVelocity(observed, rest);
        }
        /// <summary>
        /// Calculates the distance of a star based on arcSecondsAngle
        /// </summary>
        /// <param name="arcSecondsAngle">Angular measurement equal to 1/60 of one degree.</param>
        /// <returns>The distance from Earth</returns>
        public double StarDistance(double arcSecondsAngle)
        {
            return starCalculations.StarDistance(arcSecondsAngle);
        }
        /// <summary>
        /// Converts temperature from degrees celsius into kelvin.
        /// </summary>
        /// <param name="celsius">The temperature of the object in degrees Celsius.</param>
        /// <returns>The temperature in degrees Kelvin</returns>
        public double TemperatureK(double celsius)
        {
            return starCalculations.TemperatureK(celsius);
        }

        /// <summary>
        /// Distance from the centre of a blackhole to the event horizon 
        /// </summary>
        /// <param name="mass"></param>
        /// <returns>Schwarzschild radius in meters</returns>
        public double EventHorizon(double mass)
        {
            return starCalculations.EventHorizon(mass);
        }
    }
}
