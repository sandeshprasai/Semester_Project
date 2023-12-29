using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace InventoryManagementSysrem
{
    public class HomeElement
    {
        public HomeElement() { }
         public string ConnectionString()
        {
            return "Data Source=localhost\\sqlexpress;Initial Catalog=MyLogin;Integrated Security=True";
        }
        public string FetchTopSeller()
        {
            SqlConnection conn = new SqlConnection(ConnectionString());

            string query = "SELECT TOP 1 Username FROM Users  ORDER BY TotalSelling  DESC ";
            string topseller="";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() && reader["Username"]!=null) 
                {
                    topseller = reader["Username"].ToString();
                }
              
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Fetching Top Seller Failled" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally { conn.Close(); }   

            return topseller;
        }
        public int FetchTopSellerQty()
        {
            SqlConnection conn = new SqlConnection(ConnectionString());

            string query = "SELECT TOP 1 TotalSelling FROM Users  ORDER BY TotalSelling  DESC ";
            int topseller = 0;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() && reader["TotalSelling"] != null)
                {
                    topseller = Convert.ToInt32(reader["TotalSelling"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fetching Top Seller Quantity Failled" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally { conn.Close(); }

            return topseller;
        }

        public string FetchHignStockName()
        {
            SqlConnection conn = new SqlConnection(ConnectionString());

            string query = "SELECT TOP 1 Product_Name FROM Product_Details  ORDER BY Product_Quantity  DESC ";
            string name = "";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() && reader["Product_Name"] != null)
                {
                    name = reader["Product_Name"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fetching Top Seller Failled" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally { conn.Close(); }

            return name;
        }

        public int FetchHignStockQty()
        {
            SqlConnection conn = new SqlConnection(ConnectionString());

            string query = "SELECT TOP 1 Product_Quantity FROM Product_Details  ORDER BY Product_Quantity  DESC ";
            int qty=0;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() && reader["Product_Quantity"] != null)
                {
                    qty = Convert.ToInt32(reader["Product_Quantity"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fetching Top Quantity Failled" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally { conn.Close(); }

            return qty;
        }

        public int FetchLowStockQty()
        {
            SqlConnection conn = new SqlConnection(ConnectionString());

            string query = "SELECT TOP 1 Product_Quantity FROM Product_Details ORDER BY Product_Quantity ASC";
            int qty = 0;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() && reader["Product_Quantity"] != null)
                {
                    qty = Convert.ToInt32(reader["Product_Quantity"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fetching Top Quantity Failled" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally { conn.Close(); }

            return qty;
        }

        public string FetchLowStockName()
        {
            SqlConnection conn = new SqlConnection(ConnectionString());

            string query = "SELECT TOP 1 Product_Name FROM Product_Details  ORDER BY Product_Quantity  ASC ";
            string name = "";
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() && reader["Product_Name"] != null)
                {
                    name = reader["Product_Name"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fetching Top Seller Failled" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally { conn.Close(); }

            return name;
        }

        public DataTable FetchRecentlyAdded() 
        
        {
            SqlConnection conn = new SqlConnection(ConnectionString());
            DataTable dt= new DataTable();
            string query = "SELECT TOP 5 * FROM Product_Details ORDER BY Product_id  DESC";
                    
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Cannot Fetch top 5 Recently Added Product" + ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }

        public DataTable FetchRecentlySold()

        {
            SqlConnection conn = new SqlConnection(ConnectionString());
            DataTable dt = new DataTable();
            string query = "SELECT TOP 5 * FROM BillTable ORDER BY ID  DESC";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Fetch top 5 Recently Sold Product" + ex.Message , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }

            return dt;
        } 
    }
}
