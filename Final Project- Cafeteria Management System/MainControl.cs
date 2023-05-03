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
        private int[] productTotalCosts = new int[18]; // Array to store the total cost
        public int overallTotalCost = 0; //Add up the total cost of all products in the productTotalCosts array
       
        public MainControl()
        {
            InitializeComponent();

        }

        //incrementing of Sandwiches
        //incrementing of Sandwiches
        //incrementing of Sandwiches
        private void eggSandwichBtn_Click(object sender, EventArgs e)
        {
            eggSandwich.Visible = true; // the label that holds the quantity of the sandwich will be visible
            int quantity = int.Parse(eggSandwich.Text); // converts the label that holds the quantity of the sandwich to an integer 
            quantity++; // incrementing the quantity of the drink
            eggSandwich.Text = quantity.ToString(); // converts the converted quantity to string so it can be displayed as "text"

            int productCost = quantity * 25; // A variable that holds the cost of the drink
            productTotalCosts[1] = productCost; // putting the product cost to the first index of the array 

            overallTotalCost = 0; // calling a global variable to hold the total value of all the products
            for (int i = 0; i < 18; i++)
            {
                overallTotalCost += productTotalCosts[i]; // created a for loop to sum up the total cost
            }

        }

        private void cheeseSandwichBtn_Click(object sender, EventArgs e)
        {
            cheeseSandwich.Visible = true;
            int quantity = int.Parse(cheeseSandwich.Text);
            quantity++;
            cheeseSandwich.Text = quantity.ToString();

            int productCost = quantity * 20;
            productTotalCosts[2] = productCost;
            overallTotalCost = 0;
            for (int i = 0; i < 18; i++)
            {
                overallTotalCost += productTotalCosts[i];
            }
        }

        private void chickenSandwichBtn_Click(object sender, EventArgs e)
        {
            chickenSandwich.Visible = true;
            int quantity = int.Parse(chickenSandwich.Text);
            quantity++;
            chickenSandwich.Text = quantity.ToString();

            int productCost = quantity * 30;
            productTotalCosts[3] = productCost;
            overallTotalCost = 0;
            for (int i = 0; i < 18; i++)
            {
                overallTotalCost += productTotalCosts[i];
            }
        }

        private void vegSandwichBtn_Click(object sender, EventArgs e)
        {
            vegSandwich.Visible = true;
            int quantity = int.Parse(vegSandwich.Text);
            quantity++;
            vegSandwich.Text = quantity.ToString();

            int productCost = quantity * 25;
            productTotalCosts[4] = productCost;
            overallTotalCost = 0;
            for (int i = 0; i < 18; i++)
            {
                overallTotalCost += productTotalCosts[i];
            }
        }

        private void eggAndCheeseSandwichBtn_Click(object sender, EventArgs e)
        {
            eggAndCheeseSandwich.Visible = true;
            int quantity = int.Parse(eggAndCheeseSandwich.Text);
            quantity++;
            eggAndCheeseSandwich.Text = quantity.ToString();

            int productCost = quantity * 30;
            productTotalCosts[5] = productCost;
            overallTotalCost = 0;
            for (int i = 0; i < 18; i++)
            {
                overallTotalCost += productTotalCosts[i];
            }
        }

        private void vegAndCheeseSandwichBtn_Click(object sender, EventArgs e)
        {
            vegAndCheeseSandwich.Visible = true;
            int quantity = int.Parse(vegAndCheeseSandwich.Text);
            quantity++;
            vegAndCheeseSandwich.Text = quantity.ToString();

            int productCost = quantity * 30;
            productTotalCosts[6] = productCost;
            overallTotalCost = 0;
            for (int i = 0; i < 18; i++)
            {
                overallTotalCost += productTotalCosts[i];
            }
        }

        private void chickenAndCheeseSandwichBtn_Click(object sender, EventArgs e)
        {
            chickenAndCheeseSandwich.Visible = true;
            int quantity = int.Parse(chickenAndCheeseSandwich.Text);
            quantity++;
            chickenAndCheeseSandwich.Text = quantity.ToString();

            int productCost = quantity * 35;
            productTotalCosts[7] = productCost;
            overallTotalCost = 0;
            for (int i = 0; i < 18; i++)
            {
                overallTotalCost += productTotalCosts[i];
            }
        }

        //incrementing of street foods
        //incrementing of street foods
        //incrementing of street foods
        private void kwekkwekBtn_Click(object sender, EventArgs e)
        {
            kwekkwek.Visible = true;
            int quantity = int.Parse(kwekkwek.Text);
            quantity++;
            kwekkwek.Text = quantity.ToString();

            int productCost = quantity * 20;
            productTotalCosts[8] = productCost;
            overallTotalCost = 0;
            for (int i = 0; i < 18; i++)
            {
                overallTotalCost += productTotalCosts[i];
            }
        }

        private void fishBallsBtn_Click(object sender, EventArgs e)
        {
            fishBalls.Visible = true;
            int quantity = int.Parse(fishBalls.Text);
            quantity++;
            fishBalls.Text = quantity.ToString();

            int productCost = quantity * 20;
            productTotalCosts[9] = productCost;
            overallTotalCost = 0;
            for (int i = 0; i < 18; i++)
            {
                overallTotalCost += productTotalCosts[i];
            }

        }

        private void squidBallsBtn_Click(object sender, EventArgs e)
        {
            squidBalls.Visible = true;
            int quantity = int.Parse(squidBalls.Text);
            quantity++;
            squidBalls.Text = quantity.ToString();

            int productCost = quantity * 20;
            productTotalCosts[10] = productCost;
            overallTotalCost = 0;
            for (int i = 0; i < 18; i++)
            {
                overallTotalCost += productTotalCosts[i];
            }
        }

        private void BananacueBtn_Click(object sender, EventArgs e)
        {
            Bananacue.Visible = true;
            int quantity = int.Parse(Bananacue.Text);
            quantity++;
            Bananacue.Text = quantity.ToString();

            int productCost = quantity * 25;
            productTotalCosts[11] = productCost;
            overallTotalCost = 0;
            for (int i = 0; i < 18; i++)
            {
                overallTotalCost += productTotalCosts[i];
            }
        }

        private void TuronBtn_Click(object sender, EventArgs e)
        {
            Turon.Visible = true;
            int quantity = int.Parse(Turon.Text);
            quantity++;
            Turon.Text = quantity.ToString();

            int productCost = quantity * 25;
            productTotalCosts[12] = productCost;
            overallTotalCost = 0;
            for (int i = 0; i < 18; i++)
            {
                overallTotalCost += productTotalCosts[i];
            }
        }




        //incrementing of noodles
        //incrementing of noodles
        //incrementing of noodles
        private void chickenBtn_Click(object sender, EventArgs e)
        {
            chicken.Visible = true;
            int quantity = int.Parse(chicken.Text);
            quantity++;
            chicken.Text = quantity.ToString();

            int productCost = quantity * 25;
            productTotalCosts[13] = productCost;
            overallTotalCost = 0;
            for (int i = 0; i < 18; i++)
            {
                overallTotalCost += productTotalCosts[i];
            }
        }

        private void beefBtn_Click(object sender, EventArgs e)
        {
            beef.Visible = true;
            int quantity = int.Parse(beef.Text);
            quantity++;
            beef.Text = quantity.ToString();

            int productCost = quantity * 25;
            productTotalCosts[14] = productCost;
            overallTotalCost = 0;
            for (int i = 0; i < 18; i++)
            {
                overallTotalCost += productTotalCosts[i];
            }
        }

        private void porkBtn_Click(object sender, EventArgs e)
        {
            pork.Visible = true;
            int quantity = int.Parse(pork.Text);
            quantity++;
            pork.Text = quantity.ToString();

            int productCost = quantity * 25;
            productTotalCosts[15] = productCost;
            overallTotalCost = 0;
            for (int i = 0; i < 18; i++)
            {
                overallTotalCost += productTotalCosts[i];
            }
        }

        private void laPazBatchoyBtn_Click(object sender, EventArgs e)
        {
            laPazBatchoy.Visible = true;
            int quantity = int.Parse(laPazBatchoy.Text);
            quantity++;
            laPazBatchoy.Text = quantity.ToString();

            int productCost = quantity * 25;
            productTotalCosts[16] = productCost;
            overallTotalCost = 0;
            for (int i = 0; i < 18; i++)
            {
                overallTotalCost += productTotalCosts[i];
            }
        }

        private void bulaloBtn_Click(object sender, EventArgs e)
        {
            bulalo.Visible = true;
            int quantity = int.Parse(bulalo.Text);
            quantity++;
            bulalo.Text = quantity.ToString();

            int productCost = quantity * 25;
            productTotalCosts[17] = productCost;
            overallTotalCost = 0;
            for (int i = 0; i < 18; i++)
            {
                overallTotalCost += productTotalCosts[i];
            }
        }

        private void checkPriceBtn_Click(object sender, EventArgs e)
        {
            amount.Text = "₱" + overallTotalCost.ToString(); // display the total cost of the product
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            overallTotalCost = 0; // the total cost of the products will be 0

            productTotalCosts[1] = 0; // to clear the total cost of the product so there will be no bugs.
            productTotalCosts[2] = 0;
            productTotalCosts[3] = 0;
            productTotalCosts[4] = 0;
            productTotalCosts[5] = 0;
            productTotalCosts[6] = 0;
            productTotalCosts[7] = 0;
            productTotalCosts[8] = 0;
            productTotalCosts[9] = 0;
            productTotalCosts[10] = 0;
            productTotalCosts[11] = 0;
            productTotalCosts[12] = 0;
            productTotalCosts[13] = 0;
            productTotalCosts[14] = 0;
            productTotalCosts[15] = 0;
            productTotalCosts[16] = 0;
            productTotalCosts[17] = 0;

            eggSandwich.Visible = false;
            cheeseSandwich.Visible = false;
            chickenSandwich.Visible = false;
            vegSandwich.Visible = false;
            eggAndCheeseSandwich.Visible = false;
            vegAndCheeseSandwich.Visible = false;
            chickenAndCheeseSandwich.Visible = false;

            kwekkwek.Visible = false;
            fishBalls.Visible = false;
            squidBalls.Visible = false;
            Bananacue.Visible = false;
            Turon.Visible = false;

            chicken.Visible = false;
            beef.Visible = false;
            pork.Visible = false;
            laPazBatchoy.Visible = false;
            bulalo.Visible = false;

            eggSandwich.Text = "0";
            cheeseSandwich.Text = "0";
            chickenSandwich.Text = "0";
            vegSandwich.Text = "0";
            eggAndCheeseSandwich.Text = "0";
            vegAndCheeseSandwich.Text = "0";
            chickenAndCheeseSandwich.Text = "0";

            kwekkwek.Text = "0";
            fishBalls.Text = "0";
            squidBalls.Text = "0";
            Bananacue.Text = "0";
            Turon.Text = "0";

            chicken.Text = "0";
            beef.Text = "0";
            pork.Text = "0";
            laPazBatchoy.Text = "0";
            bulalo.Text = "0";

            amount.Text = "";
        }
    }
}
