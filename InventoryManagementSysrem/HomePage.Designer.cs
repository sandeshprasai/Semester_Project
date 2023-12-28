namespace InventoryManagementSysrem
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.MenuBtn = new System.Windows.Forms.PictureBox();
            this.sideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Product = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Categories = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.SalesPerson = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Order = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.LogOut = new System.Windows.Forms.Button();
            this.SideBarTransition = new System.Windows.Forms.Timer(this.components);
            this.ChildFormPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuBtn)).BeginInit();
            this.sideBar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.MenuBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1594, 42);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hello ";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.button8);
            this.panel9.Location = new System.Drawing.Point(1465, -9);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(43, 50);
            this.panel9.TabIndex = 5;
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(-2, -2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(47, 66);
            this.button8.TabIndex = 3;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(585, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "INVENTORY MANAGEMENT DESKTOP APPLICATION";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button7);
            this.panel8.Location = new System.Drawing.Point(1512, -8);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(49, 50);
            this.panel8.TabIndex = 4;
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(-2, -2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(47, 66);
            this.button7.TabIndex = 3;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // MenuBtn
            // 
            this.MenuBtn.Image = ((System.Drawing.Image)(resources.GetObject("MenuBtn.Image")));
            this.MenuBtn.Location = new System.Drawing.Point(8, -3);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(41, 44);
            this.MenuBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MenuBtn.TabIndex = 1;
            this.MenuBtn.TabStop = false;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.sideBar.Controls.Add(this.panel2);
            this.sideBar.Controls.Add(this.panel3);
            this.sideBar.Controls.Add(this.panel4);
            this.sideBar.Controls.Add(this.panel5);
            this.sideBar.Controls.Add(this.panel6);
            this.sideBar.Controls.Add(this.panel7);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 42);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(66, 788);
            this.sideBar.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.HomeBtn);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 60);
            this.panel2.TabIndex = 4;
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.HomeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.ForeColor = System.Drawing.Color.White;
            this.HomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("HomeBtn.Image")));
            this.HomeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeBtn.Location = new System.Drawing.Point(-42, -1);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.HomeBtn.Size = new System.Drawing.Size(293, 62);
            this.HomeBtn.TabIndex = 0;
            this.HomeBtn.Text = "           Home";
            this.HomeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Product);
            this.panel3.Location = new System.Drawing.Point(3, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 60);
            this.panel3.TabIndex = 5;
            // 
            // Product
            // 
            this.Product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Product.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product.ForeColor = System.Drawing.Color.White;
            this.Product.Image = ((System.Drawing.Image)(resources.GetObject("Product.Image")));
            this.Product.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Product.Location = new System.Drawing.Point(-43, -1);
            this.Product.Name = "Product";
            this.Product.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.Product.Size = new System.Drawing.Size(283, 62);
            this.Product.TabIndex = 0;
            this.Product.Text = "           Products";
            this.Product.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Product.UseVisualStyleBackColor = false;
            this.Product.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Categories);
            this.panel4.Location = new System.Drawing.Point(3, 135);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(229, 60);
            this.panel4.TabIndex = 6;
            // 
            // Categories
            // 
            this.Categories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Categories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Categories.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categories.ForeColor = System.Drawing.Color.White;
            this.Categories.Image = ((System.Drawing.Image)(resources.GetObject("Categories.Image")));
            this.Categories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Categories.Location = new System.Drawing.Point(-43, -1);
            this.Categories.Name = "Categories";
            this.Categories.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.Categories.Size = new System.Drawing.Size(283, 62);
            this.Categories.TabIndex = 0;
            this.Categories.Text = "           Categories";
            this.Categories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Categories.UseVisualStyleBackColor = false;
            this.Categories.Click += new System.EventHandler(this.Categories_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.SalesPerson);
            this.panel5.Location = new System.Drawing.Point(3, 201);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(229, 60);
            this.panel5.TabIndex = 5;
            // 
            // SalesPerson
            // 
            this.SalesPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.SalesPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesPerson.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesPerson.ForeColor = System.Drawing.Color.White;
            this.SalesPerson.Image = ((System.Drawing.Image)(resources.GetObject("SalesPerson.Image")));
            this.SalesPerson.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalesPerson.Location = new System.Drawing.Point(-43, -1);
            this.SalesPerson.Name = "SalesPerson";
            this.SalesPerson.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.SalesPerson.Size = new System.Drawing.Size(283, 62);
            this.SalesPerson.TabIndex = 0;
            this.SalesPerson.Text = "           SalesPerson";
            this.SalesPerson.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SalesPerson.UseVisualStyleBackColor = false;
            this.SalesPerson.Click += new System.EventHandler(this.SalesPerson_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.Order);
            this.panel6.Location = new System.Drawing.Point(3, 267);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(229, 60);
            this.panel6.TabIndex = 7;
            // 
            // Order
            // 
            this.Order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Order.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order.ForeColor = System.Drawing.Color.White;
            this.Order.Image = ((System.Drawing.Image)(resources.GetObject("Order.Image")));
            this.Order.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Order.Location = new System.Drawing.Point(-43, -1);
            this.Order.Name = "Order";
            this.Order.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.Order.Size = new System.Drawing.Size(283, 62);
            this.Order.TabIndex = 0;
            this.Order.Text = "           Orders";
            this.Order.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Order.UseVisualStyleBackColor = false;
            this.Order.Click += new System.EventHandler(this.Order_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.LogOut);
            this.panel7.Location = new System.Drawing.Point(3, 333);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(229, 60);
            this.panel7.TabIndex = 8;
            // 
            // LogOut
            // 
            this.LogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOut.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.ForeColor = System.Drawing.Color.White;
            this.LogOut.Image = ((System.Drawing.Image)(resources.GetObject("LogOut.Image")));
            this.LogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOut.Location = new System.Drawing.Point(-43, -1);
            this.LogOut.Name = "LogOut";
            this.LogOut.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.LogOut.Size = new System.Drawing.Size(283, 62);
            this.LogOut.TabIndex = 0;
            this.LogOut.Text = "           LogOut";
            this.LogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOut.UseVisualStyleBackColor = false;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // SideBarTransition
            // 
            this.SideBarTransition.Interval = 10;
            // 
            // ChildFormPanel
            // 
            this.ChildFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildFormPanel.Location = new System.Drawing.Point(66, 42);
            this.ChildFormPanel.Name = "ChildFormPanel";
            this.ChildFormPanel.Size = new System.Drawing.Size(1528, 788);
            this.ChildFormPanel.TabIndex = 4;
            this.ChildFormPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ChildFormPanel_Paint);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.HomeBtn;
            this.ClientSize = new System.Drawing.Size(1594, 830);
            this.Controls.Add(this.ChildFormPanel);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MenuBtn)).EndInit();
            this.sideBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox MenuBtn;
        private System.Windows.Forms.FlowLayoutPanel sideBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Product;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Categories;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button SalesPerson;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button Order;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Timer SideBarTransition;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel ChildFormPanel;
    }
}