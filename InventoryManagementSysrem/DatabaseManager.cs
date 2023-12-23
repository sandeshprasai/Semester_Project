using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace InventoryManagementSysrem
{
    using System;
    using System.Data;
    using System.Data.SqlClient;

    namespace InventoryManagementSysrem
    {
        public class DatabaseManager
        {
            private SqlConnection conn;

            public DatabaseManager(string connectionString)
            {
                conn = new SqlConnection(connectionString);
            }

            public bool ValidateLogin(string username, string password)
            {
                try
                {
                    string query = "SELECT * FROM Users WHERE Email = @UsrName AND Password = @pass";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UsrName", username);
                        cmd.Parameters.AddWithValue("@pass", password);
                        conn.Open();
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            sda.Fill(dataTable);
                            return dataTable.Rows.Count > 0;
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Database Erorr"+ex);
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }

}
