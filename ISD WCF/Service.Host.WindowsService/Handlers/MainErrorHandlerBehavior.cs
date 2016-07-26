using System.Collections.ObjectModel;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace Service.Host.WindowsService
{
    //Mechanism of functionality enhancement
    public class MainErrorHandlerBehavior : IServiceBehavior
    {
        private MainServiceHost _host;

        public MainErrorHandlerBehavior(MainServiceHost _host)
        {
            this._host = _host;
        }
        public void AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection bindingParameters)
        {
            //TODO: Add binding parametrs handler
        }

        //Сonnection extensions
        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
            MainErrorHandler _handler = new MainErrorHandler(_host);

            foreach(var item in serviceHostBase.ChannelDispatchers)
            {
                var _channelDispatcher = item as ChannelDispatcher;

                _channelDispatcher?.ErrorHandlers.Add(_handler);
            }
        }

        public void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
            //TODO: Validation of service parameters
        }
    }
}
