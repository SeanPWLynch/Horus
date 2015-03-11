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


    }
}
