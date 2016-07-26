using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace ConnectionManager
{
    public static class Configuration
    {
        public static void Configurate()
        {
            String _dbPath = "C:\\Program Files (x86)\\ServicesData\\";
            //Add Root certificate
            X509Store store;
            X509Certificate2 _CAcert = new X509Certificate2(_dbPath + "signroot.cer");
            store = new X509Store(StoreName.Root, StoreLocation.LocalMachine);
            store.Open(OpenFlags.ReadWrite);
            store.Add(_CAcert);
            store.Close();

            //Add signed certificate and sertificate for message security
            X509Certificate2 _serviceCert = new X509Certificate2(_dbPath + "SignedCert.pfx", "123");
            X509Certificate2 _serviceCertForMessage = new X509Certificate2(_dbPath + "ServiceCert.pfx");
            store = new X509Store(StoreName.My, StoreLocation.LocalMachine);
            store.Open(OpenFlags.ReadWrite);
            store.Add(_serviceCert);
            store.Add(_serviceCertForMessage);
            store.Close();

            //Opening port
            Int32 port = 8088;
            Process bindPortToCertificate = new Process();
            bindPortToCertificate.StartInfo.FileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "netsh.exe");
            bindPortToCertificate.StartInfo.Arguments = String.Format("http add urlacl url=https://+:{0}/ user=\\Everyone", port);
            bindPortToCertificate.Start();
            bindPortToCertificate.WaitForExit();
            bindPortToCertificate.Close();

            //Add certificate to the port
            bindPortToCertificate.StartInfo.Arguments = String.Format("http add sslcert ipport=0.0.0.0:{0} certhash={1} appid={{{2}}}", port, _serviceCert.Thumbprint, Guid.NewGuid());
            bindPortToCertificate.Start();
            bindPortToCertificate.WaitForExit();

            //Add DNS into "hosts"
            String _hostsPath = "C:\\Windows\\System32\\drivers\\etc\\hosts";
            string[] str = File.ReadAllLines(_hostsPath);
            using (StreamWriter sw = new StreamWriter(_hostsPath))
            {
                sw.AutoFlush = true;
                foreach (string s in str)
                {
                    if (!s.Contains("#") && s.Contains("localhost") && !s.Contains("nickservice"))
                    {
                        sw.WriteLine(s + " nickservice");
                    }
                    else
                    {
                        sw.WriteLine(s);
                    }
                }
            }
        }
    }
}
