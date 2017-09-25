using System;
using System.Configuration;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterpreterBookingSystem.Services.BusinessClientSvc;
using InterpreterBookingSystem.Services.Service;

namespace InterpreterBookingSystem.Services.ServiceFactory
{
    /// <summary>
    /// 
    /// </summary>
    public class ServiceFactory : Exception
    {
        private ServiceFactory() { }
        
        private static ServiceFactory factory = new ServiceFactory();

        public static ServiceFactory GetInstance() { return factory; }

        public IService GetService(String serviceName)
        {
            Type type;
            Object obj = null;

            try
            {
                type = Type.GetType(GetImplName(serviceName));
                obj = Activator.CreateInstance(type);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
            }

            return (IService)obj;
        }

        private string GetImplName(string servicename)
        {
            NameValueCollection settings = ConfigurationManager.AppSettings;
            return settings.Get(servicename);
        }
    }
}
