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
            public string connectionstring()
            {
                return "Data Source=localhost\\sqlexpress;Initial Catalog=MyLogin;Integrated Security=True";
            }
            
            public void AddUser(string query)
            {

                SqlConnection conn = new SqlConnection(connectionstring());
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
            public bool ValidateLogin(string username, string password)
            {
                SqlConnection conn = new SqlConnection(connectionstring());
                    try
                {
                    string query = "SELECT * FROM Users WHERE Username = @UsrName AND Password = @pass";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UsrName", username);
                        cmd.Parameters.AddWithValue("@pass", password);
                        conn.Open();
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            sda.Fill(dataTable);
                            if (dataTable.Rows.Count > 0)
                            {
                                // Check UserStatus
                                string userStatus = dataTable.Rows[0]["UsrStatus"].ToString();
                                if (userStatus == "Approved")
                                {
                                    MessageBox.Show("Login SucessFull");
                                    return true;
                                }
                                else
                                {
                                    MessageBox.Show("User Registred But Not verified");
                                    return false;
                                }
                            }
                            else
                            {
                               
                                return false;
                            }
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
