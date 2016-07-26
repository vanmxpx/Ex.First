using System;
using System.ServiceModel;
using System.Xml.Linq;
using System.Linq;
using DomainModel;
using static System.ServiceModel.InstanceContextMode;
using System.Configuration;

namespace Service
{
    //service instance for each session with a single thread
    [ServiceBehavior(InstanceContextMode = PerSession, ConcurrencyMode = ConcurrencyMode.Single)]
    public class MainService : IMainService
    {
        Random rnd = new Random();

        #region Contracts' methods
        public Int32 Summ(Int32 a, Int32 b)
        {
            return a + b;
        }
        public Boolean IsConnected()
        {
            return true;
        }
        public Human GetHuman(Int32 Id)
        {
            Human currentHuman = new Human();

            var file = ConfigurationManager.AppSettings["fileHumans"];
            var doc = XDocument.Load(file);
            var element = doc.Descendants("Human").FirstOrDefault(x => x.Attribute("Id").Value == Id.ToString());

            currentHuman.Name = element.Element("Name").Value;
            currentHuman.Age = Int32.Parse(element.Element("Age").Value);
            currentHuman.Sex = element.Element("Sex").Value;

            return currentHuman;
        }
        public Car GetCar()
        {
            return (Car)rnd.Next(0, 4);
        }
        #endregion
    }
}
