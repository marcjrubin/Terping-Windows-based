using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterpreterBookingSystem.Domain.Interpreters;
using InterpreterBookingSystem.Services.Service;

namespace InterpreterBookingSystem.Services.InterpreterSvc
{
    public interface IInterpreter : IService
    {
        void StoreInterpreter(Interpreter terp);

        Interpreter GetInterpreter(Interpreter terp);
    }
}
