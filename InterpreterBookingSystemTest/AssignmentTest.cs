using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using InterpreterBookingSystem.Domain.Assignment;
using InterpreterBookingSystem.Domain.BusinessClients;
using InterpreterBookingSystem.Domain.Interpreters;
using InterpreterBookingSystem.Domain.DeafClients;

namespace InterpreterBookingSystemTest
{
    /// <summary>
    /// Validation: Testing the Assign Class in the Domain Layer to validate the values that are not null and returns true
    /// Collections/Interfaces: Testing to ensure the collections are equal and be able to pass it as parameter
    /// </summary>
    class AssignmentTest
    {
        [Test]
        public void ValidateAssignmentTest()
        {
            Assign work = new Assign();

            work.StartDate = "1/28/2016";
            work.EndDate = "1/29/2017";
            work.StartTime = "12:00 PM";
            work.EndTime = "3:00 PM";

            bool validate = work.ValidateAssignment();

            Assert.IsTrue(validate, "Assignment Validation Test Failed");
        }

        [Test]
        public void AddBusinessClientTest()
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

            Assign obj = new Assign();
            obj.AddBusinessClient(client);
            BusinessClient actualClient = client;
            Assert.AreEqual(client, actualClient);
        }

        [Test]
        public void RemoveBusinessClientTest()
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

            Assign obj = new Assign();
            obj.RemoveBusinessClient(client);
            BusinessClient actualClient = client;
            Assert.AreEqual(client, actualClient);
        }

        [Test]
        public void AddInterpreterTest()
        {
            Interpreter terp = new Interpreter();

            terp.Name = "Monica Romney";
            terp.Address1 = "100 West Ave";
            terp.Address2 = "Apt. 110";
            terp.City = "Louisville";
            terp.State = "KY";
            terp.Zip = "47384";
            terp.Phone = "502-234-5564";
            terp.Email = "monica@interpreter.com";
            terp.YearsOfExperience = 10;
            terp.HighestLevelCertification = "RID III";

            Assign obj = new Assign();
            obj.AddInterpreter(terp);
            Interpreter actualTerp = terp;
            Assert.AreEqual(terp, actualTerp);
        }

        [Test]
        public void RemoveInterpreterTest()
        {
            Interpreter terp = new Interpreter();

            terp.Name = "Monica Romney";
            terp.Address1 = "100 West Ave";
            terp.Address2 = "Apt. 110";
            terp.City = "Louisville";
            terp.State = "KY";
            terp.Zip = "47384";
            terp.Phone = "502-234-5564";
            terp.Email = "monica@interpreter.com";
            terp.YearsOfExperience = 10;
            terp.HighestLevelCertification = "RID III";

            Assign obj = new Assign();
            obj.AddInterpreter(terp);
            Interpreter actualTerp = terp;
            Assert.AreEqual(terp, actualTerp);
        }

        [Test]
        public void AddDeafClientTest()
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

            Assign obj = new Assign();
            obj.AddDeafClient(dc);
            DeafClient actualDC = dc;
            Assert.AreEqual(dc, actualDC);
        }

        [Test]
        public void RemoveDeafClientTest()
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

            Assign obj = new Assign();
            obj.RemoveDeafClient(dc);
            DeafClient actualDC = dc;
            Assert.AreEqual(dc, actualDC);
        }
    }
}
