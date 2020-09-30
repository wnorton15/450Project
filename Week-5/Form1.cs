using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add x to y and  dispaly the result
            int sales = 1000;

            int bouns = 0;

            if (sales > 50000)//condition is true
            {
                bouns = 500;
            }
            else//condition is false
            {
                bouns = 100;
            }

            MessageBox.Show("bouns= " +  bouns.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddCustomer fm = new AddCustomer();
            fm.Show();
        }
    }
}
