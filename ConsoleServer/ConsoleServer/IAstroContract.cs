using System.ServiceModel;

namespace ConsoleServer
{
    [ServiceContract]
    internal interface IAstroContract
    {
        /*
         * Create the server file called “AstroServer.cs” which implements the IAstroContract. 
         * Add a new instance of the class library method and then create four methods with the 
         * suitable input parameters and return types.
         */
        [OperationContract]
        double StarVelocity(double observed, double rest);

        [OperationContract]
        double StarDistance(double arcSecondsAngle);

        [OperationContract]
        double TemperatureK(double celsius);

        [OperationContract]
        double EventHorizon(double mass);

    }
}
