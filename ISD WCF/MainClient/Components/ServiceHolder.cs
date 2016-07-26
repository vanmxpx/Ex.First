using System;
using System.IO;
using System.ServiceModel;

namespace MainClient
{
    public static class ServiceClient
    {
        // Static class stores a single ServiceClient for all session.
        #region Fields
        public static Service.MainServiceClient _serviceClient;
        private static EndpointAddress _endpointAddress;
        private static String _remoteAddress;
        public static ConnectionType Connection { get; set; }
        public static String RemoteAddress
        {
            get
            {
                return _remoteAddress;
            }
            set
            {
                SaveAdressInFile(value);
                _remoteAddress = value;
            }
        }
        public static Service.MainServiceClient GetServiceClient
        {
            get
            {
                if (_serviceClient == null ||
                        _serviceClient.State == CommunicationState.Faulted)
                {
                    SetConnection();
                }
                return _serviceClient;
            }
        }
        #endregion
        private static void SetConnection()
        {
            //Creating new client if it's first connection or session was fault
            switch (Connection)
            {
                case ConnectionType.WSHttpBinding_Message:
                    EndpointIdentity identity = EndpointIdentity.CreateDnsIdentity("ServiceCert");
                    _endpointAddress = new EndpointAddress(new Uri(RemoteAddress), identity);
                    _serviceClient = new Service.MainServiceClient(Connection.ToString(), _endpointAddress);
                    break;
                default:
                    _endpointAddress = new EndpointAddress(new Uri(RemoteAddress));
                    _serviceClient = new Service.MainServiceClient(Connection.ToString(), _endpointAddress);
                    break;
            }
        }
        static ServiceClient()
        {
                using (StreamReader file =
                        new StreamReader(@"HostIp.txt"))
                {
                    _remoteAddress = file.ReadLine();
                }
        }
        private static void SaveAdressInFile(String newAddress)
        {
            String str = String.Empty;
            using (StreamReader reader = File.OpenText(@"HostIp.txt"))
            {
                str = reader.ReadToEnd();
            }

            str = str.Replace(RemoteAddress, newAddress);

            using (StreamWriter file = new StreamWriter(@"HostIp.txt"))
            {
                file.Write(str);
            }
        }
    }
}

