using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Scheduler.Utils
{
    class DatabaseHelper
    {
        public static SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "Data\\ProjectsDB.mdf;Integrated Security=True");

        public static bool TestConnection()
        {
            try
            {
                Connection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("Test Failed!");
                return false;
            }
            finally
            {
                Connection.Close();
            }

            MessageBox.Show("Test Passed!");
            return true;
        }

        public static DataTable GetAllProjects()
        {
            Connection.Open();

            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM ProjectsTable ORDER BY Name", Connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            Connection.Close();

            return dataTable;

        }

    }
}
