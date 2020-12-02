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
    public partial class AddOrder : Form
    {
        public AddOrder()
        {
            InitializeComponent();
            DatabaseConnection databaseConnection = new DatabaseConnection();
            SqlDataAdapter adapter = databaseConnection.SelectAdapterFromDB("Select * from Customers;");
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Customers");
            CustomerComboBox.DisplayMember = "CustomerName";
            CustomerComboBox.ValueMember = "CustomerID";
            CustomerComboBox.DataSource = ds.Tables["Customers"];
            DateInput.Format = DateTimePickerFormat.Custom;
            DateInput.CustomFormat = "yyyy-MM-dd";
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            String query = "INSERT INTO Orders (CustomerID, OrderDate)" +
                    "VALUES (" + CustomerComboBox.SelectedValue.ToString() + ", '" + DateInput.Text + "')";
            databaseConnection.RunQueryonDB(query);
            MessageBox.Show("Order was successfully added");
        }

    }
}
