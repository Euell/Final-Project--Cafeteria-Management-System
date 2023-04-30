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
    public partial class MainControl : UserControl
    {
        public MainControl()
        {
            InitializeComponent();
        }

        private void eggSandwichBtn_Click(object sender, EventArgs e)
        {
            eggSandwich.Visible = true;
            int amount = Convert.ToInt32(eggSandwich.Text);
            int increment = amount + 1;
            eggSandwich.Text = Convert.ToString(increment);
        }

        private void cheeseSandwichBtn_Click(object sender, EventArgs e)
        {
            cheeseSandwich.Visible = true;
            int amount = Convert.ToInt32(cheeseSandwich.Text);
            int increment = amount + 1;
            cheeseSandwich.Text = Convert.ToString(increment);
        }

        private void chickenSandwichBtn_Click(object sender, EventArgs e)
        {
            chickenSandwich.Visible = true;
            int amount = Convert.ToInt32(chickenSandwich.Text);
            int increment = amount + 1;
            chickenSandwich.Text = Convert.ToString(increment);
        }

        private void vegSandwichBtn_Click(object sender, EventArgs e)
        {
            vegSandwich.Visible = true;
            int amount = Convert.ToInt32(vegSandwich.Text);
            int increment = amount + 1;
            vegSandwich.Text = Convert.ToString(increment);
        }

        private void eggAndCheeseSandwichBtn_Click(object sender, EventArgs e)
        {
            eggAndCheeseSandwich.Visible = true;
            int amount = Convert.ToInt32(eggAndCheeseSandwich.Text);
            int increment = amount + 1;
            eggAndCheeseSandwich.Text = Convert.ToString(increment);
        }

        private void vegAndCheeseSandwichBtn_Click(object sender, EventArgs e)
        {
            vegAndCheeseSandwich.Visible = true;
            int amount = Convert.ToInt32(vegAndCheeseSandwich.Text);
            int increment = amount + 1;
            vegAndCheeseSandwich.Text = Convert.ToString(increment);
        }

        private void chickenAndCheeseSandwichBtn_Click(object sender, EventArgs e)
        {
            chickenAndCheeseSandwich.Visible = true;
            int amount = Convert.ToInt32(chickenAndCheeseSandwich.Text);
            int increment = amount + 1;
            chickenAndCheeseSandwich.Text = Convert.ToString(increment);
        }

     
    }
}
