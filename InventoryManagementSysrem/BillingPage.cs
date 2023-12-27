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

namespace InventoryManagementSysrem
{
    public partial class BillingPage : Form
    {
        Billing bill = new Billing();
        private int id = 1;
        private float grand_total = 0;
        public BillingPage()
        {
            InitializeComponent();
            ViewData();

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
                string.IsNullOrWhiteSpace(PriceBox.Text)||
                string.IsNullOrWhiteSpace(QuantityBox.Text)
                )
            {
                MessageBox.Show("Please selet the product to add and fill up the quantity ");
            }

                    // if not empty the input from text boxes are taken
            else
            {
                string name = Name_Box.Text;
                float price = float.Parse(PriceBox.Text);
                int quantity = Convert.ToInt32(QuantityBox.Text);

                // checks the availabe quantity in the inventory database
                int available = bill.checkquantity(quantity, name);

                //checks if the added data are already added in billing list
                foreach (DataGridViewRow row in BillBox.Rows)
                {
                    //if the product is existed in the billing list it asks user if he wants to update products
                    if( row.Cells["NameColumn"].Value.ToString() == name)
                    {
                        DialogResult result = MessageBox.Show("Product already exists in the bill. Do you want to update the quantity?", "Product Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        //if user clicks yes it update the product
                        if (result == DialogResult.Yes)
                        {
                           
                            int existingQuantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                            int newquantity= existingQuantity + quantity;
                            // checking if the updating quantity is sufficient or not 
                            if(newquantity<= available)
                            {
                                row.Cells["Quantity"].Value = newquantity;


                                float total = price * quantity;
                                grand_total += total;

                                LabelTotal.Text = grand_total.ToString();
                                performclearoperation();
                                return;
                            }

                            else
                            {
                                MessageBox.Show("Insufficient quantity in inventory: Available quantity is" + available,"Insufficient Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (quantity <= available )
                {
                    try
                    {
                        float total = price * quantity;
                        BillBox.Rows.Add(id, name, price, quantity, total);
                        grand_total = total + grand_total;
                        id++;
                        LabelTotal.Text = grand_total.ToString();
                        MessageBox.Show("Product Addeed ", "Sucessfull", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding item to bill: " + ex.Message, "error", MessageBoxButtons.OK ,MessageBoxIcon.Information);
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
            try
            {
              
                if (BillBox.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = BillBox.SelectedRows[0];
                    minus_price = float.Parse(selectedRow.Cells["Total"].Value.ToString()); 
                    BillBox.Rows.Remove(BillBox.SelectedRows[0]);
                    grand_total-= minus_price;
                    LabelTotal.Text=grand_total.ToString();
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
    }
}
