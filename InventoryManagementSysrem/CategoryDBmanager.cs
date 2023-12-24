using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace InventoryManagementSysrem
{
    internal class CategoryDBmanager
    {
        public string ConnectionString()
        {
            return "Data Source=localhost\\sqlexpress;Initial Catalog=MyLogin;Integrated Security=True";
        }

        public void performoperation(string query)
        {
            SqlConnection conn = new SqlConnection(ConnectionString());
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query,conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Connection failled"+ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable viewdata()
        {
            SqlConnection conn = new SqlConnection(ConnectionString());

            try
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Category_Details", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dt.Load(reader);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Cannot be made Please check your sql server" + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }


    }
}
