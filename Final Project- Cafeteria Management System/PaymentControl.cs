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
    public partial class PaymentControl : UserControl
    {
       
        public PaymentControl()
        {
            InitializeComponent();

            
        }
        
            

        private void totalTxt_Click(object sender, EventArgs e)
        {
           
            //overallTotalCost += drinksControl1.drinksOverallTotalCost;
        }

        private void checkTotalBtn_Click(object sender, EventArgs e)
        {
            totalCost.Text = totalTxt.Text;

        }

      
    }
}
