﻿using System;
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
    public partial class HomePage : Form
    {
        HomeElement HME =new HomeElement();
        string UserName;
        public HomePage()
        {
            InitializeComponent();
            SideBarTransition.Interval = 10;
            SideBarTransition.Tick += new EventHandler(sideBarTransition_Tick);
            MenuBtn.Click += new EventHandler(MenuBtn_Click);
        }


        public HomePage(string Usrstatus, string Username)
        {

            InitializeComponent();
            SideBarTransition.Interval = 10;
            SideBarTransition.Tick += new EventHandler(sideBarTransition_Tick);
            MenuBtn.Click += new EventHandler(MenuBtn_Click);
            label2.Text = "Hello " + Username;
            if (Usrstatus == "User")
            {
                Product.Hide();
                Categories.Hide();
                SalesPerson.Hide();
            }
            UserName = Username;
            setElement();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        bool sidebarExpand = false;
        private void sideBarTransition_Tick(object sender, EventArgs e)
        {

            if (sidebarExpand)
            {
                sideBar.Width -= 10;
                if (sideBar.Width <= 50)
                {
                    sidebarExpand = false;
                    SideBarTransition.Stop();
                }
            }
            else
            {
                sideBar.Width += 10;
                if (sideBar.Width >= 170)
                {
                    sidebarExpand = true;
                    SideBarTransition.Stop();
                }
            }
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            SideBarTransition.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;  // Set activeForm to null after closing the form.
            }
            setElement();
        }
        private Form activeForm = null;
        private void openChildFomrm(Form ChildForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            ChildFormPanel.Controls.Add(ChildForm);
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildFomrm(new Products());
        }

        private void ChildFormPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Categories_Click(object sender, EventArgs e)
        {
            Product_Category pc = new Product_Category();
            openChildFomrm(pc);
        }

        private void SalesPerson_Click(object sender, EventArgs e)
        {
            SalesPersons sp = new SalesPersons();
            openChildFomrm(sp);
        }

        private void Order_Click(object sender, EventArgs e)
        {
           BillingPage bill = new BillingPage(UserName);    
            openChildFomrm(bill);
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
          DialogResult confirm=  MessageBox.Show("Are you Sure You want to logout?", "Do You wan't to Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);   
            if(confirm == DialogResult.Yes)
            {
                Application.Exit();
            }    
            else
            {
                return;
            }
        }

        public void setElement()
        {
            SellerName.Text = HME.FetchTopSeller();
            Quantity.Text = HME.FetchTopSellerQty().ToString(); 
            Pname.Text=HME.FetchHignStockName();
            Pqty.Text=HME.FetchHignStockQty().ToString();
            Lqty.Text=HME.FetchLowStockQty().ToString();
            LName.Text=HME.FetchLowStockName();
            RecentlyAdded.DataSource = HME.FetchRecentlyAdded();
            RecentlySold.DataSource = HME.FetchRecentlySold();
        }
        
    }
}
