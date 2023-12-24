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
            Product_List.DataSource = DB.viewdata();
            
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO Category_Details (Category_Id,Category_Name,Category_Description) VALUES ('" + Convert.ToInt32(id_box.Text) + "','" + name.Text + "','" + Description.Text + "')";
                DB.addCategory(query);
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
           
        }
    }
}
