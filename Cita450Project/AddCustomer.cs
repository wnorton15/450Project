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
            int streetNumber;
            String streetName;
            String city;
            int zipCode;
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
            if (StreetNumberInput.Text.Trim().Equals(""))
            {
                CustomerAddressExists = false;
                streetNumber = 0;
                streetName = "";
                city = "";
                zipCode = 0;
            }
            else
            {
                CustomerAddressExists = true;
                try
                {
                    streetNumber = int.Parse(StreetNumberInput.Text.Trim());
                    zipCode = int.Parse(ZipCodeInput.Text.Trim());
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter a number for street number and zip code");
                    return;
                }
                streetName = StreetNameInput.Text.Trim();
                city = CityInput.Text.Trim();
            }
            

            customerName = CustomerNameInput.Text.Trim();

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
                query = "INSERT INTO Customers (CustomerName, StreetNumber, StreetName, City, ZipCode, Price) " +
                                    "VALUES ('" + customerName +"', " + streetNumber.ToString() + ", '" +  
                                    streetName + "', '" + city + "', " + zipCode.ToString() +
                                    ", " + customerPrice.ToString() + ")";
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
            StreetNumberInput.Text = "";
            StreetNameInput.Text = "";
            CityInput.Text = "";
            ZipCodeInput.Text = "";
            CustomerNameInput.Text = "";
            CustomerPriceInput.Text = "";
        }
    }
}
