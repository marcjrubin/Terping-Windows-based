using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterpreterBookingSystem.Business.SuperManager;
using InterpreterBookingSystem.Domain.Interpreters;
using InterpreterBookingSystem.Exceptions.ImplementationException;
using InterpreterBookingSystem.Exceptions.InterfaceException;
using InterpreterBookingSystem.Services.BusinessClientSvc;
using InterpreterBookingSystem.Services.InterpreterSvc;

namespace InterpreterBookingSystem.Business.InterpreterMgr
{
    public class InterpreterMgr : Manager
    {
        public void StoreNewInterpreter(Interpreter terp)
        {
            try
            {
                IInterpreter terps = (IInterpreter)GetService(typeof(IInterpreter).Name);
                terps.StoreInterpreter(terp);
            }
            catch (InterfaceNotFoundException)
            {
                throw new Exception("Submission failed. Try again.");
            }
        }

        public Interpreter RetrieveInterpreter(Interpreter terp)
        {
            try
            {
                IInterpreter terps = (IInterpreter)GetService(typeof(IInterpreter).Name);
                Interpreter getTerp = terps.GetInterpreter(terp);
                terp = getTerp;
            }
            catch (ImplementationNotFoundException)
            {
                throw new Exception("Submission failed. Try again.");
            }

            return terp;
        }
    }
}
