using System;
using System.ServiceModel;


namespace Service.Host.Selfhost
{
    class Program
    {
        static void Main()
        {
            //Opening the selfhost
            Type serviceType = typeof(Service.MainService);
            ServiceHost host = new ServiceHost(serviceType);

            using (host)
            {
                host.Description.Behaviors.Add(new MainErrorHandlerBehavior());
                host.Open();

                Console.WriteLine("The service is available from {0} till now...", DateTime.Now);
                Console.WriteLine("Press any key to shutdown the host.");
                Console.ReadKey();
            }
        }
    }
}
