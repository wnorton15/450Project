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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString;

                SqlConnection cnn;

                //create connection string to connect to database
                //Change "Data Source" field to system name
                connectionString = @"Data Source=OWNER-PC;
                Initial Catalog=IceDB;
                integrated security=False;
                persist security info=False;
                Trusted_Connection=Yes";

                //take user entered data
                string searchCustomerID = tbCustomer.Text.Trim();

                //create query to enter into database
                //ask database if entered username and password exist
                string query = "select * from Customers where CustomerID = " + searchCustomerID;

                cnn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(query, cnn);

                //open connection
                cmd.Connection.Open();

                //set up reader to read output of DBMS
                SqlDataReader myReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                if (myReader.HasRows)
                {
                    //Read off and set the values of the customer record
                    myReader.Read();
                    tbCustomerName.Text = myReader.GetValue(1).ToString();
                    tbStreetNumber.Text = myReader.GetValue(2).ToString();
                    tbStreetName.Text = myReader.GetValue(3).ToString();
                    tbCity.Text = myReader.GetValue(4).ToString();
                    tbZipCode.Text = myReader.GetValue(5).ToString();
                    tbBusinessType.Text = myReader.GetValue(5).ToString();
                    nudPrice.Value = decimal.Parse(myReader.GetValue(6).ToString());
                }
                else
                {
                    MessageBox.Show("Search Error!!!",
                        "CustomerID does not Exist",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                }

                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string searchCustomerID = tbCustomer.Text.Trim();
            string customerName = tbCustomerName.Text.Trim();
            string streetNumber = tbStreetNumber.Text.Trim();
            string streetName = tbStreetName.Text.Trim();
            string city = tbCity.Text.Trim();
            string zipCode = tbZipCode.Text.Trim();
            string businessType = tbBusinessType.Text.Trim();
            decimal price = nudPrice.Value;

            if (searchCustomerID == "")
            {
                MessageBox.Show("Search Error!!!",
                    "Username was not entered!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
            //validate the fields
            else if (customerName == "" || streetNumber == "" 
                || streetName == "" || city == "" 
                || zipCode == "" || businessType == "")
            {
                MessageBox.Show("Save Error!!!",
                    "field was not entered!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string connectionString;

                    SqlConnection cnn;

                    //create connection string to connect to database
                    //Change "Data Source" field to system name
                    connectionString = @"Data Source=OWNER-PC;
                    Initial Catalog=IceDB;
                    integrated security=False;
                    persist security info=False;
                    Trusted_Connection=Yes";

                    //create query to enter into database
                    //ask if an account matches 

                    //set the values of the entered data into the database query
                    string query2 = "UPDATE Customers " +
                        "SET CustomerName = '" + customerName + "', " +
                        "StreetNumber = '" + streetNumber + "', " +
                        "StreetName = '" + streetName + "', " +
                        "City = '" + city + "', " +
                        "ZipCode = '" + zipCode + "', " +
                        "BusinessType = '" + businessType + "', " +
                        "Price = '" + price + "'";

                    //add where statement to 
                    query2 = query2 + " Where Username = '" + searchCustomerID + "'";

                    cnn = new SqlConnection(connectionString);
                    SqlCommand cmd = new SqlCommand(query2, cnn);

                    //open connection
                    cmd.Connection.Open();

                    SqlDataReader myReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    if (myReader.HasRows)
                    {
                        MessageBox.Show("Saved",
                            "Your changes were " +
                            "successfully changed!");
                        clearfields();
                    }
                    else
                    {
                        MessageBox.Show("Search Error!!!",
                            "Username does not Exist",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                    }

                    if (cnn.State == ConnectionState.Open)
                    {
                        cnn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearfields();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void clearfields()
        {
            //set all fields to ""
            tbCustomerName.Clear();
            tbStreetNumber.Clear();
            tbStreetName.Clear();
            tbCity.Clear();
            tbBusinessType.Clear();
            decimal Price = 0; 
            nudPrice.Value = Price;
        }
    }
}
