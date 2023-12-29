﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;
using System.Xml.Linq;

namespace InventoryManagementSysrem
{
    public class Billing
    {
        public string connectionString()
        {
            return "Data Source=localhost\\sqlexpress;Initial Catalog=MyLogin;Integrated Security=True";
        }

        public DataTable viewData(string query)
        {
            SqlConnection conn = new SqlConnection(connectionString());

            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                return dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Errorr while establishing the connection" + ex.Message);
                return null;
            }

            finally { conn.Close(); }
        }

        public int checkquantity(int quantity, string product_name)
        {
            int available = 0;
            string query = "SELECT Product_Quantity FROM Product_Details WHERE Product_Name = '" + product_name + "' ";
            SqlConnection conn = new SqlConnection(connectionString());
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    available = Convert.ToInt32(reader["Product_Quantity"]);
                }
                return available;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Canot read Product quantity in your database" + ex.Message);
                return available;
            }
            finally { conn.Close(); }
        }

        public void performoperation(string query)
        {
            SqlConnection conn = new SqlConnection(connectionString());

            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failled" + ex.Message);
            }
        }

        public int FetchCurrentQuantity(string name)
        {
            int currentQuantity=0;
            SqlConnection conn = new SqlConnection(connectionString());
            string query = "SELECT * FROM Product_Details WHERE Product_Name= '" + name + "'";

            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                 SqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    currentQuantity = Convert.ToInt32(reader["Product_Quantity"]);
                }
            } 
            catch(Exception ex)
            {
                MessageBox.Show("Cannot read the current quantity from database" + ex.Message);
            }
            return currentQuantity;
        }

        public void UpdateStock(string name , int quantity)
        {
            int newquantity = FetchCurrentQuantity(name)-quantity;
            SqlConnection conn = new SqlConnection(connectionString());
            string query = "UPDATE  Product_Details SET Product_Quantity = '" + newquantity + "' WHERE Product_Name='" + name + "'";

            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failled" + ex.Message);
            }
        }

        public int FetchLastBillId()
        {
            SqlConnection conn = new SqlConnection(connectionString());
            string query = "SELECT TOP 1 ID FROM BillTable ORDER BY ID DESC ";
            int lastid = 0;
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lastid = Convert.ToInt32(reader["ID"]);
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("LastId fetching error" + ex.Message);
            }
            return lastid+1;
        }
    }
}
