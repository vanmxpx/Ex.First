using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;

namespace Service.Host.WindowsService
{
    //Centralized exception handling witch creating new FaultException safelly for sessions
    public class MainErrorHandler : IErrorHandler
    {
        private MainServiceHost _host;

        public MainErrorHandler(MainServiceHost _host)
        {
            this._host = _host;
        }
            //Correct handling of exceptions on the service side
        public bool HandleError(Exception error)
        {
            _host.AddLog(error.Message);
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
