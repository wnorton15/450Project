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

            String query;
            string connectionString;
            SqlConnection cnn;

            connectionString = @"Data Source=OWNER-PC;
                                Initial Catalog=IceDB;
                                integrated security=SSPI;
                                    persist security info=False;
                                    Trusted_Connection=Yes";

            query = "Select * from BusinessTypes;";


            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, cnn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "BusinessTypes");
            BusinessTypeCombo.DisplayMember = "BusinessType";
            BusinessTypeCombo.ValueMember = "ID";
            BusinessTypeCombo.DataSource = ds.Tables["BusinessTypes"];
            cnn.Close();
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
                    tbCustomerName.Text = myReader["CustomerName"].ToString();
                    tbStreetNumber.Text = myReader["StreetNumber"].ToString();
                    tbStreetName.Text = myReader["StreetName"].ToString();
                    tbCity.Text = myReader["City"].ToString();
                    tbZipCode.Text = myReader["ZipCode"].ToString();
                    BusinessTypeCombo.SelectedValue = int.Parse(myReader["BusinessType"].ToString());
                    tbCustomerPrice.Text = myReader["Price"].ToString();
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
            int streetNumber = int.Parse(tbStreetNumber.Text.Trim());
            int zipCode = int.Parse(tbZipCode.Text.Trim());
            string streetName = tbStreetName.Text.Trim();
            string city = tbCity.Text.Trim();
            float customerPrice;

            if (searchCustomerID == "")
            {
                MessageBox.Show("Search Error!!!",
                    "Username was not entered!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
            //validate the fields
            else if (customerName == "" || streetNumber == 0 
                || streetName == "" || city == "" 
                || zipCode == 0)
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
                    customerPrice = float.Parse(tbCustomerPrice.Text.Trim());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please enter a number for the price");
                    return;
                }

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
                        "BusinessType = '" + BusinessTypeCombo.SelectedValue + "', " +
                        "Price = '" + customerPrice + "'";

                    //add where statement to 
                    query2 = query2 + " Where CustomerID = '" + searchCustomerID + "'";

                    DialogResult dialogResult = MessageBox.Show("Are you sure you want " +
                        "to make these changes?", "Execute changes", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }

                    cnn = new SqlConnection(connectionString);
                    SqlCommand cmd = new SqlCommand(query2, cnn);

                    //open connection
                    cmd.Connection.Open();

                    //execute query
                    int numberEffectRow = cmd.ExecuteNonQuery();

                    //check if a record has been affected
                    if (numberEffectRow == 1)
                    {
                        MessageBox.Show("The customer information is updated!");
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
            tbZipCode.Clear();
            tbCustomerPrice.Clear();
        }
    }
}
