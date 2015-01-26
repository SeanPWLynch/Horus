using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Description; 


namespace ServiceHostApplication
{
    class Application
    {
        static void Main(string[] args)
        {
            
            // Step 1 Create a URI to serve as the base address.
            //Need to update to Uri Array/List For Multiple Admins

            //Port 12000 = Admin Service For Incoming Commands
            //Port 13000 = Admin Service For Incoming Commands

            Uri AdminAddress = new Uri("net.tcp://localhost:12000/ServerAdminService/");

            // Step 2 Create a ServiceHost instance
            ServiceHost AdminHost = new ServiceHost(typeof(ServerAdminService.ServerAdminService), AdminAddress);

            try
            {
                // Step 3 Add a service endpoint.
                AdminHost.AddServiceEndpoint(typeof(ServerAdminService.IServerAdminService), new NetTcpBinding(SecurityMode.None), "ServerAdminService");


                // Step 4 Enable metadata exchange.
                ServiceMetadataBehavior AdminMetaBehaviour = new ServiceMetadataBehavior();
                AdminHost.Description.Behaviors.Add(AdminMetaBehaviour);

                // Step 5 Start the service.
                AdminHost.Open();
                Console.WriteLine("The service is ready.");
                Console.WriteLine(AdminHost.BaseAddresses[0]);
                
                Console.WriteLine();
                Console.WriteLine("Press <ENTER> to terminate service.");
                Console.WriteLine();
                Console.ReadLine();

                // Close the ServiceHostBase to shutdown the service.
                AdminHost.Close();
            }
            catch (Exception ce)
            {
                Console.WriteLine("An exception occurred: {0}", ce.Message);
                Console.ReadLine();
                AdminHost.Abort();
            }
        }
    }
}
