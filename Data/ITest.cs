
using System;
using System.ServiceModel;

namespace Data
{
    [ServiceContract]
    public interface ITest
    {
        [OperationContract]
        DateTime GetServerTime();
    }
}
