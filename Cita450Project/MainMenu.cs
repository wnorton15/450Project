using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cita450Project
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 addUserForm = new Form1();
            addUserForm.Show();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
        }

        private void custumerOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void signInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new Login();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        private void updateUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateUser updateUser = new UpdateUser();
            updateUser.Show();
        }
    }
}
