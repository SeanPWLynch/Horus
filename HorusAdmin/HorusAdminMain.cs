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
using HorusShared;
using HorusShared.ComputerObjects;
using System.Diagnostics;

namespace HorusAdmin
{
    public partial class HorusAdminMain : Form
    {
        public static List<HorusShared.ComputerObjects.Computer> HorusClientsOnline = new List<HorusShared.ComputerObjects.Computer>();
        public static ServerAdminServiceClient AdminClient = new ServerAdminServiceClient();
        public static DataTable ProcessDataTable;
        public static DataTable ServiceDataTable;
        List<string> ProcNames;

        public HorusAdminMain()
        {
            InitializeComponent();
            AdminClient.Endpoint.Address = new System.ServiceModel.EndpointAddress("net.tcp://" + Properties.Settings.Default.HorusServerAddress + ":12000/ServerAdminService/ServerAdminService/");
            AdminClient.Open();
            ListViewItem updatingAlert = new ListViewItem("Clients Updating");
            updatingAlert.SubItems.Add("Clients Updating");
            updatingAlert.SubItems.Add("Clients Updating");
            updatingAlert.SubItems.Add("Clients Updating");
            lstViewHorusOnlineClients.Items.Add(updatingAlert);
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                GetHorusOnlineClients();
            }).Start();

            lstViewHorusOnlineClients.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lstViewHorusOnlineClients.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            ProcessDataTable = new DataTable("Processes");

            ProcessDataTable.Columns.Add("Process ID", typeof(int));
            ProcessDataTable.Columns.Add("Process Name", typeof(string));
            ProcessDataTable.Columns.Add("Memory", typeof(int));
            ProcessDataTable.Columns.Add("Thread Count", typeof(int));

            
           
