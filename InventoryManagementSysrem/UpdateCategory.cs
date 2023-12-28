using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace InventoryManagementSysrem
{
    public partial class UpdateCategory : Form
    {
        CategoryDBmanager DB = new CategoryDBmanager();
      
        public UpdateCategory(int id,string Name, string Description)
        {
            
            InitializeComponent();

            id_box.Text = id.ToString();
            name.Text= Name;
            description.Text = Description;

        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE  Category_Details SET Category_Name = '" + name.Text + "' ,  Category_Description='" + description.Text + "'  WHERE Category_Id='" + Convert.ToInt32(id_box.Text) + "' ";
                DB.performoperation(query);
                MessageBox.Show("Category Updated Sucessfuly" ,"Sucess",MessageBoxButtons.OK,MessageBoxIcon.Information);
                id_box.Clear();
                name.Clear();
                description.Clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Failled to update Product" + ex.Message ,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
