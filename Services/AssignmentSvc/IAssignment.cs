using InterpreterBookingSystem.Services.Service;
using InterpreterBookingSystem.Domain.Assignment;

namespace InterpreterBookingSystem.Services.AssignmentSvc
{
    /// <summary>
    /// 
    /// </summary>
    public interface IAssignment : IService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="assign"></param>
        void StoreAssignment(Assign assign);

        Assign GetAssignment(Assign assign);
    }
}
