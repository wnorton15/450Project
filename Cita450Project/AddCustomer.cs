using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cita450Project
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void SubmitCustomer_Click(object sender, EventArgs e)
        {
            String customerName;
            String customerAddress;
            float customerPrice;
            bool CustomerAddressExists;
            String query;
            string connectionString;
            SqlConnection cnn;

            if (CustomerPriceInput.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter a price");
                return;
            }
            if(CustomerNameInput.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter a customer name");
                return;
            }
            if (CustomerAddressInput.Text.Trim().Equals(""))
            {
                CustomerAddressExists = false;
            }
            else
            {
                CustomerAddressExists = true;
            }

            customerName = CustomerNameInput.Text.Trim();
            customerAddress = CustomerAddressInput.Text.Trim();

            try
            {
                customerPrice = float.Parse(CustomerPriceInput.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a number for the price");
                return;
            }
            
            connectionString = @"Data Source=MAC18552;
                                Initial Catalog=IceDB;
                                integrated security=SSPI;
                                    persist security info=False;
                                    Trusted_Connection=Yes";

            if (CustomerAddressExists)
            {
                query = "INSERT INTO Customers (CustomerName, CustomerAddress, Price) " +
                                    "VALUES ('" + customerName +"', '" + customerAddress + 
                                    "', " + customerPrice.ToString() + ")";
            }
            else
            {
                query = "INSERT INTO Customers (CustomerName, Price)" +
                    "VALUES ('" + customerName + "', " + customerPrice.ToString() + ")";
            }
            
            cnn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Customer was successfully added!");
            cnn.Close();
            Clear();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clear()
        {
            CustomerAddressInput.Text = "";
            CustomerNameInput.Text = "";
            CustomerPriceInput.Text = "";
        }
    }
}
