using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project__Cafeteria_Management_System
{
    public partial class paymentControl1 : UserControl
    {
        public paymentControl1()
        {
            InitializeComponent();
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            int sum = Convert.ToInt32(amount.Text) - Convert.ToInt32(paymentAmount.Text);

            totalPayment.Text = sum.ToString();
        }
    }
}
