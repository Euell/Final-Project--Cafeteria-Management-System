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
          
            dataGridView1.Rows.Add(customerName.Text, totalPriceLbl.Text, paymentAmountLbl.Text, totalChange.Text, DateTime.Now.ToString());
            //price.Visible = true;
        }

        private void okayBtn_Click(object sender, EventArgs e)
        {
          
            int sum = Convert.ToInt32(paymentAmountLbl.Text) - Convert.ToInt32(totalPriceLbl.Text);
           
            int price, amount;
            price = Convert.ToInt32(totalPriceLbl.Text);
            amount = Convert.ToInt32(paymentAmountLbl.Text);
            if (price > amount)
            {
                MessageBox.Show("Invalid amount");
            }
            else if (amount > price)
            {
                totalChange.Text = sum.ToString();
            }
        }

        private void purchaseMoreBtn_Click(object sender, EventArgs e)
        {
            totalPriceLbl.Text = "0";
            customerName.Text = "";
           
        }
    }
}
