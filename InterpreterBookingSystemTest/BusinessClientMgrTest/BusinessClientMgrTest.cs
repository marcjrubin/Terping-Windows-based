using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using InterpreterBookingSystem.Domain.BusinessClients;
using InterpreterBookingSystem.Services.BusinessClientSvc;


namespace InterpreterBookingSystemTest.BusinessClientMgrTest
{
    class BusinessClientMgrTest
    {
        [Test]
        public void BusinessClientMgrDomainTest()
        {
            BusinessClient bc = new BusinessClient();

            bc.CompanyName = "Google";
            bc.PointOfContact = "John Doe";
            bc.Address1 = "2342 Google Dr.";
            bc.Address2 = "Suite 2013";
            bc.City = "Mountain View";
            bc.State = "CA";
            bc.Zip = "93445";
            bc.Phone = "312-222-3244";
            bc.Email = "john.doe@google.com";

            IBusinessClient iBC = new BusinessClientImpl();
            iBC.StoreBusinessClient(bc);
        }

        [Test]
        public void BusinessClientFileTest()
        {
            string storageFile = Path.Combine(Environment.CurrentDirectory, "BusinessClient.bin");
            FileInfo storageFileInfo = new FileInfo(storageFile);

            Assert.IsTrue(storageFileInfo.Exists, "File not found");
            Assert.IsTrue(storageFileInfo.Length > 0, "File was empty");
        }
    }
}
