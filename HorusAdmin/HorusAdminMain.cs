using HorusAdmin.Horus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorusAdmin
{
    public partial class HorusAdminMain : Form
    {
        public HorusAdminMain()
        {
            InitializeComponent();
            ServerAdminServiceClient AdminClient = new ServerAdminServiceClient();
            //net.tcp://localhost:12000/ServerAdminService/ServerAdminService/
            AdminClient.Endpoint.Address = new System.ServiceModel.EndpointAddress("net.tcp://" + Properties.Settings.Default.HorusServerAddress + ":12000/ServerAdminService/ServerAdminService/");
            

            AdminClient.Open();



            
            string[] HorusClientsOnline = AdminClient.GetClients();

            

            
        }

        public void StartAdminClient()
        {
            
        }



    }
}
