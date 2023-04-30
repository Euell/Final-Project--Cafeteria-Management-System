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

        //incrementing of Sandwiches
        //incrementing of Sandwiches
        //incrementing of Sandwiches
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


        //decrementing of Sandwiches
        //decrementing of Sandwiches
        //decrementing of Sandwiches
        private void eggSandwichDecrementBtn_Click(object sender, EventArgs e)
        {
            eggSandwich.Visible = true;
            int amount = Convert.ToInt32(eggSandwich.Text);
            int decrement = amount - 1;
            eggSandwich.Text = Convert.ToString(decrement);
            
        }

        private void cheeseSandwichDecrementBtn_Click(object sender, EventArgs e)
        {
            cheeseSandwich.Visible = true;
            int amount = Convert.ToInt32(cheeseSandwich.Text);
            int decrement = amount - 1;
            cheeseSandwich.Text = Convert.ToString(decrement);
        }

        private void chickenSandwichDecrementBtn_Click(object sender, EventArgs e)
        {
            chickenSandwich.Visible = true;
            int amount = Convert.ToInt32(chickenSandwich.Text);
            int decrement = amount - 1;
            chickenSandwich.Text = Convert.ToString(decrement);
        }

        private void vegSandwichDecrementBtn_Click(object sender, EventArgs e)
        {
            vegSandwich.Visible = true;
            int amount = Convert.ToInt32(vegSandwich.Text);
            int decrement = amount - 1;
            vegSandwich.Text = Convert.ToString(decrement);
        }

        private void eggAndCheeseSandwichDecrementBtn_Click(object sender, EventArgs e)
        {
            eggAndCheeseSandwich.Visible = true;
            int amount = Convert.ToInt32(eggAndCheeseSandwich.Text);
            int decrement = amount - 1;
            eggAndCheeseSandwich.Text = Convert.ToString(decrement);
        }

        private void vegAndCheeseSandwichDecrementBtn_Click(object sender, EventArgs e)
        {
            vegAndCheeseSandwich.Visible = true;
            int amount = Convert.ToInt32(vegAndCheeseSandwich.Text);
            int decrement = amount - 1;
            vegAndCheeseSandwich.Text = Convert.ToString(decrement);
        }

        private void chickenAndCheeseSandwichDecrementBtn_Click(object sender, EventArgs e)
        {
            chickenAndCheeseSandwich.Visible = true;
            int amount = Convert.ToInt32(chickenAndCheeseSandwich.Text);
            int decrement = amount - 1;
            chickenAndCheeseSandwich.Text = Convert.ToString(decrement);
        }


        //incrementing of street foods
        //incrementing of street foods
        //incrementing of street foods
        private void kwekkwekBtn_Click(object sender, EventArgs e)
        {
            kwekkwek.Visible = true;
            int amount = Convert.ToInt32(kwekkwek.Text);
            int increment = amount + 1;
            kwekkwek.Text = Convert.ToString(increment);
        }

        private void fishBallsBtn_Click(object sender, EventArgs e)
        {
            fishBalls.Visible = true;
            int amount = Convert.ToInt32(fishBalls.Text);
            int increment = amount + 1;
            fishBalls.Text = Convert.ToString(increment);

        }

        private void squidBallsBtn_Click(object sender, EventArgs e)
        {
            squidBalls.Visible = true;
            int amount = Convert.ToInt32(squidBalls.Text);
            int increment = amount + 1;
            squidBalls.Text = Convert.ToString(increment);
        }

        private void BananacueBtn_Click(object sender, EventArgs e)
        {
            Bananacue.Visible = true;
            int amount = Convert.ToInt32(Bananacue.Text);
            int increment = amount + 1;
            Bananacue.Text = Convert.ToString(increment);
        }

        private void TuronBtn_Click(object sender, EventArgs e)
        {
            Turon.Visible = true;
            int amount = Convert.ToInt32(Turon.Text);
            int increment = amount + 1;
            Turon.Text = Convert.ToString(increment);
        }


        //Decrementing of street foods
        //Decrementingof street foods
        //Decrementing of street foods
        private void kwekkwekDecrementBtn_Click(object sender, EventArgs e)
        {
            kwekkwek.Visible = true;
            int amount = Convert.ToInt32(kwekkwek.Text);
            int decrement = amount - 1;
            kwekkwek.Text = Convert.ToString(decrement);
        }

        private void fishBallsDecrementBtn_Click(object sender, EventArgs e)
        {
            fishBalls.Visible = true;
            int amount = Convert.ToInt32(fishBalls.Text);
            int decrement = amount - 1;
            fishBalls.Text = Convert.ToString(decrement);
        }

        private void squidBallsDecrementBtn_Click(object sender, EventArgs e)
        {
            squidBalls.Visible = true;
            int amount = Convert.ToInt32(squidBalls.Text);
            int decrement = amount - 1;
            squidBalls.Text = Convert.ToString(decrement);
        }

        private void BananacueDecrementBtn_Click(object sender, EventArgs e)
        {
            Bananacue.Visible = true;
            int amount = Convert.ToInt32(Bananacue.Text);
            int decrement = amount - 1;
            Bananacue.Text = Convert.ToString(decrement);
        }

        private void TuronDecrementBtn_Click(object sender, EventArgs e)
        {
            Turon.Visible = true;
            int amount = Convert.ToInt32(Turon.Text);
            int decrement = amount - 1;
            Turon.Text = Convert.ToString(decrement);
        }


        //incrementing of noodles
        //incrementing of noodles
        //incrementing of noodles
        private void chickenBtn_Click(object sender, EventArgs e)
        {
            chicken.Visible = true;
            int amount = Convert.ToInt32(chicken.Text);
            int increment = amount + 1;
            chicken.Text = Convert.ToString(increment);
        }

        private void beefBtn_Click(object sender, EventArgs e)
        {
            beef.Visible = true;
            int amount = Convert.ToInt32(beef.Text);
            int increment = amount + 1;
            beef.Text = Convert.ToString(increment);
        }

        private void porkBtn_Click(object sender, EventArgs e)
        {
            pork.Visible = true;
            int amount = Convert.ToInt32(pork.Text);
            int increment = amount + 1;
            pork.Text = Convert.ToString(increment);
        }

        private void laPazBatchoyBtn_Click(object sender, EventArgs e)
        {
            laPazBatchoy.Visible = true;
            int amount = Convert.ToInt32(laPazBatchoy.Text);
            int increment = amount + 1;
            laPazBatchoy.Text = Convert.ToString(increment);
        }

        private void bulaloBtn_Click(object sender, EventArgs e)
        {
            bulalo.Visible = true;
            int amount = Convert.ToInt32(bulalo.Text);
            int increment = amount + 1;
            bulalo.Text = Convert.ToString(increment);
        }


        //decrementing of noodles
        //decrementing of noodles
        //decrementing of noodles
        private void chickenDecrementBtn_Click(object sender, EventArgs e)
        {
            chicken.Visible = true;
            int amount = Convert.ToInt32(chicken.Text);
            int decrement = amount - 1;
            chicken.Text = Convert.ToString(decrement);
        }

        private void beefDecrementBtn_Click(object sender, EventArgs e)
        {
            beef.Visible = true;
            int amount = Convert.ToInt32(beef.Text);
            int decrement = amount - 1;
            beef.Text = Convert.ToString(decrement);
        }

        private void porkDecrementBtn_Click(object sender, EventArgs e)
        {
            pork.Visible = true;
            int amount = Convert.ToInt32(pork.Text);
            int decrement = amount - 1;
            pork.Text = Convert.ToString(decrement);
        }

        private void laPazBatchoyDecrementBtn_Click(object sender, EventArgs e)
        {
            laPazBatchoy.Visible = true;
            int amount = Convert.ToInt32(laPazBatchoy.Text);
            int decrement = amount - 1;
            laPazBatchoy.Text = Convert.ToString(decrement);
        }
        private void bulaloDecrementBtn_Click_1(object sender, EventArgs e)
        {
            bulalo.Visible = true;
            int amount = Convert.ToInt32(bulalo.Text);
            int decrement = amount - 1;
            bulalo.Text = Convert.ToString(decrement);
        }
    }
}
