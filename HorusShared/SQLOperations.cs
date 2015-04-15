using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HorusShared;

namespace HorusShared
{
    class SQLOperations
    {

        SqlConnection myConnection;

        public SQLOperations()
        {
            SqlConnection myConnection = new SqlConnection(@"Data Source="+Properties.Settings.Default.ServerAddress+@"\SQLEXPRESS;Database="+Properties.Settings.Default.DatabaseName+";Integrated Security=SSPI");
        }

        public void CheckComputer(ComputerObjects.Computer HorusComputer)
        {


            string checkComputerExists = "SELECT TOP 1 * FROM HorusComputer WHERE ComputerName = '" + HorusComputer.HostName + "'";
            string inserNewComputer = "INSERT INTO HorusComputer (ComputerName) Values ('" + HorusComputer.HostName + "')";

            try
            {
                SqlConnection myConnection = new SqlConnection(@"Data Source="+Properties.Settings.Default.ServerAddress+@"\SQLEXPRESS;Database="+Properties.Settings.Default.DatabaseName+";Integrated Security=SSPI");
                myConnection.Open();
                SqlCommand sq_checkComputerExists = new SqlCommand(checkComputerExists, myConnection);
                SqlCommand sq_insertNewCompter = new SqlCommand(inserNewComputer, myConnection);
                SqlDataReader sdr_DataReader = sq_checkComputerExists.ExecuteReader();

                List<string> ReturnedComputers = new List<string>();

                while (sdr_DataReader.Read())
                {
                    ReturnedComputers.Add(sdr_DataReader.GetValue(1).ToString().Trim());
                }

                sdr_DataReader.Close();

                    if (ReturnedComputers.Contains(HorusComputer.HostName))
                    {

                    }
                    else
                    {
                        sq_insertNewCompter.ExecuteNonQuery();
                    }
                

                myConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void CheckAdmins(List<string> LocalAdmins)
        {

            string checkLocalAdminExists = "SELECT AdminName FROM LocalAdmins";

            try
            {
                            SqlConnection myConnection = new SqlConnection(@"Data Source="+Properties.Settings.Default.ServerAddress+@"\SQLEXPRESS;Database="+Properties.Settings.Default.DatabaseName+";Integrated Security=SSPI");
                myConnection.Open();
                SqlCommand sq_checkLocalAdminExists = new SqlCommand(checkLocalAdminExists, myConnection);
                //SqlCommand sq_insertNewCompter = new SqlCommand(inserNewSoftware, myConnection);
                SqlDataReader sdr_DataReader = sq_checkLocalAdminExists.ExecuteReader();

                List<string> ReturnedLocalAdmins = new List<string>();

                while (sdr_DataReader.Read())
                {
                    ReturnedLocalAdmins.Add(sdr_DataReader.GetValue(0).ToString().Trim());
                }
                sdr_DataReader.Close();

                foreach (string localAdmin in LocalAdmins)
                {
                    string insertNewSoftware = "INSERT INTO LocalAdmins (AdminName) Values ('" + localAdmin + "')";
                    SqlCommand sq_insertNewLocalAdmin = new SqlCommand(insertNewSoftware, myConnection);
                    if (ReturnedLocalAdmins.Contains(localAdmin.Trim()))
                    {

                    }
                    else
                    {
                        sq_insertNewLocalAdmin.ExecuteNonQuery();
                    }
                }

                myConnection.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /*
        public void UpdateLocalAdmins(string HorusComputer.HostName, List<string> LocalAdmins)
        {
            string qs_getComputerID = "SELECT TOP 1 cid FROM COMPUTERS WHERE ComputerName = '" + HorusComputer.HostName + "'";
            string qs_getAdmidID;
            string qs_insertLocalAdmins;
            int computerID;

            try
            {
                            SqlConnection myConnection = new SqlConnection(@"Data Source="+Properties.Settings.Default.ServerAddress+@"\SQLEXPRESS;Database="+Properties.Settings.Default.DatabaseName+";Integrated Security=SSPI");
                myConnection.Open();


                SqlCommand sq_getComputerID = new SqlCommand(qs_getComputerID, myConnection);
                SqlDataReader sdr_DataReader = sq_getComputerID.ExecuteReader();
                sdr_DataReader.Read();
                computerID = int.Parse(sdr_DataReader.GetValue(0).ToString());
                sdr_DataReader.Close();

                string date = DateTime.Today.ToShortDateString();
                string qs_dropCurrentLocalAdmins = "DELETE FROM ComputerAdmins WHERE cid = " + computerID;
                SqlCommand sq_dropCurrentLocalAdmins = new SqlCommand(qs_dropCurrentLocalAdmins, myConnection);
                sq_dropCurrentLocalAdmins.ExecuteNonQuery();

                foreach (string localAdmin in LocalAdmins)
                {
                    qs_getAdmidID = "SELECT TOP 1 aid FROM LocalAdmins WHERE AdminName = '" + localAdmin + "'";
                    SqlCommand sq_getAdminID = new SqlCommand(qs_getAdmidID, myConnection);
                    sdr_DataReader = sq_getAdminID.ExecuteReader();

                    sdr_DataReader.Read();

                    int localAdminID = int.Parse(sdr_DataReader.GetValue(0).ToString());

                    sdr_DataReader.Close();
                    try
                    {
                        qs_insertLocalAdmins = "INSERT INTO ComputerAdmins (cid,aid, date) Values (" + computerID + "," + localAdminID + ",'" + date + "')";
                        SqlCommand sq_insertNewInstalledSoftware = new SqlCommand(qs_insertLocalAdmins, myConnection);
                        sq_insertNewInstalledSoftware.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(computerID + " " + localAdminID);
                    }
                }

                myConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                myConnection.Close();
            }
        }*/
    }
}
