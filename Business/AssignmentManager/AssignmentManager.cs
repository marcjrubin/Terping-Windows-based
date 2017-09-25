using System;
using InterpreterBookingSystem.Services.ServiceFactory;
using InterpreterBookingSystem.Domain.Assignment;
using InterpreterBookingSystem.Exceptions.InterfaceException;
using InterpreterBookingSystem.Exceptions.ImplementationException;
using InterpreterBookingSystem.Business.SuperManager;
using InterpreterBookingSystem.Services.AssignmentSvc;

namespace InterpreterBookingSystem.Business.AssignmentManager
{
    public class AssignmentManager : Manager
    {
        public void StoreNewAssignment(Assign assign)
        {
            try
            {
                IAssignment asgn = (IAssignment)GetService(typeof(IAssignment).Name);
                asgn.StoreAssignment(assign);
            }
            catch (InterfaceNotFoundException)
            {
                throw new Exception("Submission failed. Try again.");
            }
        }

        public Assign RetrieveAsssignment(Assign assign)
        {
            try
            {
                IAssignment asgn = (IAssignment) GetService(typeof(IAssignment).Name);
                Assign getAssign = asgn.GetAssignment(assign);
                assign = getAssign;
            }
            catch (ImplementationNotFoundException)
            {
                throw new Exception("Submission failed. Try again.");
            }

            return assign;
        }
    }
}
