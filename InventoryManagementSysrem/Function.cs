using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace InventoryManagementSysrem
{
     class Function
    {

        //Connection String
       public string connectionstring()
        {
            return "Data Source=localhost\\sqlexpress;Initial Catalog=MyLogin;Integrated Security=True";
        }

        
        // AN method that accepts SQL query and perfom SQL operation 
        public void PerformOperaion( string query)
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

        //FUNCTION THAT SELECTS THE DATA FROM THE DATABASE AND RETUNS THAT DATA IN THR FORM OF DATATABLE
        public DataTable viewdata()
        {
            SqlConnection conn = new SqlConnection(connectionstring());

            try
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Product_Details", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Connection Cannot be made Please check your sql server"+ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        //FUNCTION THAT FILTERS THE SELECTION
        public DataTable FilterTable(string Query)
        {
            SqlConnection conn = new SqlConnection(connectionstring());

            try
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(Query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        if(dt.Rows.Count > 0)
                        {
                            return dt;
                       }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erorr" + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public int ifExists(string name)
        {
            int available = 0;
            string query = "SELECT Product_Quantity FROM Product_Details WHERE Product_Name = '" + name + "'";
            SqlConnection con = new SqlConnection(connectionstring());

            try 
                
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                
                if(reader.Read())
                {
                    available = Convert.ToInt32(reader["Product_Quantity"]);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Cannot Check if product Exists or not " + ex.Message);
            }

            finally { con.Close(); }
            return available;
        }

    }
}
