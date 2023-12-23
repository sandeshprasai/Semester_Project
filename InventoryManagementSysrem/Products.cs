using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSysrem
{
    public partial class Products : Form
    {
        public HomePage MidParent;

        Function fn = new Function();

        public Products()
        {
            InitializeComponent();
            fetchCategory();
            id_box.KeyPress += id_box_KeyPress;
            name.KeyPress += name_KeyPress;
            price.KeyPress += price_KeyPress;
            category.KeyPress += category_KeyPress;
            Qty_box.KeyPress += Qty_box_KeyPress;
            this.Load += Products_Load;

        }
        private void Clear_btn_Click(object sender, EventArgs e)
        {
            id_box.Clear();
            name.Clear();
            category.SelectedIndex = -1;
            price.Clear();
            Qty_box.Clear();
            DataTable dataTable = fn.viewdata();
            Product_List.DataSource = dataTable;
        }


        private void id_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Enter))
            {
                name.Focus();
                e.Handled = true;
               
            }
        }
        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Enter))
            {
                price.Focus();
                e.Handled = true;
                
            }
        }

        private void price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Enter))
            {
                category.Focus();
                e.Handled = true;
                
            }
        }
        private void category_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Enter))
            {
                Qty_box.Focus();
                e.Handled = true;

            }
        }

        private void Qty_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Enter))
            {
                Add_Btn_Click(sender, e);
                e.Handled = true;

            }
        }


        private void Add_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                string insert = "INSERT INTO Product_Details (Product_Name,Product_price,Product_Category,Product_Quantity)  VALUES ('" + name.Text + "' , '" + Convert.ToInt32(this.price.Text) + "' , '" + category.Text + "','" + Convert.ToInt32(this.Qty_box.Text) + "')";
                fn.PerformOperaion(insert);
                MessageBox.Show("Record inserted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "The record field cannot be empty");
            }
            finally
            {
                id_box.Clear();
                name.Clear();
                category.SelectedIndex = -1;
                price.Clear();
                Qty_box.Clear();
                Product_List.DataSource = fn.viewdata();
            }
        }
        private void Products_Load(object sender, EventArgs e)
        {

            Product_List.DataSource = fn.viewdata();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Product_List.DataSource = fn.viewdata();
        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            try
            {

                int productId = Convert.ToInt32(id_box.Text);
                string deleteQuery = "DELETE FROM Product_Details WHERE Product_id = " + productId;
                fn.PerformOperaion(deleteQuery);
            }

            catch
            {
                MessageBox.Show("Element deletion Failled");
            }
            finally
            {
                MessageBox.Show("Product deleted Susessfully");
                Product_List.DataSource = fn.viewdata();
            }
        }

        private void Product_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow PL = Product_List.Rows[e.RowIndex];
                id_box.Text = PL.Cells[0].Value.ToString();
                name.Text = PL.Cells[1].Value.ToString();
                price.Text = PL.Cells[2].Value.ToString();
                category.Text = PL.Cells[3].Value.ToString();
                Qty_box.Text = PL.Cells[4].Value.ToString();

            }
        }

        private void Filter_Click(object sender, EventArgs e)
        {
            if (Filter_Box.SelectedIndex < 0)
            {
                MessageBox.Show("Please select category to Filter", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string category = Filter_Box.SelectedItem.ToString();
                string query = "SELECT * FROM Product_Details WHERE Product_Category = '" + category + "'";
                Product_List.DataSource = fn.FilterTable(query);
            }

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string searchtext = SearchBox.Text;

            string query = "SELECT * FROM Product_Details WHERE Product_Name LIKE '%" + searchtext + "%'";
            if (fn.FilterTable(query) == null)
            {
                MessageBox.Show("No record Found");
            }
            else
            {
                Product_List.DataSource = fn.FilterTable(query);
            }

        }

        private void Edit_Btn_Click(object sender, EventArgs e)
        {

            string Query = "UPDATE  Product_Details SET Product_Name = '" + name.Text + "' , Product_Price = '" + float.Parse(price.Text) + "', Product_Category='" + category.Text + "' , Product_Quantity= '" + Convert.ToInt32(Qty_box.Text) + "' WHERE Product_id='" + Convert.ToInt32(id_box.Text) + "' ";
            fn.PerformOperaion(Query);
            Product_List.DataSource = fn.viewdata();
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
                    Filter_Box.Items.Add(rd[1].ToString());
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

    }
}

