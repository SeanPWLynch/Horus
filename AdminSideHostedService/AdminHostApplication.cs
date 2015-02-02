using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description; 

namespace AdminSideHostedService
{
    class AdminHostApplication
    {
        static void Main(string[] args)
        {

            // Step 1 Create a URI to serve as the base address.
            //Need to update to Uri Array/List For Multiple Clients

            //Port 16000

            Uri AdminSideAddress = new Uri("net.tcp://localhost:16000/UserClientService/");

            // Step 2 Create a ServiceHost instance
            ServiceHost AdminSideHost = new ServiceHost(typeof(AdminClientService.AdminSideService), AdminSideAddress);
            try
            {
                // Step 3 Add a service endpoint.
                AdminSideHost.AddServiceEndpoint(typeof(AdminClientService.IAdminSideService), new NetTcpBinding(SecurityMode.None), "AdminClientService");

                // Step 4 Enable metadata exchange.
                ServiceMetadataBehavior AdminMetaBehaviour = new ServiceMetadataBehavior();
                AdminSideHost.Description.Behaviors.Add(AdminMetaBehaviour);

                // Step 5 Start the service.
                AdminSideHost.Open();
                Console.WriteLine("The services are ready.");
                Console.WriteLine("Admin: " + AdminSideHost.BaseAddresses[0]);
                Console.WriteLine();
                Console.WriteLine("Press <ENTER> to terminate service.");
                Console.WriteLine();
                Console.ReadLine();

                // Close the ServiceHostBase to shutdown the service.
                AdminSideHost.Close();
            }
            catch (Exception ce)
            {
                Console.WriteLine("An exception occurred: {0}", ce.Message);
                Console.ReadLine();
                AdminSideHost.Abort();
            }
        }
    }
}
