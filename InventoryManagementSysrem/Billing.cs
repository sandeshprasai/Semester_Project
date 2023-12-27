using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;

namespace InventoryManagementSysrem
{
    public class Billing
    {
        public string connectionString()
        {
            return "Data Source=localhost\\sqlexpress;Initial Catalog=MyLogin;Integrated Security=True";
        }

        public DataTable viewData(string query)
        {
            SqlConnection conn = new SqlConnection(connectionString());
            
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand(query,conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                return dt;
            }
            
            catch (Exception ex) 
            {
                MessageBox.Show("Errorr while establishing the connection"+ex.Message);
                return null;
            }

            finally { conn.Close(); }   
        }

        public int checkquantity(int quantity , string product_name)
        {
            int available = 0;
            string query = "SELECT Product_Quantity FROM Product_Details WHERE Product_Name = '"+product_name+"' ";
            SqlConnection conn = new SqlConnection(connectionString());
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    available = Convert.ToInt32(reader["Product_Quantity"]);
                }
                return available;
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Canot read Product quantity in your database" + ex.Message);
                return available;
            }
            finally { conn.Close(); }
        }
    }
}
