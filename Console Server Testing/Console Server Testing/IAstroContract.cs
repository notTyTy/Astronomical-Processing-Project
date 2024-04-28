using System.ServiceModel;

namespace Console_Server_Testing
{
    [ServiceContract]
    internal interface IAstroContract
    {
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
