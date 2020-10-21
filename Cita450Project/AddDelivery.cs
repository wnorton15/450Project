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
    public partial class AddDelivery : Form
    {
        public AddDelivery()
        {
            InitializeComponent();
            String query;
            string connectionString;
            SqlConnection cnn;

            connectionString = @"Data Source=MAC18552;
                                Initial Catalog=IceDB;
                                integrated security=SSPI;
                                    persist security info=False;
                                    Trusted_Connection=Yes";

            query = "Select * from Customers;";


            cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, cnn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Customers");
            CustomerComboBox.DisplayMember = "CustomerName";
            CustomerComboBox.ValueMember = "CustomerID";
            CustomerComboBox.DataSource = ds.Tables["Customers"];
            cnn.Close();
            DateInput.Format = DateTimePickerFormat.Custom;
            DateInput.CustomFormat = "yyyy-MM-dd";
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            String query;
            SqlConnection cnn;
            String connectionString = @"Data Source=MAC18552;
                                Initial Catalog=IceDB;
                                integrated security=SSPI;
                                    persist security info=False;
                                    Trusted_Connection=Yes";
            int numberOfBags = 0;
            try
            {
                numberOfBags = int.Parse(NumberOfBagsInput.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a number for number of bags");
                return;
            }

            if (numberOfBags < 1)
            {
                MessageBox.Show("Please enter a number for number of bags");
                return;
            }
            
            query = "INSERT INTO Deliveries (CustomerID, NumberOfBags, CustomerPaid, DeliveryDate)" +
                    "VALUES (" + CustomerComboBox.SelectedValue.ToString() + ", " + numberOfBags.ToString() +
                    ", '" + CustomerPaidComboBox.SelectedItem + "', '" + DateInput.Text + "')";
            
            cnn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Delivery was successfully added!");
            cnn.Close();
            Clear();
            
        }

        private void Clear()
        {
            CustomerComboBox.SelectedText = "";
            DateInput.Text = "";
            NumberOfBagsInput.Text = "";
            CustomerPaidComboBox.SelectedText = "";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
