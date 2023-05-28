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

            int price = 0, amount = 0;
            try
            {
                 price = Convert.ToInt32(totalPriceLbl.Text);
                 amount = Convert.ToInt32(paymentAmountLbl.Text);
            }
            catch
            {
                MessageBox.Show("Please check your inputted details");
            }
            if (customerName.Text == "")
            {
                MessageBox.Show("Please input a username");
            } else if (paymentAmountLbl.Text == "")
            {
              
             MessageBox.Show("Please input payment amount");
                
            }else if (totalPriceLbl.Text == "0" || totalPriceLbl.Text == "")
            {
                MessageBox.Show("Please try to order something");
            }else if (totalChange.Text == "")
            {
                MessageBox.Show("Please click the Okay button");

            }else if (price > amount)
            {
                MessageBox.Show("Invalid payment amount");
            }
            else
            {
                DateTime now = DateTime.Now;
                dataGridView1.Rows.Add(customerName.Text, totalPriceLbl.Text, paymentAmountLbl.Text, totalChange.Text, now.ToLongTimeString());
                //price.Visible = true;
            }

           
        }

        private void okayBtn_Click(object sender, EventArgs e)
        {
            int sum = 0, price = 0, amount = 0;
          try
            {
                sum = Convert.ToInt32(paymentAmountLbl.Text) - Convert.ToInt32(totalPriceLbl.Text);
                price = Convert.ToInt32(totalPriceLbl.Text);
                amount = Convert.ToInt32(paymentAmountLbl.Text);
            }
            catch 
            {
                MessageBox.Show("Please check your inputted details");            
            }
           

            if (price > amount)
            {
                MessageBox.Show("Invalid payment amount");
            }
            else if (amount > price || amount == price)
            {
                totalChange.Text = sum.ToString();
            }
            payBtn.Visible = true;
        }

        private void purchaseMoreBtn_Click(object sender, EventArgs e)
        {
            totalPriceLbl.Text = "";
            customerName.Text = "";
            paymentAmountLbl.Text = "";
            totalChange.Text = "";
        }

        private void paymentAmountLbl_TextChanged(object sender, EventArgs e)
        {
            payBtn.Visible = false;

        }
    }
}
