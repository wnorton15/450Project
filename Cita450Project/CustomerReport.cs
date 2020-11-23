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
    public partial class CustomerReport : Form
    {
        public CustomerReport()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {

        }
        private void clearfields()
        {
            //set all fields to ""
            tbName.Clear();
            tbCity.Clear();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Messagebox()
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
