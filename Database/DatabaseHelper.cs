using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeAttendanceSystem.Database
{
    public class DatabaseHelper
    {
        // Connection string (will be moved to App.config later)
        private string connectionString =
        ConfigurationManager.ConnectionStrings["EmployeeAttendanceDB"].ConnectionString;
        // Execute Insert, Update, Delete queries
        public bool ExecuteQuery(string query, SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        con.Open();
                        int rows = cmd.ExecuteNonQuery();

                        return rows > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
                return false;
            }
        }

        // Get data for DataGridView
        public DataTable GetData(string query, SqlParameter[] parameters = null)
        {
            DataTable table = new DataTable();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        using (SqlDataAdapter adapter =
                               new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(table);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }

            return table;
        }
        public object ExecuteScalar(string query)
        {
            object result = null;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, con);

                    con.Open();

                    result = cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return result;
        }
    }
}