using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroMathFramework
{
    public class StarCalculations
    {
        static readonly int c = 299792458;
        /*
         * Star Velocity: Create a method to measure the Star velocity using the Doppler shift,
         * it should have two input parameters of type double (Observed Wavelength and Rest Wavelength)
         * and return a double which represents the velocity.
        */
        public double StarVelocity(double observed, double rest)
        {
            double deltaWavelength = observed - rest;
            double velocity = c * (deltaWavelength / rest);

            return velocity;
        }
        /*
         * Star Distance: Create a method to measure the star distance using the parallax angle, 
         * it should have a single input parameter of type double (Arcseconds angle) and return a double. 
         * The parallax angle is measured at two different points and works on nearby stars. 
         * The method must return a double which is a value in parsecs.
         */
        public double StarDistance(double arcSecondsAngle)
        {
            double distance = 1 / arcSecondsAngle;
            return distance;
        }
        /*
        * Temperature in Kelvin: The Kelvin temperature scale is the primary temperature 
        * used in science and is easily converted from Celsius. Create a method that has a single 
        * input parameter of type double (temperature in Celsius) and returns a double which is the 
        * temperature in degrees kelvin. 
        */
        public double TemperatureK(double celsius)
        {
            double kelvin = 273 + celsius;
            return kelvin;
        }
        /*
         * Event Horizon (Schwarzschild Radius): Create a method that will return the distance 
         * from the centre of a blackhole to the event horizon. The method must have a single 
         * input parameter of type double (Blackhole Mass) and return a double which is the event 
         * horizon in metres.
         */
        public double EventHorizon(double mass)
        {
            double gravityConst = 6.674 * Math.Pow(10, -11);
            double radius = (2 * gravityConst * mass) / Math.Pow(c, 2);
            return radius;
        }
    }
}
