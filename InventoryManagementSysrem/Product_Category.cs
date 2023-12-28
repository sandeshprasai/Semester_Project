using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSysrem
{
    public partial class Product_Category : Form
    {
        CategoryDBmanager DB = new CategoryDBmanager();
        public Product_Category()
        {
            InitializeComponent();
            id_box.KeyPress += id_box_KeyPress;
            name.KeyPress += name_KeyPress;
            Description.KeyPress += Description_KeyPress;
            Product_List.DataSource = DB.viewdata();
            
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
                Description.Focus();
                e.Handled = true;

            }
        }
        private void Description_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Enter))
            {
                if (e.KeyChar == ((char)Keys.Enter))
                {
                    Add_Btn_Click(sender, e);
                    e.Handled = true;

                }


            }
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id_box.Text)||
                string.IsNullOrWhiteSpace(name.Text)||
                string.IsNullOrWhiteSpace(Description.Text))
                
            {
                MessageBox.Show("Text Field Cannot be empty or cannot contain sapce only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string query = "INSERT INTO Category_Details (Category_Id,Category_Name,Category_Description) VALUES ('" + Convert.ToInt32(id_box.Text) + "','" + name.Text + "','" + Description.Text + "')";
                    DB.performoperation(query);
                    MessageBox.Show("Record Inserted");
                    id_box.Clear();
                    name.Clear();
                    Description.Clear();
                    Product_List.DataSource = DB.viewdata();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insertion Failled" + ex);
                }
            }
        }

        private void Product_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (Product_List.Columns[e.ColumnIndex].HeaderText == "Delete" && e.RowIndex != -1 )
            {
                int id = 0;
                DialogResult confirm = MessageBox.Show("Are You Sure You want to delete the record", "Warnning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                { 
                    id = Convert.ToInt32(Product_List.Rows[e.RowIndex].Cells["Category_Id"].Value);
                     string query = "DELETE FROM Category_Details WHERE Category_Id  = '" + id + "' ";
                    DB.performoperation(query);
                    MessageBox.Show("Record Deleted");
                     Product_List.DataSource = DB.viewdata();
                }
                else
                {
                    MessageBox.Show("Canclled the deletion");
                    return;
                }
            }
            if(Product_List.Columns[e.ColumnIndex].HeaderText == "Update" && e.RowIndex!=-1 )
                {

                int id = 0; string name;string description;
              
                    id = Convert.ToInt32(Product_List.Rows[e.RowIndex].Cells["Category_Id"].Value);
                    name = Product_List.Rows[e.RowIndex].Cells["Category_Name"].Value.ToString();
                    description = Product_List.Rows[e.RowIndex].Cells["Category_Description"].Value.ToString();
                    UpdateCategory catupdate = new UpdateCategory(id, name, description);
                    catupdate.Show();
              
            }
        }

        private void Product_List_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (Product_List.Columns[e.ColumnIndex].HeaderText == "Delete" ||
                    Product_List.Columns[e.ColumnIndex].HeaderText == "Update")
                {
                    // Set the background color for the button cells
                    e.CellStyle.BackColor = Color.FromArgb(234, 40, 58); // Use the color for Delete button
                    e.CellStyle.ForeColor = Color.White; // Set the text color to contrast with the background
                }
            }
        }

        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE  Category_Details SET Category_Name = '" + name.Text + "' ,  Category_Description='" + Description.Text + "'  WHERE Category_Id='" + Convert.ToInt32(id_box.Text) + "' ";
                DB.performoperation(query);
                Product_List.DataSource = DB.viewdata();
                MessageBox.Show("Category Updated Sucessfuly");
                id_box.Clear();
                name.Clear();
                Description.Clear();
            }

            catch(Exception ex)
            {
                MessageBox.Show("Failled to update Product" + ex.Message);
            }

        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
           
                id_box.Clear();
                name.Clear();
                Description.Clear();
                DataTable dataTable = DB.viewdata();
                Product_List.DataSource = dataTable;
            
        }

        
    }
}
