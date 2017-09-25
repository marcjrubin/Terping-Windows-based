using NUnit.Framework;
using InterpreterBookingSystem.Services.BusinessClientSvc;
using InterpreterBookingSystem.Domain.BusinessClients;

namespace InterpreterBookingSystemTest.BusinessClientSvcTest
{
    /// <summary>
    /// 
    /// </summary>
    class BusinessClientSvcTest
    {
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void StoreBusinessClientTest()
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

        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void GetBusinessClientTest()
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
            iBC.GetBusinessClient(bc);
            IBusinessClient actualBC = iBC; 

            Assert.AreEqual(iBC, actualBC);
        }
    }
}
