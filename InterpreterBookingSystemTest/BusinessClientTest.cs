using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using InterpreterBookingSystem.Domain.BusinessClients;
using InterpreterBookingSystem.Domain.Assignment;

namespace InterpreterBookingSystemTest
{
    /// <summary>
    /// Testing the BusClient Class in the Domain Layer to validate the values that are not null and returns true
    /// </summary>
    class BusinessClientTest
    {
        [Test]
        public void ValidateBusinessClientTest()
        {
            BusinessClient client = new BusinessClient();

            client.CompanyName = "Google";
            client.PointOfContact = "Marissa Mayer";
            client.Address1 = "100 Google Way";
            client.Address2 = " ";
            client.City = "Mountain View";
            client.State = "CA";
            client.Zip = "95130";
            client.Phone = "510-234-5642";
            client.Email = "marissa.mayer@google.com";

            bool validate = client.ValidateBusinessClient();

            Assert.IsTrue(validate, "BusinessClient Validation Test Failed");            
        }
    }
}
