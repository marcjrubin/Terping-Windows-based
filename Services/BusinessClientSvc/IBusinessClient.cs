using InterpreterBookingSystem.Domain.BusinessClients;
using InterpreterBookingSystem.Services.Service;

namespace InterpreterBookingSystem.Services.BusinessClientSvc
{
    /// <summary>
    /// 
    /// </summary>
    public interface IBusinessClient : IService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bc"></param>
        void StoreBusinessClient(BusinessClient bc);

        BusinessClient GetBusinessClient(BusinessClient bc);
    }
}
