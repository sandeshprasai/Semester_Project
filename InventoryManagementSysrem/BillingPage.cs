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
using System.Xml.Linq;
using System.Drawing.Printing;

namespace InventoryManagementSysrem
{
    public partial class BillingPage : Form
    {
        Billing bill;
        private int id;
        private float grand_total = 0;
        int user_selling = 0;
        string UserName;
        PrintDocument printDocument;
        public BillingPage(string Username)
        {
            InitializeComponent();

            bill = new Billing();
            id = bill.FetchLastBillId();
            user_selling = bill.FetchUserSelling(Username);
            ViewData();
            UserName = Username;
            printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

        }
        public void performclearoperation()
        {
            Name_Box.Clear();
            PriceBox.Clear();
            QuantityBox.Clear();
        }
        public void ViewData()
        {
            //loads the available products from the products table
            try
            {
                string query = "SELECT Product_Name,Product_Price,Product_Quantity FROM Product_Details";
                Product_List.DataSource = bill.viewData(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Load data" + ex.Message);
            }
        }

        private void Product_List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //select the cell item if the cell is clicked
            if (e.RowIndex != -1)
            {
                DataGridViewRow PL = Product_List.Rows[e.RowIndex];
                Name_Box.Text = PL.Cells[0].Value.ToString();
                PriceBox.Text = PL.Cells[1].Value.ToString();


            }
        }

