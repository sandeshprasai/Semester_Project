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
            catch(Exception ex)
            {
                MessageBox.Show("Insertion Failled"+ex);
            }
        }

        private void Product_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow PL = Product_List.Rows[e.RowIndex];
                id_box.Text = PL.Cells[0].Value.ToString();
                name.Text = PL.Cells[1].Value.ToString();
                Description.Text = PL.Cells[2].Value.ToString();

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

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM Category_Details WHERE Category_id='" + Convert.ToInt32(id_box.Text) + "'";
                DB.performoperation(query);
                MessageBox.Show("Record Delete");
                DataTable dataTable = DB.viewdata();
                Product_List.DataSource = dataTable;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Cannot Delete" + ex);
            }
            finally
            {

                id_box.Clear();
                name.Clear();
                Description.Clear();
            }
        }
    }
}
