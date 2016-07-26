using System.ServiceProcess;
using System.ServiceModel;
using System.Diagnostics;
using System;

namespace Service.Host.WindowsService
{
    public partial class MainServiceHost : ServiceBase
    {
        private ServiceHost _host;
        private Type _serviceType;

        public MainServiceHost()
        {
            InitializeComponent();
            _serviceType = typeof(MainService);
            _host = new ServiceHost(_serviceType);
        }

        protected override void OnStart(string[] args)
        {
            _host.Description.Behaviors.Add(new MainErrorHandlerBehavior(this));
            _host.Open();
            AddLog("The service is available from "+ DateTime.Now + "till now...");
        }

        protected override void OnStop()
        {
            _host?.Close();
            AddLog("Host's closed.");
        }

        //Logging
        public void AddLog(string log)
        {
            try
            {
                if (!EventLog.SourceExists("MainService"))
                {
                    EventLog.CreateEventSource("MainService", "MainService");
                }
                eventLocalLog.Source = "MainService";
                eventLocalLog.WriteEntry(log);
            }
            catch { }
        }
    }
}

