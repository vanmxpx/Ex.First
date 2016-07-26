using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Service.Settings.Installer
{
    partial class CostumeInstaller
    {
        public override void Uninstall(IDictionary savedState)
        {
            base.Uninstall(savedState);
            X509Store store;
            String _globalPath = "C:\\Program Files (x86)\\ServicesData\\";
            //Remove signed certificate and sertificate for message security
            X509Certificate2 _serviceCert = new X509Certificate2(_globalPath + "SignedCert.pfx", "123");
            X509Certificate2 _serviceCertForMessage = new X509Certificate2(_globalPath + "ServiceCert.pfx");
            store = new X509Store(StoreName.My, StoreLocation.LocalMachine);
            store.Open(OpenFlags.ReadWrite);
            store.Remove(_serviceCert);
            store.Remove(_serviceCertForMessage);
            store.Close();

            //Remove Root certificate
            X509Certificate2 _CAcert = new X509Certificate2(_globalPath + "signroot.cer");
            store = new X509Store(StoreName.Root, StoreLocation.LocalMachine);
            store.Open(OpenFlags.ReadWrite);
            store.Remove(_CAcert);
            store.Close();

            //Closing port
            Int32 port = 8088;
            Process bindPortToCertificate = new Process();
            bindPortToCertificate.StartInfo.FileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "netsh.exe");
            bindPortToCertificate.StartInfo.Arguments = String.Format("http delete sslcert ipport = 0.0.0.0:{0}", port);
            bindPortToCertificate.Start();
            bindPortToCertificate.WaitForExit();
            bindPortToCertificate.Close();

            //Delete certificate to the port
            bindPortToCertificate.StartInfo.Arguments = String.Format("http delete urlacl url=https://+:{0}/", port);
            bindPortToCertificate.Start();
            bindPortToCertificate.WaitForExit();

            //Delete DNS into "hosts"
            String _hostsPath = "C:\\Windows\\System32\\drivers\\etc\\hosts";
            string[] str = File.ReadAllLines(_hostsPath);
            using (StreamWriter sw = new StreamWriter(_hostsPath))
            {
                sw.AutoFlush = true;
                foreach (string s in str)
                {
                    if (!s.Contains("#") && s.Contains("localhost") && s.Contains("nickservice"))
                    {
                        sw.WriteLine("127.0.0.1       localhost");
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
