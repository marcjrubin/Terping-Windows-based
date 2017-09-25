using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterpreterBookingSystem.Services.BusinessClientSvc;
using NUnit.Framework;
using InterpreterBookingSystem.Services.ServiceFactory;
using InterpreterBookingSystem.Domain.BusinessClients;
using InterpreterBookingSystem.Services.Service;

namespace InterpreterBookingSystemTest.ServiceFactoryTest
{
    /// <summary>
    /// Testing a refactored service factory 
    /// </summary>
    class ServiceFactoryTest
    {
        private ServiceFactory serviceFactory;

        [SetUp]
        public void BusinessClientSetUpTest()
        {
            serviceFactory = ServiceFactory.GetInstance();
        }

        [Test]
        public void FactoryTest()
        {
            IBusinessClient service;
            service = (IBusinessClient)serviceFactory.GetService(typeof(IBusinessClient).Name);

            Assert.IsInstanceOf(typeof(BusinessClientImpl), service, "Implementation null or wrong type");
        }
    }
}