using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;
using Quartz.Impl;
using HorusClient.HorusServerClient;


namespace HorusClient
{
    class ScheduledSendUpdate :IJob
    {
        public void Execute(IJobExecutionContext context /*HorusShared.ComputerObjects.Computer ClientSystem, ServerClientServiceClient client*/)
        {
            JobDataMap dataMap = context.JobDetail.JobDataMap;



            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            Console.WriteLine("Sending Computer");
            Program.client.RecieveComputer(Program.thisComputer);
            Console.WriteLine("Computer Sent");
            sw.Stop();
            Console.WriteLine("Time Taken: " + sw.ElapsedMilliseconds + "ms");
        }
    }
}
            // Get an instance of the Quartz.Net scheduler

            // Define the Job to be scheduled

            // Associate a trigger with the Job

            // Assign the Job to the scheduler

          /*
             * 	class WriteToConsoleJob : IJob
	{
		public void Execute(IJobExecutionContext context)
		{
			Console.WriteLine("Execute method for job {0} in group {1} called at {2}", context.JobDetail.Key.Name, context.JobDetail.Key.Group, DateTime.Now);
			Console.WriteLine("Trigger {0} in group {1} was fired", context.Trigger.Key.Name, context.Trigger.Key.Group);
		}
	}
             * /

            //throw new NotImplementedException();
        }

    }
}
           * */