            //net.tcp://localhost:12000/ServerAdminService/ServerAdminService/


        }

        public void StartAdminClient()
        {

        }

        delegate void UpdateOnlineClientsListViewCallBack();
        public void GetHorusOnlineClients()
        {
            UpdateOnlineClientsProgressBar(true);
            string[] knownClients = AdminClient.GetClients();
            try
            {

                foreach (string horusClient in knownClients)
                {
                    new Thread(() =>
                    {
                        Thread.CurrentThread.IsBackground = true;
                        try
                        {
                            HorusShared.ComputerObjects.Computer newClient = AdminClient.GetComputer(horusClient);
                            HorusClientsOnline.Add(newClient);
                        }
                        catch(Exception e)
                        {

                        }
                    }).Start();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            while(HorusClientsOnline.Count < knownClients.Length)
            {

            }

            UpdateOnlineClientsListView();
            

            //Thread.Sleep(20000);

        }


        public void UpdateOnlineClientsListView()
        {

            if (this.lstViewHorusOnlineClients.InvokeRequired)
            {
                UpdateOnlineClientsListViewCallBack d = new UpdateOnlineClientsListViewCallBack(UpdateOnlineClientsListView);
                this.Invoke(d, new object[] { });
            }

            try
            {
                lstViewHorusOnlineClients.Items.Clear();

                foreach (Computer client in HorusClientsOnline)
                {
                    ListViewItem clientForList = new ListViewItem(client.HostName);
                    clientForList.SubItems.Add(client.UserName);
                    clientForList.SubItems.Add(client.SystemUpTime.Hours.ToString() + ":" + client.SystemUpTime.Minutes.ToString() + ":" + client.SystemUpTime.Seconds.ToString());
                    lstViewHorusOnlineClients.Items.Add(clientForList);
                }
                UpdateOnlineClientsProgressBar(false);

            }
            catch(Exception e)
            {
                //MessageBox.Show(e.Message);
            }
            
        }

        delegate void ProgressBarCallback(bool start);
        public void UpdateOnlineClientsProgressBar(bool start)
        {
            if (this.pbOnlineClients.InvokeRequired)
            {
                ProgressBarCallback d = new ProgressBarCallback(UpdateOnlineClientsProgressBar);
                this.Invoke(d, new object[] { start });
            }
            else
            {
                if (start)
                {

                    pbOnlineClients.Cursor = Cursors.WaitCursor;
                    pbOnlineClients.Show();
                    pbOnlineClients.MarqueeAnimationSpeed = 10;    
                }
                else
                {
                    pbOnlineClients.Cursor = Cursors.Default;
                    pbOnlineClients.Hide();
                    pbOnlineClients.MarqueeAnimationSpeed = 0;
                }
            }
        }

        private void lstViewHorusOnlineClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Computer setDetails = HorusClientsOnline.Find(item => item.HostName == lstViewHorusOnlineClients.SelectedItems[0].Text.ToString());

                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    try
                    {
                        SetHardwareText(setDetails);
                    }
                    catch (Exception ex)
                    {

                    }
                }).Start();
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    try
                    {
                        SetProcessDataGrid(setDetails);
                    }
                    catch (Exception ex)
                    {

                    }
                }).Start();
                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    try
                    {
                        SetHardwareUsage(setDetails);
                    }
                    catch (Exception ex)
                    {

                    }
                }).Start();
                
                
                
                
            }
            catch(Exception ex)
            {

            }
        }

        delegate void SetHardwareCallback(Computer comp);
        private void SetHardwareText(Computer comp)
        {
            if (this.hardwareTreeView.InvokeRequired)
            {
                SetHardwareCallback d = new SetHardwareCallback(SetHardwareText);
                this.Invoke(d, new object[] { comp });
            }
            else
            {
                if (comp.HostName == "")
                {

                }
                else
                {

                    //Set Computer Information
                    this.hardwareTreeView.Nodes[0].Nodes[0].Nodes[0].Text = comp.HostName;
                    this.hardwareTreeView.Nodes[0].Nodes[0].Nodes[1].Text = comp.SystemOS;
                    this.hardwareTreeView.Nodes[0].Nodes[0].Nodes[2].Text = comp.HostName;

                    //Set CPU information
                    this.hardwareTreeView.Nodes[0].Nodes[1].Nodes[0].Text = comp.CPUName;
                    this.hardwareTreeView.Nodes[0].Nodes[1].Nodes[1].Text = comp.CPUNumPhysicalCores.ToString();
                    this.hardwareTreeView.Nodes[0].Nodes[1].Nodes[2].Text = comp.CPUNumLogicalCores.ToString();

                    //Set Mobo Information
                    this.hardwareTreeView.Nodes[0].Nodes[2].Nodes[0].Text = comp.SystemMotherboard.Manufacturer;
                    this.hardwareTreeView.Nodes[0].Nodes[2].Nodes[1].Text = comp.SystemMotherboard.Model;
                    this.hardwareTreeView.Nodes[0].Nodes[2].Nodes[2].Text = comp.SystemMotherboard.SystemModel;

                    //Set Memory Information
                    this.hardwareTreeView.Nodes[0].Nodes[3].Nodes[0].Text = (comp.SystemRAM.totalRAM + "MB");
                    this.hardwareTreeView.Nodes[0].Nodes[3].Nodes[1].Text = comp.SystemRAM.installedRAM[0].speed;
                    this.hardwareTreeView.Nodes[0].Nodes[3].Nodes[2].Text = comp.SystemRAM.installedRAM[0].Manufacturer;

                }

            }
        }

        delegate void SetHardwareUsageCallback(Computer comp);
        private void SetHardwareUsage(Computer comp)
        {
            if (this.lblCPUUsage.InvokeRequired)
            {
                SetHardwareUsageCallback d = new SetHardwareUsageCallback(SetHardwareUsage);
                this.Invoke(d, new object[] { comp });
            }
            else
            {
                if (comp.HostName == "")
                {
                }
                else
                {
                    //Set CPU Usage Labels
                    //0 = Uptime: 1 = Utilisation: 2 = Threads: 3 = Processes
                    this.lblUptimeAns.Text = comp.SystemUpTime.TotalHours.ToString() + ":" + comp.SystemUpTime.TotalMinutes.ToString() + ":" + comp.SystemUpTime.TotalSeconds.ToString();
                    this.lblCPUUsageAns.Text = comp.SystemProcessor.cpuUsage;
                    this.lblThreadsAns.Text = comp.SystemProcessor.threads.ToString();
                    this.lblProcessesAns.Text = comp.RunningProcesses.GetProcesses().Count().ToString();

                    //Set RAM Usage Labels

                    this.lblTotalRAMAns.Text = comp.SystemRAM.totalRAM.ToString() + "MB";
                    this.lblFreeRAMAns.Text = comp.SystemRAM.freeRAM.ToString() + "MB";
                    this.lblInUseRAMAns.Text = (comp.SystemRAM.totalRAM - comp.SystemRAM.freeRAM).ToString() + "MB";

                    //Set Network Usage
                    
                    
                    this.txtBoxNetworkUsage.Text = "";
                    this.txtBoxNetworkUsage.Text = "Total In: " + comp.SystemNIC.KBytesIn.ToString() + Environment.NewLine + "Total Out: " + comp.SystemNIC.KBytesOut.ToString() + Environment.NewLine + comp.SystemNIC.KBytesTotal.ToString();

                    //Set Volume Usage

                    this.txtBoxVolUsage.Text = "";

                }
            }
        }


        delegate void SetProcessDataGridCallback(Computer comp);
        private void SetProcessDataGrid(Computer comp)
        {
            if (this.dataGridProcess.InvokeRequired)
            {
                SetProcessDataGridCallback d = new SetProcessDataGridCallback(SetProcessDataGrid);
                this.Invoke(d, new object[] { comp });
            }
            else
            {
                ProcNames = new List<string>();
                ProcessDataTable.Rows.Clear();
                foreach (Process proc in comp.RunningProcesses.GetProcesses())
                {
                    if (proc != null)
                    {
                        ProcessDataTable.Rows.Add((int)proc.Id, (string)proc.ProcessName, (int)proc.WorkingSet64, (int)proc.Threads.Count);
                    }
                }

                dataGridProcess.DataSource = ProcessDataTable;
                dataGridProcess.Refresh();

            }
        }

    }
}
   