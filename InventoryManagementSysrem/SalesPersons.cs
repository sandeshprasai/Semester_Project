using InventoryManagementSysrem.InventoryManagementSysrem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace InventoryManagementSysrem
{
    public partial class SalesPersons : Form
    {
         public string username;
        public SalesPersons()
        {
            InitializeComponent();
            loadSalesPerson();
        }


        public void loadSalesPerson()
        {
            string query = "SELECT * FROM Users ";
            SqlConnection conn = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=MyLogin;Integrated Security=True");
               

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                DataTable dataTable = dt;
                SalesPerson.DataSource = dataTable;

            }
                
            catch(Exception Ex)
            {
                MessageBox.Show("Connection failled"+Ex.Message);
            }
            finally { conn.Close(); }   

          
        }

       

        private void SalesPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if(e.RowIndex != -1) 
            {
               DataGridViewRow dv= SalesPerson.Rows[e.RowIndex];
                username = dv.Cells[0].Value.ToString();
            }
        }

        private void Authorize_Click(object sender, EventArgs e)
        {
            string query = "UPDATE   Users SET UsrStatus='Approved' WHERE Username= '"+  username +"'";
            SqlConnection conn = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=MyLogin;Integrated Security=True");

            try 
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                loadSalesPerson();

            }
            catch(Exception Ex) 
            {
                MessageBox.Show("Connection failled"+Ex.Message);
            }
            finally { conn.Close(); }
        }

        private void Remove_user_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM  Users  WHERE Username= '" + username + "'";
            SqlConnection conn = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=MyLogin;Integrated Security=True");

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                loadSalesPerson();

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Connection failled" + Ex.Message);
            }
            finally { conn.Close(); }
        }
    }
    }

