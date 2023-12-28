using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace InventoryManagementSysrem
{
    public partial class UpdateProduct : Form
    {
        Function fn = new Function();
        DataTable dt = new DataTable();
        public UpdateProduct(int id, string name ,float price , string Category , int quantity)
        {
            InitializeComponent();
            fetchCategory();
            id_box.Text = id.ToString();
            Name.Text = name;
            Price.Text = price.ToString();
           category.Text = category.ToString();
            Quantity.Text = quantity.ToString();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "UPDATE  Product_Details SET Product_Name = '" + Name.Text + "' , Product_Price = '" + float.Parse(Price.Text) + "', Product_Category='" + category.Text + "' , Product_Quantity= '" + Convert.ToInt32(Quantity.Text) + "' WHERE Product_id='" + Convert.ToInt32(id_box.Text) + "' ";
                fn.PerformOperaion(Query);
                MessageBox.Show("Product Updated SucessFully ", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Updation Failled" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            
        }
        public void fetchCategory()
        {
            SqlConnection con = new SqlConnection(fn.connectionstring());
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Category_Details", con);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    category.Items.Add(rd[1].ToString());
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Cannot fetch " + Ex);
            }
            finally
            {

                con.Close();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }
    }
}
