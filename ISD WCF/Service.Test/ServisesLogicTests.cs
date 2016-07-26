using DomainModel;
using NUnit.Framework;
using System;

namespace Service.Test
{
    [TestFixture]
    public class ServisesLogicTests
    {
        Random _rnd;
        IMainService _service;

        [SetUp]
        public void Init()
        {
            _service = new MainService();
            _rnd = new Random();
        }

        [Test]
        [Repeat(1000)]
        public void Service_Summation_Test()
        {
            Int32 a = _rnd.Next(-1000, 1000);
            Int32 b = _rnd.Next(-1000, 1000);

            Assert.That(_service.Summ(a, b), Is.EqualTo(a + b));
        }
        [Test]
        public void Service_Connection_Test()
        {
            Assert.That(_service.IsConnected, Is.True);
        }
        [Test]
        public void Service_GetHuman_Test()
        {
            Human currentHuman;

            currentHuman = _service.GetHuman(1);

            Assert.That(currentHuman.Age, Is.EqualTo(32));
            Assert.That(currentHuman.Sex, Is.EqualTo("Male"));
            Assert.That(currentHuman.Name, Is.EqualTo("Indi"));
        }
        [Test]
        public void Service_GetIncorrectHuman_Test()
        {
            Human currentHuman;
            Boolean incorrectHuman;

            try
            {
                //incorrect humans' Id
                currentHuman = _service.GetHuman(7);
                incorrectHuman = true;
            }
            catch
            {
                incorrectHuman = false;
            }

            Assert.That(incorrectHuman, Is.False);
        }
        [Test]
        [Repeat(100)]
        public void Service_GetCar_Test()
        {
            Assert.That(_service.GetCar, Is.TypeOf(typeof(Car)));
        }
        [Test]
        public void Service_FaultLogin_Test()
        {
            Boolean autentification;

            //Incorrect login/pass
            autentification = AccountModel.Login("admin", "123");

            Assert.That(autentification, Is.False);
        }
        [Test]
        public void Service_SuccsessLogin_Test()
        {
            Boolean autentification;

            //Correct login/pass
            autentification = AccountModel.Login("admin", "admin");

            Assert.That(autentification, Is.True);
        }
    }
}
