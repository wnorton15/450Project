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
    public partial class UpdateUser : Form
    {
        public UpdateUser()
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

                //create query to enter into database
                //ask database if entered username and password exist
                string query = "select * from Users where Username = @Username";

                cnn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(query, cnn);

                //take user entered data
                string searchUsername = tbUser.Text.Trim();

                //replace the @Username & @Password with user inputs
                cmd.Parameters.Add("@Username", SqlDbType.VarChar, 255).Value = searchUsername;

                //open connection
                cmd.Connection.Open();

                SqlDataReader myReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                if (myReader.HasRows)
                {
                    myReader.Read();
                    tbLastName.Text = myReader["LastName"].ToString();
                    tbFirstName.Text = myReader["FirstName"].ToString();
                    tbUsername.Text = myReader["Username"].ToString();
                    tbPassword.Text = myReader["Password"].ToString();
                    tbEmail.Text = myReader["Email"].ToString();
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string searchUsername = tbUsername.Text.Trim();
            string username = tbUser.Text.Trim();
            string lastName = tbLastName.Text.Trim();
            string firstName = tbFirstName.Text.Trim();
            string password = tbPassword.Text.Trim();
            string email = tbEmail.Text.Trim();

            if (searchUsername == "")
            {
                MessageBox.Show("Search Error!!!",
                    "Username was not entered!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
            //validate the fields
            else if (username == "" || password == "" || email == "" || firstName == "" || lastName == "" )
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

                    //ask database if entered username and password exist
                    string query2 = "UPDATE Users " +
                        "SET LastName = '" + lastName + "', " +
                        "FirstName = '" + firstName + "', " +
                        "Username = '" + username + "', " +
                        "Password = '" + password + "', " +
                        "Email = '" + email + "'";
                    query2 = query2 + " Where Username = '" + searchUsername + "'";

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
                    int numberEffectRow= cmd.ExecuteNonQuery();

                    //check if a record has been affected
                    if(numberEffectRow == 1)
                    {
                        MessageBox.Show("The account is updated!");
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

        private void clearfields()
        {
            //set all fields to ""
            tbEmail.Clear();
            tbFirstName.Clear();
            tbUser.Clear();
            tbUsername.Clear();
            tbLastName.Clear();
            tbPassword.Clear();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearfields();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void ckboxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            //grab text box property password char
            char passwordChar = tbPassword.PasswordChar;
            //convert "*" to char 
            string str = "*";
            char character = char.Parse(str);
            //compare passwordChar to character
            if (passwordChar == character)
            {
                //if yes, change to ""
                tbPassword.PasswordChar = '\u0000';
            }

            else
            {
                //else remain "*"
                tbPassword.PasswordChar = character;
            }
        }
    }
}
