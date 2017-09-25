using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterBookingSystem.Exceptions.ImplementationException
{
    public class ImplementationNotFoundException : Exception
    {
        public ImplementationNotFoundException(String e) : base(e)
        {
            
        }
    }
}
