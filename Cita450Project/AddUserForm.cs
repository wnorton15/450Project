using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
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
            //Pull and save the entered data
            string fName = fNameTxt.Text.Trim();
            string lName = lNameTxt.Text.Trim();
            string userN = userNameTxt.Text.Trim();
            string email = emailTxt.Text.Trim();
            string password = passwordTxtBox.Text.Trim();

            //validate the entered data

            //Connect to database to enter data
            string connectionString;
            
            SqlConnection cnn;

            connectionString = @"Data Source=Owner-PC;
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
            
            MessageBox.Show("User was Added!");
            
            cnn.Close();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
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
            this.Close();
        }
    }
}
