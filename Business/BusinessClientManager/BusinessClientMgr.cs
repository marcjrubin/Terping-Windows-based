using System;
using InterpreterBookingSystem.Services.ServiceFactory;
using InterpreterBookingSystem.Services.BusinessClientSvc;
using InterpreterBookingSystem.Domain.BusinessClients;
using InterpreterBookingSystem.Exceptions.InterfaceException;
using InterpreterBookingSystem.Exceptions.ImplementationException;
using InterpreterBookingSystem.Business.SuperManager;

namespace InterpreterBookingSystem.Business.BusinessClientManager
{
    public class BusinessClientMgr : Manager
    {
        //ServiceFactory factory = ServiceFactory.GetInstance();

        public void StoreNewBusinessClient(BusinessClient bc)
        {
            try
            {
                IBusinessClient bcSvc = (IBusinessClient)GetService(typeof(IBusinessClient).Name);
                bcSvc.StoreBusinessClient(bc);
            }
            catch (InterfaceNotFoundException)
            {
                throw new Exception("Submission failed. Try again.");
            }
            
        }

        public BusinessClient RetrieveBusinessClient(BusinessClient bc)
        {
            try
            {
                IBusinessClient bcSvc = (IBusinessClient)GetService(typeof(IBusinessClient).Name);
                BusinessClient getBc = bcSvc.GetBusinessClient(bc);
                bc = getBc;
            }
            catch (ImplementationNotFoundException)
            {
                throw new Exception("Submission failed. Try again.");
            }

            return bc;
        }
    }
}
