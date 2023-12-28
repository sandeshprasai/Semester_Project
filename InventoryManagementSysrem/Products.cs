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

       

        private void Product_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Product_List.Columns[e.ColumnIndex].HeaderText == "Delete" && e.RowIndex != -1)
            {
                int id = 0;
                DialogResult confirm = MessageBox.Show("Are You Sure You want to delete the record", "Warnning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    id = Convert.ToInt32(Product_List.Rows[e.RowIndex].Cells["Product_Id"].Value);
                    string query = "DELETE FROM Product_Details WHERE Product_Id  = '" + id + "' ";
                   fn.PerformOperaion(query);
                    MessageBox.Show("Record Deleted");
                    Product_List.DataSource = fn.viewdata();
                    
                }
                else
                {
                    MessageBox.Show("Canclled the deletion");
                    return;
                }
            }
            if (Product_List.Columns[e.ColumnIndex].HeaderText == "Update" && e.RowIndex != -1)
            {

                int id = 0; int quantity=0; string name;string category;
                float price = 0;
                id = Convert.ToInt32(Product_List.Rows[e.RowIndex].Cells["Product_Id"].Value);
                name = Product_List.Rows[e.RowIndex].Cells["Product_Name"].Value.ToString();
                category = Product_List.Rows[e.RowIndex].Cells["Product_Category"].Value.ToString();
                price = float.Parse(Product_List.Rows[e.RowIndex].Cells["Product_Price"].Value.ToString());
                quantity = Convert.ToInt32(Product_List.Rows[e.RowIndex].Cells["Product_Quantity"].Value);
                UpdateProduct up = new UpdateProduct(id, name, price, category, quantity);
                up.Show();
                
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
                if(fn.FilterTable(query)!=null)
                {
                    Product_List.DataSource = fn.FilterTable(query);
                }
                else
                {
                    MessageBox.Show("No record Found","No data",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
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

