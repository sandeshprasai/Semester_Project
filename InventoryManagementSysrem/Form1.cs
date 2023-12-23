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
using InventoryManagementSysrem.InventoryManagementSysrem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace InventoryManagementSysrem
{
    

    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=MyLogin;Integrated Security=True");

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            String Username = UserName.Text.ToString();
            String password = Password.Text.ToString();
            DatabaseManager databaseManager = new DatabaseManager();
            if (databaseManager.ValidateLogin(Username, password))
            {
                this.Hide();
                
            }
            else
            {
                // Invalid login
                MessageBox.Show("Invalid Login credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserName.Clear();
                Password.Clear();
                UserName.Focus();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRegistration fm = new frmRegistration();
            fm.Show();
            this.Hide();
        }
    }
}
