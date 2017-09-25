using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterBookingSystem.Exceptions.InterfaceException
{
    public class InterfaceNotFoundException : Exception
    {
        public InterfaceNotFoundException(String e) : base(e)
        {
            
        }
    }
}
