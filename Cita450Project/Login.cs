﻿using System;
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
                MessageBox.Show("Login Error!!!",
                    "Please check Username and Password!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                usernameTxtBox.Focus();
                return;
            }
            if (passwordTxtBox.Text == "")
            {
                MessageBox.Show("Login Error!!!",
                    "Please check Username and Password!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                passwordTxtBox.Focus();
                return;
            }
            try
            {
                string connectionString;

                SqlConnection cnn;

                //create connection string to connect to database
                //Change "Data Source" field to system name
                connectionString = @"Data Source=MAC18552;
                                Initial Catalog=IceDB;
                                integrated security=SSPI;
                                    persist security info=False;
                                    Trusted_Connection=Yes";

                //create query to enter into database
                //ask database if entered username and password exist
                string query = "SELECT Username,Password " +
                                "From Users WHERE " +
                                "Username = @Username AND " +
                                "Password = @Password";

                cnn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(query, cnn);

                //take user entered data
                string uName = usernameTxtBox.Text.Trim();
                string uPassword = passwordTxtBox.Text.Trim();

                //replace the @Username & @Password with user inputs
                cmd.Parameters.Add("@Username", SqlDbType.VarChar, 255).Value = uName;
                cmd.Parameters.Add("@Password", SqlDbType.VarChar, 255).Value = uPassword;

                //open connection
                cmd.Connection.Open();

                SqlDataReader myReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                if (myReader.Read() == true)
                {
                    //Take user to main menu
                    Clearfields();
                    this.Hide();
                    var mainMenu = new MainMenu();
                    mainMenu.Closed += (s, args) => this.Close();
                    mainMenu.Show();
                }
                else
                {
                    MessageBox.Show("Login Error!!!", 
                        "Please check Username and Password!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
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
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
    }
}
