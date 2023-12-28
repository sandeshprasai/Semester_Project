namespace InventoryManagementSysrem
{
    partial class Products
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.Add_Btn = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.name = new Guna.UI2.WinForms.Guna2TextBox();
            this.category = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.price = new Guna.UI2.WinForms.Guna2TextBox();
            this.Clear_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Product_List = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Product_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.Qty_box = new Guna.UI2.WinForms.Guna2TextBox();
            this.Filter_Box = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Filter = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label3 = new System.Windows.Forms.Label();
            this.id_box = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Product_List)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // Add_Btn
            // 
            this.Add_Btn.Animated = true;
            this.Add_Btn.AutoRoundedCorners = true;
            this.Add_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Add_Btn.BorderColor = System.Drawing.Color.Transparent;
            this.Add_Btn.BorderRadius = 21;
            this.Add_Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Add_Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Add_Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Add_Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Add_Btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(147)))), ((int)(((byte)(1)))));
            this.Add_Btn.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold);
            this.Add_Btn.ForeColor = System.Drawing.Color.White;
            this.Add_Btn.Location = new System.Drawing.Point(0, 195);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(180, 45);
            this.Add_Btn.TabIndex = 1;
            this.Add_Btn.Text = "Add";
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(232, 74);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label4.Size = new System.Drawing.Size(218, 51);
            this.label4.TabIndex = 7;
            this.label4.Text = "Product Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(740, 74);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label5.Size = new System.Drawing.Size(286, 51);
            this.label5.TabIndex = 8;
            this.label5.Text = "Product Category";
            // 
            // name
            // 
            this.name.AutoRoundedCorners = true;
            this.name.BorderRadius = 20;
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.DefaultText = "";
            this.name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(116)))), ((int)(((byte)(238)))));
            this.name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name.Font = new System.Drawing.Font("Courier New", 12F);
            this.name.ForeColor = System.Drawing.Color.Black;
            this.name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name.Location = new System.Drawing.Point(229, 136);
            this.name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.name.Name = "name";
            this.name.PasswordChar = '\0';
            this.name.PlaceholderText = "";
            this.name.SelectedText = "";
            this.name.Size = new System.Drawing.Size(221, 43);
            this.name.TabIndex = 9;
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // category
            // 
            this.category.AutoRoundedCorners = true;
            this.category.BackColor = System.Drawing.Color.Transparent;
            this.category.BorderRadius = 17;
            this.category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(116)))), ((int)(((byte)(238)))));
            this.category.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.category.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.category.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold);
            this.category.ForeColor = System.Drawing.Color.Black;
            this.category.ItemHeight = 30;
            this.category.Location = new System.Drawing.Point(735, 136);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(291, 36);
            this.category.TabIndex = 10;
            this.category.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(486, 74);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label6.Size = new System.Drawing.Size(235, 51);
            this.label6.TabIndex = 11;
            this.label6.Text = "Product Price";
            // 
            // price
            // 
            this.price.AutoRoundedCorners = true;
            this.price.BorderRadius = 24;
            this.price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.price.DefaultText = "";
            this.price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.price.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(116)))), ((int)(((byte)(238)))));
            this.price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.price.Font = new System.Drawing.Font("Courier New", 12F);
            this.price.ForeColor = System.Drawing.Color.Black;
            this.price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.price.Location = new System.Drawing.Point(485, 129);
            this.price.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.price.Name = "price";
            this.price.PasswordChar = '\0';
            this.price.PlaceholderText = "";
            this.price.SelectedText = "";
            this.price.Size = new System.Drawing.Size(236, 50);
            this.price.TabIndex = 12;
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Clear_btn
            // 
            this.Clear_btn.Animated = true;
            this.Clear_btn.AutoRoundedCorners = true;
            this.Clear_btn.BackColor = System.Drawing.Color.Transparent;
            this.Clear_btn.BorderColor = System.Drawing.Color.Transparent;
            this.Clear_btn.BorderRadius = 21;
            this.Clear_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Clear_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Clear_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Clear_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Clear_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(40)))), ((int)(((byte)(58)))));
            this.Clear_btn.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold);
            this.Clear_btn.ForeColor = System.Drawing.Color.White;
            this.Clear_btn.Location = new System.Drawing.Point(215, 195);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(180, 45);
            this.Clear_btn.TabIndex = 14;
            this.Clear_btn.Text = "Clear";
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // Product_List
            // 
            this.Product_List.AllowUserToAddRows = false;
            this.Product_List.AllowUserToDeleteRows = false;
            this.Product_List.AllowUserToResizeColumns = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.Product_List.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Product_List.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Product_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Product_List.ColumnHeadersHeight = 40;
            this.Product_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Product_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_Id,
            this.Product_Name,
            this.Product_Price,
            this.Product_Category,
            this.Product_Quantity,
            this.Update,
            this.Delete});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Product_List.DefaultCellStyle = dataGridViewCellStyle6;
            this.Product_List.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Product_List.GridColor = System.Drawing.Color.Yellow;
            this.Product_List.Location = new System.Drawing.Point(0, 392);
            this.Product_List.Name = "Product_List";
            this.Product_List.ReadOnly = true;
            this.Product_List.RowHeadersVisible = false;
            this.Product_List.RowHeadersWidth = 40;
            this.Product_List.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Product_List.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Purple;
            this.Product_List.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_List.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Product_List.RowTemplate.Height = 30;
            this.Product_List.Size = new System.Drawing.Size(1365, 438);
            this.Product_List.TabIndex = 15;
            this.Product_List.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Carrot;
            this.Product_List.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(216)))), ((int)(((byte)(189)))));
            this.Product_List.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Product_List.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Product_List.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Product_List.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Product_List.ThemeStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Product_List.ThemeStyle.GridColor = System.Drawing.Color.Yellow;
            this.Product_List.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.Product_List.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Product_List.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_List.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Product_List.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Product_List.ThemeStyle.HeaderStyle.Height = 40;
            this.Product_List.ThemeStyle.ReadOnly = true;
            this.Product_List.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(229)))), ((int)(((byte)(211)))));
            this.Product_List.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Product_List.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_List.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.OrangeRed;
            this.Product_List.ThemeStyle.RowsStyle.Height = 30;
            this.Product_List.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(169)))), ((int)(((byte)(107)))));
            this.Product_List.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.Product_List.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Product_List_CellClick);
            // 
            // Product_Id
            // 
            this.Product_Id.DataPropertyName = "Product_Id";
            this.Product_Id.FillWeight = 59.71404F;
            this.Product_Id.HeaderText = "Id";
            this.Product_Id.MinimumWidth = 6;
            this.Product_Id.Name = "Product_Id";
            this.Product_Id.ReadOnly = true;
            this.Product_Id.Visible = false;
            // 
            // Product_Name
            // 
            this.Product_Name.DataPropertyName = "Product_Name";
            this.Product_Name.FillWeight = 119.6182F;
            this.Product_Name.HeaderText = "Name";
            this.Product_Name.MinimumWidth = 6;
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.ReadOnly = true;
            // 
            // Product_Price
            // 
            this.Product_Price.DataPropertyName = "Product_Price";
            this.Product_Price.FillWeight = 144.4551F;
            this.Product_Price.HeaderText = "Price";
            this.Product_Price.MinimumWidth = 6;
            this.Product_Price.Name = "Product_Price";
            this.Product_Price.ReadOnly = true;
            // 
            // Product_Category
            // 
            this.Product_Category.DataPropertyName = "Product_Category";
            this.Product_Category.FillWeight = 128.6708F;
            this.Product_Category.HeaderText = "Category";
            this.Product_Category.MinimumWidth = 6;
            this.Product_Category.Name = "Product_Category";
            this.Product_Category.ReadOnly = true;
            // 
            // Product_Quantity
            // 
            this.Product_Quantity.DataPropertyName = "Product_Quantity";
            this.Product_Quantity.FillWeight = 64.61216F;
            this.Product_Quantity.HeaderText = "Quantity";
            this.Product_Quantity.MinimumWidth = 6;
            this.Product_Quantity.Name = "Product_Quantity";
            this.Product_Quantity.ReadOnly = true;
            // 
            // Update
            // 
            this.Update.FillWeight = 86.54882F;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Update.HeaderText = "Update";
            this.Update.MinimumWidth = 6;
            this.Update.Name = "Update";
            this.Update.ReadOnly = true;
            this.Update.Text = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 93.1511F;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(1046, 74);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label7.Size = new System.Drawing.Size(286, 51);
            this.label7.TabIndex = 17;
            this.label7.Text = "Product Quantity";
            // 
            // Qty_box
            // 
            this.Qty_box.AutoRoundedCorners = true;
            this.Qty_box.BorderRadius = 20;
            this.Qty_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Qty_box.DefaultText = "";
            this.Qty_box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Qty_box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Qty_box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Qty_box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Qty_box.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(116)))), ((int)(((byte)(238)))));
            this.Qty_box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Qty_box.Font = new System.Drawing.Font("Courier New", 12F);
            this.Qty_box.ForeColor = System.Drawing.Color.Black;
            this.Qty_box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Qty_box.Location = new System.Drawing.Point(1052, 129);
            this.Qty_box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Qty_box.Name = "Qty_box";
            this.Qty_box.PasswordChar = '\0';
            this.Qty_box.PlaceholderText = "";
            this.Qty_box.SelectedText = "";
            this.Qty_box.Size = new System.Drawing.Size(280, 43);
            this.Qty_box.TabIndex = 18;
            this.Qty_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Filter_Box
            // 
            this.Filter_Box.AutoRoundedCorners = true;
            this.Filter_Box.BackColor = System.Drawing.Color.Transparent;
            this.Filter_Box.BorderColor = System.Drawing.Color.SpringGreen;
            this.Filter_Box.BorderRadius = 17;
            this.Filter_Box.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Filter_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Filter_Box.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(116)))), ((int)(((byte)(238)))));
            this.Filter_Box.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Filter_Box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Filter_Box.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold);
            this.Filter_Box.ForeColor = System.Drawing.SystemColors.Control;
            this.Filter_Box.ItemHeight = 30;
            this.Filter_Box.Location = new System.Drawing.Point(419, 201);
            this.Filter_Box.Name = "Filter_Box";
            this.Filter_Box.Size = new System.Drawing.Size(231, 36);
            this.Filter_Box.TabIndex = 19;
            // 
            // Filter
            // 
            this.Filter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Filter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Filter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Filter.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Filter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Filter.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.Filter.ForeColor = System.Drawing.Color.White;
            this.Filter.Location = new System.Drawing.Point(665, 195);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(180, 45);
            this.Filter.TabIndex = 20;
            this.Filter.Text = "Filter";
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.AutoRoundedCorners = true;
            this.SearchBox.BorderRadius = 23;
            this.SearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchBox.DefaultText = "";
            this.SearchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchBox.Location = new System.Drawing.Point(865, 189);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.PasswordChar = '\0';
            this.SearchBox.PlaceholderText = "";
            this.SearchBox.SelectedText = "";
            this.SearchBox.Size = new System.Drawing.Size(229, 48);
            this.SearchBox.TabIndex = 21;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.Location = new System.Drawing.Point(1114, 189);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(180, 45);
            this.guna2GradientButton1.TabIndex = 22;
            this.guna2GradientButton1.Text = "Search";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 74);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label3.Size = new System.Drawing.Size(184, 51);
            this.label3.TabIndex = 23;
            this.label3.Text = "Product_Id";
            // 
            // id_box
            // 
            this.id_box.AutoRoundedCorners = true;
            this.id_box.BorderRadius = 20;
            this.id_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.id_box.DefaultText = "";
            this.id_box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.id_box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.id_box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.id_box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.id_box.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(116)))), ((int)(((byte)(238)))));
            this.id_box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.id_box.Font = new System.Drawing.Font("Courier New", 12F);
            this.id_box.ForeColor = System.Drawing.Color.Black;
            this.id_box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.id_box.Location = new System.Drawing.Point(0, 136);
            this.id_box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.id_box.Name = "id_box";
            this.id_box.PasswordChar = '\0';
            this.id_box.PlaceholderText = "";
            this.id_box.SelectedText = "";
            this.id_box.Size = new System.Drawing.Size(221, 43);
            this.id_box.TabIndex = 24;
            this.id_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(457, -13);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(20);
            this.label2.Size = new System.Drawing.Size(388, 81);
            this.label2.TabIndex = 5;
            this.label2.Text = "Manage Product ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
           
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1365, 71);
            this.guna2Panel1.TabIndex = 2;
            // 
            // Products
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1365, 830);
            this.Controls.Add(this.id_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.Filter_Box);
            this.Controls.Add(this.Qty_box);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Product_List);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.category);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.Add_Btn);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.OrangeRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Products";
            this.Text = "Home_Page";
            ((System.ComponentModel.ISupportInitialize)(this.Product_List)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button Add_Btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox name;
        private Guna.UI2.WinForms.Guna2ComboBox category;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox price;
        private Guna.UI2.WinForms.Guna2Button Clear_btn;
        private Guna.UI2.WinForms.Guna2DataGridView Product_List;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox Qty_box;
        private Guna.UI2.WinForms.Guna2ComboBox Filter_Box;
        private Guna.UI2.WinForms.Guna2GradientButton Filter;
        private Guna.UI2.WinForms.Guna2TextBox SearchBox;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox id_box;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Quantity;
        private new System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}