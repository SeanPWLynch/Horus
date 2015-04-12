using HorusClient.HorusServerClient;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HorusClient
{

    class Program
    {

        public static HorusShared.ComputerObjects.Computer thisComputer;
        public static ServerClientServiceClient client;

        static void Main(string[] args)
        {
            ISchedulerFactory SchedulerFactory = new StdSchedulerFactory();
            IScheduler Scheduler = SchedulerFactory.GetScheduler();
            Scheduler.Start();



            thisComputer = new HorusShared.ComputerObjects.Computer();

            
            s_ClientHost ClientHost = new s_ClientHost();
            


            Thread t_ClientHost = new Thread(ClientHost.StartServce);
            t_ClientHost.Start();

            client = new ServerClientServiceClient();

            try
            {
                client.Endpoint.Address = new System.ServiceModel.EndpointAddress("net.tcp://"+Properties.Settings.Default.HorusServerAddress+":13000/ServerClientService/ServerClientService");

                client.Open();
                client.HandShake(Environment.MachineName);
                
                Console.WriteLine("Connected To Server On: " + Properties.Settings.Default.HorusServerAddress);

                IJobDetail job = JobBuilder.Create(typeof(ScheduledSendUpdate)).WithIdentity("MyJob", "MyJobGroup").Build();

                ITrigger trigger = TriggerBuilder.Create().WithSchedule(SimpleScheduleBuilder.RepeatSecondlyForTotalCount(10)).StartNow().WithIdentity("MyJobTrigger", "MyJobTriggerGroup").Build();
                Scheduler.ScheduleJob(job, trigger);


                //client.RecieveComputer(thisComputer.thisComputer); // For Testing


                Console.ReadLine();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}
