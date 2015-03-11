using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceProcess;

namespace HorusShared.ComputerObjects
{


    public class Services
    {
        private ServiceController[] SystemServices;

        public Services()
        {
            SystemServices = ServiceController.GetServices();
        }

        public void UpdateServices()
        {
            SystemServices = ServiceController.GetServices();
        }

        public void StartService(string serviceName)
        {
              ServiceController service = new ServiceController(serviceName);
              try
              {
                    service.Start();
              }
              catch(Exception e)
              {
                Console.WriteLine(e.Message);
              }
        }

        public void StopService(string serviceName)
        {
            ServiceController service = new ServiceController(serviceName);
            try
            {
                service.Stop();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


    }
}