        private void AddBill_Click(object sender, EventArgs e)
        {
            //checks if the textboxes are empty
            if (string.IsNullOrWhiteSpace(Name_Box.Text) ||
                string.IsNullOrWhiteSpace(PriceBox.Text) ||
                string.IsNullOrWhiteSpace(QuantityBox.Text)
                )
            {
                MessageBox.Show("Please selet the product to add and fill up the quantity ");
            }

            // if not empty the input from text boxes are taken
            else
            {
                string name;
                float price;
                int quantity;
                try
                {
                    name = Name_Box.Text;
                    price = float.Parse(PriceBox.Text);
                    quantity = Convert.ToInt32(QuantityBox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid input format. Please enter valid values." + ex.Message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // checks the availabe quantity in the inventory database
                int available = bill.checkquantity(quantity, name);

                //checks if the added data are already added in billing list
                foreach (DataGridViewRow row in BillBox.Rows)
                {
                    //if the product is existed in the billing list it asks user if he wants to update products
                    if (row.Cells["NameColumn"].Value.ToString() == name)
                    {
                        DialogResult result = MessageBox.Show("Product already exists in the bill. Do you want to update the quantity?", "Product Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        //if user clicks yes it update the product
                        if (result == DialogResult.Yes)
                        {

                            int existingQuantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                            int newquantity = existingQuantity + quantity;
                            // checking if the updating quantity is sufficient or not 
                            if (newquantity <= available)
                            {
                                row.Cells["Quantity"].Value = newquantity;


                                float total = price * quantity;
                                grand_total += total;
                                user_selling += quantity;
                                LabelTotal.Text = grand_total.ToString();
                                performclearoperation();
                                return;
                            }

                            else
                            {
                                MessageBox.Show("Insufficient quantity in inventory: Available quantity is" + available, "Insufficient Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                performclearoperation();
                                return;
                            }


                        }

                        // if user clicks no the process is exited
                        else
                        {
                            performclearoperation();
                            return;
                        }
                    }
                }

                // if the product is not existed in the billing list this part is execueted
                if (quantity <= available)
                {
                    try
                    {
                        float total = price * quantity;
                        BillBox.Rows.Add(id, name, price, quantity, total);
                        grand_total = total + grand_total;
                        user_selling += quantity;
                        id++;
                        LabelTotal.Text = grand_total.ToString();
                        MessageBox.Show("Product Addeed ", "Sucessfull", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding item to bill: " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    finally
                    {
                        performclearoperation();
                    }
                }

                else
                {
                    MessageBox.Show("Insufficient quantity in inventory: Available quantity is " + available, "Insufficient Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            float minus_price = 0;
            int minus_Quantity = 0;
            try
            {

                if (BillBox.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = BillBox.SelectedRows[0];
                    minus_price = float.Parse(selectedRow.Cells["Total"].Value.ToString());
                    minus_Quantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value.ToString());
                    BillBox.Rows.Remove(BillBox.SelectedRows[0]);
                    grand_total -= minus_price;
                    user_selling -= minus_Quantity;
                    LabelTotal.Text = grand_total.ToString();
                }
                else
                {
                    MessageBox.Show("Please select a row to remove.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing item from bill: " + ex.Message);
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {

            if (BillBox.Rows.Count == 0)
            {
                MessageBox.Show("Please Add product to the billing table:", "Empty Product List", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                try
                {
                    foreach (DataGridViewRow row in BillBox.Rows)
                    {
                        string name = row.Cells["NameColumn"].Value.ToString();
                        float price = float.Parse(row.Cells["PriceColumn"].Value.ToString());
                        int quantity = Convert.ToInt32(row.Cells["Quantity"].Value.ToString());
                        float total = float.Parse(row.Cells["Total"].Value.ToString());
                        string query = "INSERT INTO BillTable (Name, Price, Quantity, Total,Date) VALUES ('" + name + "','" + price + "','" + quantity + "','" + total + "','" + DateTime.Now + "')";
                        bill.performoperation(query);
                        bill.UpdateStock(name, quantity);
                        ViewData();

                    }
                    bill.UpdateUserSelling(UserName, user_selling);
                    PrintDialog printDialog = new PrintDialog();
                    printDialog.Document = printDocument;

                    if (printDialog.ShowDialog() == DialogResult.OK)
                    {
                        printDocument.Print(); // Print the document
                    }
                    MessageBox.Show("Bill added to database ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)

                {
                    MessageBox.Show("Failled to print bill " + ex.Message);
                }

                BillBox.Rows.Clear();
            }
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font headingFont = new Font("Courier New", 16, FontStyle.Bold);
            Font itemFont = new Font("Courier New", 12);
            Font totalFont = new Font("Courier New", 14, FontStyle.Bold);
            float centerX = e.PageBounds.Width / 2;
            e.Graphics.DrawString("Invoice", headingFont, Brushes.Black, centerX - 40, 10);
            e.Graphics.DrawString($"Date: {DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss tt")}", new Font("Courier New", 12), Brushes.Black, centerX - 40, 60);
            e.Graphics.DrawString($"User: {UserName}", new Font("Courier New", 12), Brushes.Black, centerX - 40, 80);
            e.Graphics.DrawString("Name", headingFont, Brushes.Black, 100, 120);
            e.Graphics.DrawString("Price", headingFont, Brushes.Black, 350, 120);
            e.Graphics.DrawString("Quantity", headingFont, Brushes.Black, 450, 120);
            e.Graphics.DrawString("Total", headingFont, Brushes.Black, 600, 120);
            int yPos = 150;
            foreach (DataGridViewRow row in BillBox.Rows)
            {
                string name = row.Cells["NameColumn"].Value.ToString();
                float price = float.Parse(row.Cells["PriceColumn"].Value.ToString());
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value.ToString());
                float total = float.Parse(row.Cells["Total"].Value.ToString());
                string nameLine = $"{name}";
                string priceLine = $"{price:F2}";
                string quantityLine = $"{quantity}";
                string totalLine = $"{total:F2}";
                using (Pen dashedPen = new Pen(Brushes.Black))
                {
                    dashedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    e.Graphics.DrawLine(dashedPen, 10, yPos, e.PageBounds.Width - 10, yPos);
                }
                e.Graphics.DrawString(nameLine, itemFont, Brushes.Black, 100, yPos + 15);
                e.Graphics.DrawString(priceLine, itemFont, Brushes.Black, 350, yPos + 15);
                e.Graphics.DrawString(quantityLine, itemFont, Brushes.Black, 450, yPos + 15);
                e.Graphics.DrawString(totalLine, itemFont, Brushes.Black, 600, yPos + 15);
                yPos += 40; 
            }
            using (Pen dashedPen = new Pen(Brushes.Black))
            {
                dashedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                e.Graphics.DrawLine(dashedPen, 10, yPos, e.PageBounds.Width - 10, yPos);
            }
            yPos += 10; 
            e.Graphics.DrawString($"Grand Total: {grand_total:F2}", totalFont, Brushes.Black, centerX - 40, yPos + 10);
        }
    }
    }
