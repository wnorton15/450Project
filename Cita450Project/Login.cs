using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cita450Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            //grab text box property password char
            char passwordChar = passwordTxtBox.PasswordChar;
            //convert "*" to char 
            string str = "*";
            char character = char.Parse(str);
            //compare passwordChar to character
            if (passwordChar == character)
            {
                //if yes, change to ""
                passwordTxtBox.PasswordChar = '\u0000';
            }

            else
            {
                //else remain "*"
                passwordTxtBox.PasswordChar = character;
            }
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (usernameTxtBox.Text == "")
            {
                MessageBox.Show("Please enter username", "Error");
                usernameTxtBox.Focus();
                return;
            }
            if (passwordTxtBox.Text == "")
            {
                MessageBox.Show("Please enter password", "Error");
                passwordTxtBox.Focus();
                return;
            }
            try
            {

                //Connect to database to enter data
                string connectionString;

                SqlCommand myCommand = default(SqlCommand);

                SqlConnection cnn;

                //Change "Data Source" field to system name
                connectionString = @"Data Source=MAC18552;
                Initial Catalog=IceDB;
                integrated security=False;
                persist security info=False;
                Trusted_Connection=Yes";
                cnn = new SqlConnection(connectionString);

                //create query to enter into database
                //ask database if entered username and password exist
                string query = "SELECT Username,Password " +
                                "From Users WHERE" +
                                "Username = @Username AND" +
                                "Password = @Password";

                //Create new SQL parameter
                SqlParameter uName = new SqlParameter("@Username", SqlDbType.VarChar);
                SqlParameter uPassword = new SqlParameter("@Password", SqlDbType.VarChar);

                //take user entered data
                uName.Value = usernameTxtBox.Text;
                uPassword.Value = passwordTxtBox.Text;

                //replace @Username,@Password in query with User entered data
                myCommand.Parameters.Add(uName);
                myCommand.Parameters.Add(uPassword);

                SqlCommand cmd = new SqlCommand(query, cnn);

                cnn.Open();

                SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

                if (myReader.Read() == true)
                {
                    MessageBox.Show("Login Successful, Welcome " + usernameTxtBox.Text);
                    //Take user to main menu
                    Clearfields();
                }

                else
                {
                    MessageBox.Show("Login Error!!!", "Please check Username and Password!");
                    Clearfields();
                }
                if(cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clearfields();
        }

        private void Clearfields()
        {
            //set all fields to ""
            usernameTxtBox.Clear();
            passwordTxtBox.Clear();
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            Form1 addUser = new Form1();
            addUser.Show();
        }
    }
}
