using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterpreterBookingSystem.Domain.DeafClients;
using NUnit.Framework;

namespace InterpreterBookingSystemTest
{
    /// <summary>
    /// Unit Testing DeafClient class for validation
    /// </summary>
    class DeafClientTest
    {
        [Test]
        public void ValidateDeafClientTest()
        {
            DeafClient dc = new DeafClient();

            dc.Name = "Marc Rubin";
            dc.Gender = "Male";
            dc.SigningPreference = "PSE";

            List<string> interpreterList = new List<string>();
            interpreterList.Add("Monica Romney");
            interpreterList.Add("Dan Flanigan");
            interpreterList.Add("Michelle Rubin");
            interpreterList.Add("Trent Clifton");

            dc.ListOFInterpreterPreference = interpreterList;

            bool validate = dc.ValidateDeafClient();

            Assert.IsTrue(validate, "DeafClient Validation Test Failed");             
        }
    }
}
