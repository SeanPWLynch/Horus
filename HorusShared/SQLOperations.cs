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

        
    }
}
