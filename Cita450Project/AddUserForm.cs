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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Pull and save the entered data
                string fName = fNameTxt.Text.Trim();
                string lName = lNameTxt.Text.Trim();
                string userN = userNameTxt.Text.Trim();
                string email = emailTxt.Text.Trim();
                string password = passwordTxtBox.Text.Trim();
                int passNum = password.Count(char.IsLetter);
                int userNum = userN.Count(char.IsLetter);

                //Connect to database to enter data
                string connectionString;

                SqlConnection cnn;

                //validate information entered
                //validate if all fields are filled
                if (fName == "" || lName == "" || userN == "" || email == "" || password == "")
                {
                    MessageBox.Show("Please check if all values are filled");
                }
                //validate that names have no numbers

                //having trouble getting this working
                else if (Regex.IsMatch(fName, @"^\d+$") || Regex.IsMatch(lName, @"^\d+$"))
                {
                    MessageBox.Show("Please check if first or last name have no numbers");
                }
                //validate if the password is between 4 and 15 characters
                else if(userNum > 10 || userNum < 4)
                {
                    MessageBox.Show("Please check if Username is " +
                        "between 4 and 15 characters long");
                }
                else if(passNum > 15 || passNum < 3)
                {
                    MessageBox.Show("Please check if Password is " +
                        "between 3 and 10 characters long");
                }
                //validate if email ends in ".com"
                else if(email.EndsWith(".com"))
                {
                    connectionString = @"Data Source=MAC18552;
                Initial Catalog=IceDB;
                integrated security=False;
                persist security info=False;
                Trusted_Connection=Yes";
                    cnn = new SqlConnection(connectionString);

                    //create query to enter into database
                    string query = "INSERT INTO Users " +
                                    "(LastName, FirstName, Username, UserPassword, Email) " +
                                    "VALUES (@LastName,  @FirstName, @Username, @UserPassword, @Email) ";

                    SqlCommand cmd = new SqlCommand(query, cnn);

                    //replace the @values with the one

                    cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 255).Value = lName;

                    cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 255).Value = fName;

                    cmd.Parameters.Add("@Username", SqlDbType.VarChar, 255).Value = userN;

                    cmd.Parameters.Add("@UserPassword", SqlDbType.VarChar, 255).Value = password;

                    cmd.Parameters.Add("@Email", SqlDbType.VarChar, 255).Value = email;

                    cnn.Open();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("User was successfully added!");

                    cnn.Close();

                    Clearfields();
                }
                else
                {
                    MessageBox.Show("Please make sure your email ends with .com");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Clearfields();
        }

        public void Clearfields()
        {
            //set all fields to ""
            fNameTxt.Clear();
            lNameTxt.Clear();
            userNameTxt.Clear();
            emailTxt.Clear();
            passwordTxtBox.Clear();
        }

        private void PasswordChk_CheckedChanged(object sender, EventArgs e)
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

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
        }
    }
}
