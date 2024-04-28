﻿using System.ServiceModel;

namespace ConsoleServer
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
