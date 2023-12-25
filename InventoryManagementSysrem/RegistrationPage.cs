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

namespace InventoryManagementSysrem
{
    public partial class frmRegistration : Form
    {
        DatabaseManager RD=new DatabaseManager();
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Usrpassword.Text != RepatPassword.Text)
            {
                MessageBox.Show("Please Enter Same Password");
            }
            else
            {

                try
                {
                    string Query = "INSERT INTO Users (Username, Password, DOB) VALUES ('" + UserName.Text + "', '" + Usrpassword.Text + "', '" + DateofBirth.Value + "')";
                    RD.AddUser(Query);
                    MessageBox.Show("User registration successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserName.Clear();
                    Usrpassword.Clear();
                    RepatPassword.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while registering the user. Error details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked) 
            {
                Usrpassword.PasswordChar = '\0';
                RepatPassword.PasswordChar = '\0';
            }
            else
            {
                Usrpassword.PasswordChar = '*';
                RepatPassword.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserName.Clear();
            Usrpassword.Clear();
            RepatPassword.Clear();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }
    }
}
