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

        private int quantity = 0;// global variable for incrementing and decrementing
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
            quantity++;
            eggSandwich.Text = quantity.ToString();
        }

        private void cheeseSandwichBtn_Click(object sender, EventArgs e)
        {
            cheeseSandwich.Visible = true;
            quantity++;
            cheeseSandwich.Text = quantity.ToString();
        }

        private void chickenSandwichBtn_Click(object sender, EventArgs e)
        {
            chickenSandwich.Visible = true;
            quantity++;
            chickenSandwich.Text = quantity.ToString();
        }

        private void vegSandwichBtn_Click(object sender, EventArgs e)
        {
            vegSandwich.Visible = true;
            quantity++;
            vegSandwich.Text = quantity.ToString();
        }

        private void eggAndCheeseSandwichBtn_Click(object sender, EventArgs e)
        {
            eggAndCheeseSandwich.Visible = true;
            quantity++;
            eggAndCheeseSandwich.Text = quantity.ToString();
        }

        private void vegAndCheeseSandwichBtn_Click(object sender, EventArgs e)
        {
            vegAndCheeseSandwich.Visible = true;
            quantity++;
            vegAndCheeseSandwich.Text = quantity.ToString();
        }

        private void chickenAndCheeseSandwichBtn_Click(object sender, EventArgs e)
        {
            chickenAndCheeseSandwich.Visible = true;
            quantity++;
            chickenAndCheeseSandwich.Text = quantity.ToString();
        }


        //decrementing of Sandwiches
        //decrementing of Sandwiches
        //decrementing of Sandwiches
        private void eggSandwichDecrementBtn_Click(object sender, EventArgs e)
        {
            eggSandwich.Visible = true;
            quantity--;
            eggSandwich.Text = quantity.ToString();

        }

        private void cheeseSandwichDecrementBtn_Click(object sender, EventArgs e)
        {
            cheeseSandwich.Visible = true;
            quantity--;
            cheeseSandwich.Text = quantity.ToString();
        }

        private void chickenSandwichDecrementBtn_Click(object sender, EventArgs e)
        {
            chickenSandwich.Visible = true;
            quantity--;
            chickenSandwich.Text = quantity.ToString();
        }

        private void vegSandwichDecrementBtn_Click(object sender, EventArgs e)
        {
            vegSandwich.Visible = true;
            quantity--;
            vegSandwich.Text = quantity.ToString();
        }

        private void eggAndCheeseSandwichDecrementBtn_Click(object sender, EventArgs e)
        {
            eggAndCheeseSandwich.Visible = true;
            quantity--;
            eggAndCheeseSandwich.Text = quantity.ToString();
        }

        private void vegAndCheeseSandwichDecrementBtn_Click(object sender, EventArgs e)
        {
            vegAndCheeseSandwich.Visible = true;
            quantity--;
            vegAndCheeseSandwich.Text = quantity.ToString();
        }

        private void chickenAndCheeseSandwichDecrementBtn_Click(object sender, EventArgs e)
        {
            chickenAndCheeseSandwich.Visible = true;
            quantity--;
            chickenAndCheeseSandwich.Text = quantity.ToString();
        }


        //incrementing of street foods
        //incrementing of street foods
        //incrementing of street foods
        private void kwekkwekBtn_Click(object sender, EventArgs e)
        {
            kwekkwek.Visible = true;
            quantity++;
            kwekkwek.Text = quantity.ToString();
        }

        private void fishBallsBtn_Click(object sender, EventArgs e)
        {
            fishBalls.Visible = true;
            quantity++;
            fishBalls.Text = quantity.ToString();

        }

        private void squidBallsBtn_Click(object sender, EventArgs e)
        {
            squidBalls.Visible = true;
            quantity++;
            squidBalls.Text = quantity.ToString();
        }

        private void BananacueBtn_Click(object sender, EventArgs e)
        {
            Bananacue.Visible = true;
            quantity++;
            Bananacue.Text = quantity.ToString();
        }

        private void TuronBtn_Click(object sender, EventArgs e)
        {
            Turon.Visible = true;
            quantity++;
            Turon.Text = quantity.ToString();
        }


        //Decrementing of street foods
        //Decrementingof street foods
        //Decrementing of street foods
        private void kwekkwekDecrementBtn_Click(object sender, EventArgs e)
        {
            kwekkwek.Visible = true;
            quantity--;
            kwekkwek.Text = quantity.ToString();
        }

        private void fishBallsDecrementBtn_Click(object sender, EventArgs e)
        {
            fishBalls.Visible = true;
            quantity--;
            fishBalls.Text = quantity.ToString();
        }

        private void squidBallsDecrementBtn_Click(object sender, EventArgs e)
        {
            squidBalls.Visible = true;
            quantity--;
            squidBalls.Text = quantity.ToString();
        }

        private void BananacueDecrementBtn_Click(object sender, EventArgs e)
        {
            Bananacue.Visible = true;
            quantity--;
            Bananacue.Text = quantity.ToString();
        }

        private void TuronDecrementBtn_Click(object sender, EventArgs e)
        {
            Turon.Visible = true;
            quantity--;
            Turon.Text = quantity.ToString();
        }


        //incrementing of noodles
        //incrementing of noodles
        //incrementing of noodles
        private void chickenBtn_Click(object sender, EventArgs e)
        {
            chicken.Visible = true;
            quantity++;
            chicken.Text = quantity.ToString();
        }

        private void beefBtn_Click(object sender, EventArgs e)
        {
            beef.Visible = true;
            quantity++;
            beef.Text = quantity.ToString();
        }

        private void porkBtn_Click(object sender, EventArgs e)
        {
            pork.Visible = true;
            quantity++;
            pork.Text = quantity.ToString();
        }

        private void laPazBatchoyBtn_Click(object sender, EventArgs e)
        {
            laPazBatchoy.Visible = true;
            quantity++;
            laPazBatchoy.Text = quantity.ToString();
        }

        private void bulaloBtn_Click(object sender, EventArgs e)
        {
            bulalo.Visible = true;
            quantity++;
            bulalo.Text = quantity.ToString();
        }


        //decrementing of noodles
        //decrementing of noodles
        //decrementing of noodles
        private void chickenDecrementBtn_Click(object sender, EventArgs e)
        {
            chicken.Visible = true;
            quantity--;
            chicken.Text = quantity.ToString();
        }

        private void beefDecrementBtn_Click(object sender, EventArgs e)
        {
            beef.Visible = true;
            quantity--;
            beef.Text = quantity.ToString();
        }

        private void porkDecrementBtn_Click(object sender, EventArgs e)
        {
            pork.Visible = true;
            quantity--;
            pork.Text = quantity.ToString();
        }

        private void laPazBatchoyDecrementBtn_Click(object sender, EventArgs e)
        {
            laPazBatchoy.Visible = true;
            quantity--;
            laPazBatchoy.Text = quantity.ToString();
        }
        private void bulaloDecrementBtn_Click_1(object sender, EventArgs e)
        {
            bulalo.Visible = true;
            quantity--;
            bulalo.Text = quantity.ToString();
        }
    }
}
