using AstroMathFramework;
using System.ServiceModel;

namespace ConsoleServer
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    internal class AstroServer : IAstroContract
    {
        /*
         * 2.	Create the server file called “AstroServer.cs” which implements the IAstroContract. 
         * Add a new instance of the class library method and then create four methods with the suitable 
         * input parameters and return types.
         */

        readonly StarCalculations starCalculations = new StarCalculations();

        public double StarVelocity(double observed, double rest)
        {
            return starCalculations.StarVelocity(observed, rest);
        }

        public double StarDistance(double arcSecondsAngle)
        {
            return starCalculations.StarDistance(arcSecondsAngle);
        }
        public double TemperatureK(double celsius)
        {
            return starCalculations.TemperatureK(celsius);
        }

        public double EventHorizon(double mass)
        {
            return starCalculations.EventHorizon(mass);
        }
    }
}
