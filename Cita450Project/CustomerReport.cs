using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cita450Project
{
    public partial class CustomerReport : Form
    {
        public CustomerReport()
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

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void clearfields()
        {
            //set all fields to ""
            tbName.Clear();
            tbCity.Clear();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearfields();
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

                //create query to enter into database
                string query = "select c.CustomerID, c.CustomerName, " +
                    "c.StreetNumber, StreetName, c.City, c.ZipCode, " +
                    "b.BusinessType, c.Price" +
                    " from Customers as c join BusinessTypes as b on " +
                    "c.BusinessType = b.ID WHERE ";

                //recieve the input from the user
                string name = tbName.Text.Trim();
                string city = tbCity.Text.Trim();

                //add where fields to query
                if (BusinessTypeCombo.SelectedIndex == 0)
                {
                    //display all of the business types
                    query = query + "c.CustomerName LIKE '" + name + "%' and " +
                        "c.City LIKE '" + city + "%' and c.BusinessType >= 0";
                }
                else
                {
                    //display only the searched business type
                    query = query + "c.CustomerName LIKE '" + name + "%' and " +
                        "c.City LIKE '" + city + "%' and c.BusinessType = " +
                        BusinessTypeCombo.SelectedIndex;
                }

                cnn = new SqlConnection(connectionString);

                SqlDataAdapter da = new SqlDataAdapter(query, cnn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Customers");
                dgvCustomers.DataSource = ds.Tables["Customers"].DefaultView;
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
