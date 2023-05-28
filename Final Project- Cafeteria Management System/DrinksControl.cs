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
    public partial class DrinksControl : UserControl
    {

        public DrinksControl()
        {
            InitializeComponent();
        }
        private int[] productTotalCosts = new int[9]; // Array to store the total cost
        public int drinksOverallTotalCost = 0; //Add up the total cost of all products in the productTotalCosts array



        //IncremenetButton
        //IncremenetButton
        //IncremenetButton
        private void leMiniraleBtn_Click_1(object sender, EventArgs e)
        {
            leMinirale.Visible = true; // the label that holds the quantity of the drink will be visible
            int quantity = int.Parse(leMinirale.Text); // converts the label that holds the quantity of the drink to an integer 
            quantity++; // incrementing the quantity of the drink
            leMinirale.Text = quantity.ToString(); // converts the converted quantity to string so it can be displayed as "text"

            int productCost = quantity * 15; // A variable that holds the cost of the drink
            productTotalCosts[1] = productCost; // putting the product cost to the first index of the array 

            drinksOverallTotalCost = 0; // calling a global variable to hold the total value of all the products
            for (int i = 0; i < 9; i++)
            {
                drinksOverallTotalCost += productTotalCosts[i]; // created a for loop to sum up the total cost and returning it to the global variable
            }
        }

        private void absoluteBtn_Click(object sender, EventArgs e)
        {
            absolute.Visible = true;
            int quantity = int.Parse(absolute.Text);
            quantity++;
            absolute.Text = quantity.ToString();

            int productCost = quantity * 20;
            productTotalCosts[2] = productCost;
            drinksOverallTotalCost = 0;
            for (int i = 0; i < 9; i++)
            {
                drinksOverallTotalCost += productTotalCosts[i];
            }
        }

        private void evianBtn_Click(object sender, EventArgs e)
        {
            evian.Visible = true;
            int quantity = int.Parse(evian.Text);
            quantity++;
            evian.Text = quantity.ToString();

            int productCost = quantity * 25;
            productTotalCosts[3] = productCost;
            drinksOverallTotalCost = 0;
            for (int i = 0; i < 9; i++)
            {
                drinksOverallTotalCost += productTotalCosts[i];
            }
        }

        private void summitBtn_Click(object sender, EventArgs e)
        {
            summit.Visible = true;
            int quantity = int.Parse(summit.Text);
            quantity++;
            summit.Text = quantity.ToString();

            int productCost = quantity * 20;
            productTotalCosts[4] = productCost;
            drinksOverallTotalCost = 0;
            for (int i = 0; i < 9; i++)
            {
                drinksOverallTotalCost += productTotalCosts[i];
            }
        }

        private void cokeBtn_Click(object sender, EventArgs e)
        {
            coke.Visible = true;
            int quantity = int.Parse(coke.Text);
            quantity++;
            coke.Text = quantity.ToString();

            int productCost = quantity * 30;
            productTotalCosts[5] = productCost;
            drinksOverallTotalCost = 0;
            for (int i = 0; i < 9; i++)
            {
                drinksOverallTotalCost += productTotalCosts[i];
            }
        }

        private void royalBtn_Click(object sender, EventArgs e)
        {
            royal.Visible = true;
            int quantity = int.Parse(royal.Text);
            quantity++;
            royal.Text = quantity.ToString();

            int productCost = quantity * 30;
            productTotalCosts[6] = productCost;
            drinksOverallTotalCost = 0;
            for (int i = 0; i < 9; i++)
            {
                drinksOverallTotalCost += productTotalCosts[i];
            }
        }

        private void spriteBtn_Click(object sender, EventArgs e)
        {
            sprite.Visible = true;
            int quantity = int.Parse(sprite.Text);
            quantity++;
            sprite.Text = quantity.ToString();

            int productCost = quantity * 30;
            productTotalCosts[7] = productCost;
            drinksOverallTotalCost = 0;
            for (int i = 0; i < 9; i++)
            {
                drinksOverallTotalCost += productTotalCosts[i];
            }
        }

        private void rootBeerBtn_Click(object sender, EventArgs e)
        {
            rootBeer.Visible = true;
            int quantity = int.Parse(rootBeer.Text);
            quantity++;
            rootBeer.Text = quantity.ToString();

            int productCost = quantity * 30;
            productTotalCosts[8] = productCost;
            drinksOverallTotalCost = 0;
            for (int i = 0; i < 9; i++)
            {
                drinksOverallTotalCost += productTotalCosts[i];
            }
        }

        private void checkPriceBtn_Click(object sender, EventArgs e)
        {
            amount.Text = "₱" + drinksOverallTotalCost.ToString(); // display the total cost of the product
        }

        //buttons for checking price
        private void clearBtn_Click(object sender, EventArgs e) // reset all the quantity and the total cost
        {
            drinksOverallTotalCost = 0; // the total cost of the products will be 0

            productTotalCosts[1] = 0; // to clear the total cost of the product so there will be no bugs.
            productTotalCosts[2] = 0;
            productTotalCosts[3] = 0;
            productTotalCosts[4] = 0;
            productTotalCosts[5] = 0;
            productTotalCosts[6] = 0;
            productTotalCosts[7] = 0;
            productTotalCosts[8] = 0;

            leMinirale.Visible = false; // hide all the labels that holds the quantity of drinks
            absolute.Visible = false;
            evian.Visible = false;
            summit.Visible = false;
            coke.Visible = false;
            royal.Visible = false;
            sprite.Visible = false;
            rootBeer.Visible = false;

            leMinirale.Text = "0"; // change the value of drinks to "zero" so it will reset
            absolute.Text = "0";
            evian.Text = "0";
            summit.Text = "0";
            coke.Text = "0";
            royal.Text = "0";
            sprite.Text = "0";
            rootBeer.Text = "0";

            amount.Text = "";  
        }

        private void leMiniraleDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(leMinirale.Text);

            if (quantity > 0)
            {
                leMinirale.Visible = true;
                quantity--;
                leMinirale.Text = quantity.ToString();

                int productCost = quantity * 15;
                productTotalCosts[1] = productCost;
                drinksOverallTotalCost = 0;
                for (int i = 0; i < 9; i++)
                {
                    drinksOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void absoluteDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(absolute.Text);

            if (quantity > 0)
            {
                absolute.Visible = true;
                quantity--;
                absolute.Text = quantity.ToString();

                int productCost = quantity * 20;
                productTotalCosts[2] = productCost;
                drinksOverallTotalCost = 0;
                for (int i = 0; i < 9; i++)
                {
                    drinksOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void evianDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(evian.Text);

            if (quantity > 0)
            {
                evian.Visible = true;
                quantity--;
                evian.Text = quantity.ToString();

                int productCost = quantity * 25;
                productTotalCosts[3] = productCost;
                drinksOverallTotalCost = 0;
                for (int i = 0; i < 9; i++)
                {
                    drinksOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void summitDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(summit.Text);

            if (quantity > 0)
            {
                summit.Visible = true;
                quantity--;
                summit.Text = quantity.ToString();

                int productCost = quantity * 20;
                productTotalCosts[4] = productCost;
                drinksOverallTotalCost = 0;
                for (int i = 0; i < 9; i++)
                {
                    drinksOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void cokeDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(coke.Text);

            if (quantity > 0)
            {
                coke.Visible = true;
                quantity--;
                coke.Text = quantity.ToString();

                int productCost = quantity * 30;
                productTotalCosts[5] = productCost;
                drinksOverallTotalCost = 0;
                for (int i = 0; i < 9; i++)
                {
                    drinksOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void royalDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(royal.Text);

            if (quantity > 0)
            {
                royal.Visible = true;
                quantity--;
                royal.Text = quantity.ToString();

                int productCost = quantity * 30;
                productTotalCosts[6] = productCost;
                drinksOverallTotalCost = 0;
                for (int i = 0; i < 9; i++)
                {
                    drinksOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void spriteDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(sprite.Text);

            if (quantity > 0)
            {
                sprite.Visible = true;
                quantity--;
                sprite.Text = quantity.ToString();

                int productCost = quantity * 30;
                productTotalCosts[7] = productCost;
                drinksOverallTotalCost = 0;
                for (int i = 0; i < 9; i++)
                {
                    drinksOverallTotalCost += productTotalCosts[i];
                }
            

        }
    }

        private void rootBeerDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(rootBeer.Text);

            if (quantity > 0)
            {
                rootBeer.Visible = true;
                quantity--;
                rootBeer.Text = quantity.ToString();

                int productCost = quantity * 30;
                productTotalCosts[8] = productCost;
                drinksOverallTotalCost = 0;
                for (int i = 0; i < 9; i++)
                {
                    drinksOverallTotalCost += productTotalCosts[i];
                }

            }
        }
    }
}
