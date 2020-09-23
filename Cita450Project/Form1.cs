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
    public partial class Form1 : Form
    {

        
        SqlConnection cnn;
        string connectionString = @"Data Source=Cita450.Project.Pankow;
            Initial Catalog=Users;
            integrated security info=False;
                persist security info=False;
                Trusted_Connection=Yes";
        cnn = new SqlConnection(connectionString);


        public Form1()
        {
            InitializeComponent();
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            //Pull and save the entered data
            string fName = fNameTxt.ToString();
            string lName = lNameTxt.ToString();
            string userN = userNameTxt.ToString();
            string email = emailTxt.ToString();
            string password = passwordTxtBox.ToString();

            //validate the entered data

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

        private void BackBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
