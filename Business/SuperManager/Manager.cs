using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterpreterBookingSystem.Services.ServiceFactory;
using InterpreterBookingSystem.Services.Service;

namespace InterpreterBookingSystem.Business.SuperManager
{
    public abstract class Manager
    {
        private ServiceFactory factory = ServiceFactory.GetInstance();

        protected IService GetService(String name)
        {
            return factory.GetService(name);
        }
    }
}
