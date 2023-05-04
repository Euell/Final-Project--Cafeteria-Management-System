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
    public partial class BreadControl : UserControl
    {
        public BreadControl()
        {
            InitializeComponent();
        }
        private int[] productTotalCosts = new int[14]; // Array to store the total cost
        public int breadOverallTotalCost = 0; //Add up the total cost of all products in the productTotalCosts array


        private void petitPainBtn_Click(object sender, EventArgs e)
        {
            petitPain.Visible = true; // the label that holds the quantity of the bread will be visible
            int quantity = int.Parse(petitPain.Text); // converts the label that holds the quantity of the bread to an integer 
            quantity++; // incrementing the quantity of the bread
            petitPain.Text = quantity.ToString(); // converts the converted quantity to string so it can be displayed as "text"

            int productCost = quantity * 12; // A variable that holds the cost of the bread
            productTotalCosts[1] = productCost; // putting the product cost/variable to the first index of the array 

            breadOverallTotalCost = 0; // calling a global variable to hold the total value of all the cost
            for (int i = 0; i < 14; i++)
            {
                breadOverallTotalCost += productTotalCosts[i]; // created a for loop to sum up the total cost and returning it to the global variable
            }

        }

        private void croissantBtn_Click(object sender, EventArgs e)
        {
            croissant.Visible = true;
            int quantity = int.Parse(croissant.Text);
            quantity++;
            croissant.Text = quantity.ToString();

            int productCost = quantity * 15;
            productTotalCosts[2] = productCost;
            breadOverallTotalCost = 0;
            for (int i = 0; i < 14; i++)
            {
                breadOverallTotalCost += productTotalCosts[i];
            }
        }

        private void pistoletBtn_Click(object sender, EventArgs e)
        {
            pistolet.Visible = true;
            int quantity = int.Parse(pistolet.Text);
            quantity++;
            pistolet.Text = quantity.ToString();

            int productCost = quantity * 13;
            productTotalCosts[3] = productCost;
            breadOverallTotalCost = 0;
            for (int i = 0; i < 14; i++)
            {
                breadOverallTotalCost += productTotalCosts[i];
            }
        }

        private void batardBtn_Click(object sender, EventArgs e)
        {
            batard.Visible = true;
            int quantity = int.Parse(batard.Text);
            quantity++;
            batard.Text = quantity.ToString();

            int productCost = quantity * 15;
            productTotalCosts[4] = productCost;
            breadOverallTotalCost = 0;
            for (int i = 0; i < 14; i++)
            {
                breadOverallTotalCost += productTotalCosts[i];
            }
        }

        private void ficellesBtn_Click(object sender, EventArgs e)
        {
            ficelles.Visible = true;
            int quantity = int.Parse(ficelles.Text);
            quantity++;
            ficelles.Text = quantity.ToString();

            int productCost = quantity * 25;
            productTotalCosts[5] = productCost;
            breadOverallTotalCost = 0;
            for (int i = 0; i < 14; i++)
            {
                breadOverallTotalCost += productTotalCosts[i];
            }
        }

        private void muffinBtn_Click(object sender, EventArgs e)
        {
            muffin.Visible = true;
            int quantity = int.Parse(muffin.Text);
            quantity++;
            muffin.Text = quantity.ToString();

            int productCost = quantity * 15;
            productTotalCosts[6] = productCost;
            breadOverallTotalCost = 0;
            for (int i = 0; i < 14; i++)
            {
                breadOverallTotalCost += productTotalCosts[i];
            }
        }

        private void pretzelBtn_Click(object sender, EventArgs e)
        {
            pretzel.Visible = true;
            int quantity = int.Parse(pretzel.Text);
            quantity++;
            pretzel.Text = quantity.ToString();

            int productCost = quantity * 15;
            productTotalCosts[7] = productCost;
            breadOverallTotalCost = 0;
            for (int i = 0; i < 14; i++)
            {
                breadOverallTotalCost += productTotalCosts[i];
            }
        }

        private void slicedBreadBtn_Click(object sender, EventArgs e)
        {
            slicedBread.Visible = true;
            int quantity = int.Parse(slicedBread.Text);
            quantity++;
            slicedBread.Text = quantity.ToString();

            int productCost = quantity * 10;
            productTotalCosts[8] = productCost;
            breadOverallTotalCost = 0;
            for (int i = 0; i < 14; i++)
            {
                breadOverallTotalCost += productTotalCosts[i];
            }
        }

        private void cappuccinoBtn_Click(object sender, EventArgs e)
        {
            cappuccino.Visible = true;
            int quantity = int.Parse(cappuccino.Text);
            quantity++;
            cappuccino.Text = quantity.ToString();

            int productCost = quantity * 30;
            productTotalCosts[9] = productCost;
            breadOverallTotalCost = 0;
            for (int i = 0; i < 14; i++)
            {
                breadOverallTotalCost += productTotalCosts[i];
            }
        }

        private void cortadoBtn_Click(object sender, EventArgs e)
        {
            cortado.Visible = true;
            int quantity = int.Parse(cortado.Text);
            quantity++;
            cortado.Text = quantity.ToString();

            int productCost = quantity * 30;
            productTotalCosts[10] = productCost;
            breadOverallTotalCost = 0;
            for (int i = 0; i < 14; i++)
            {
                breadOverallTotalCost += productTotalCosts[i];
            }
        }

        private void americanoBtn_Click(object sender, EventArgs e)
        {
            americano.Visible = true;
            int quantity = int.Parse(americano.Text);
            quantity++;
            americano.Text = quantity.ToString();

            int productCost = quantity * 25;
            productTotalCosts[11] = productCost;
            breadOverallTotalCost = 0;
            for (int i = 0; i < 14; i++)
            {
                breadOverallTotalCost += productTotalCosts[i];
            }
        }

        private void cafeAuLaitBtn_Click(object sender, EventArgs e)
        {
            cafeAuLait.Visible = true;
            int quantity = int.Parse(cafeAuLait.Text);
            quantity++;
            cafeAuLait.Text = quantity.ToString();

            int productCost = quantity * 30;
            productTotalCosts[12] = productCost;
            breadOverallTotalCost = 0;
            for (int i = 0; i < 14; i++)
            {
                breadOverallTotalCost += productTotalCosts[i];
            }
        }
        private void chocolateBtn_Click(object sender, EventArgs e)
        {
            chocolate.Visible = true;
            int quantity = int.Parse(chocolate.Text);
            quantity++;
            chocolate.Text = quantity.ToString();

            int productCost = quantity * 30;
            productTotalCosts[13] = productCost;
            breadOverallTotalCost = 0;
            for (int i = 0; i < 14; i++)
            {
                breadOverallTotalCost += productTotalCosts[i];
            }
        }

        private void checkPriceBtn_Click(object sender, EventArgs e)
        {
            amount.Text = "₱" + breadOverallTotalCost.ToString(); // display the total cost of the product

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            breadOverallTotalCost = 0;

            petitPain.Visible = false;
            croissant.Visible = false;
            pistolet.Visible = false;
            batard.Visible = false;
            ficelles.Visible = false;
            muffin.Visible = false;
            pretzel.Visible = false;
            slicedBread.Visible = false;
            cappuccino.Visible = false;
            cortado.Visible = false;
            americano.Visible = false;
            cafeAuLait.Visible = false;
            chocolate.Visible = false;

            petitPain.Text = "0";
            croissant.Text = "0";
            pistolet.Text = "0";
            batard.Text = "0";
            ficelles.Text = "0";
            muffin.Text = "0";
            pretzel.Text = "0";
            slicedBread.Text = "0";
            cappuccino.Text = "0";
            cortado.Text = "0";
            americano.Text = "0";
            cafeAuLait.Text = "0";
            chocolate.Text = "0";

            amount.Text = "";
        }

       
    }
}
