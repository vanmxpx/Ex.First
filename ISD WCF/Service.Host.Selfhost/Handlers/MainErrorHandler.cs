using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;

namespace Service.Host.Selfhost
{
    //Centralized exception handling witch creating new FaultException safelly for sessions
    public class MainErrorHandler : IErrorHandler
    {
        //Correct handling of exceptions on the service side
        public bool HandleError(Exception error)
        {
            Console.WriteLine(error.Message);
            return true;
        }
        //Collecting messages from exceptions
        public void ProvideFault(Exception error, MessageVersion version, ref Message fault)
        {
            if (error is FaultException)
                return;
            FaultException flt = new FaultException(error.Message, new FaultCode("InnerServiceException"));
            MessageFault msg = flt.CreateMessageFault();
            fault = Message.CreateMessage(version, msg, null);
        }
    }
}
