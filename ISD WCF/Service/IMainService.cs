using DomainModel;
using System;
using System.ServiceModel;

namespace Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMainService" in both code and config file together.
    [ServiceContract]
    public interface IMainService
    {
        [OperationContract]
        Int32 Summ(Int32 a, Int32 b);
        [OperationContract]
        Boolean IsConnected();
        [OperationContract]
        Human GetHuman(Int32 Id);
        [OperationContract]
        Car GetCar();
    }
}
