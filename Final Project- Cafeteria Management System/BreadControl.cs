using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
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
            petitPainAdd.Visible = true;

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
            croissantAdd.Visible = true;
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
            pistoletAdd.Visible = true;
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
            batardAdd.Visible = true;
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
            ficellesAdd.Visible = true;
        }
        private void muffinBtn_Click_1(object sender, EventArgs e)
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
            muffinAdd.Visible = true;
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
            pretzelAdd.Visible = true;
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
            silcedBreadAdd.Visible = true;

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
            cappuccinoAdd.Visible = true;
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
            cortadoAdd.Visible = true;
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
            americanoAdd.Visible = true;
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
            cafeAuLaitAdd.Visible = true;
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
            chocolateAdd.Visible = true;
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

        private void petitPainDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(petitPain.Text);

            if (quantity > 0)
            {
                petitPain.Visible = true;
                quantity--;
                petitPain.Text = quantity.ToString();

                int productCost = quantity * 12;
                productTotalCosts[1] = productCost;
                breadOverallTotalCost = 0;
                for (int i = 0; i < 14; i++)
                {
                    breadOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void croissantDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(croissant.Text);

            if (quantity > 0)
            {
                croissant.Visible = true;
                quantity--;
                croissant.Text = quantity.ToString();

                int productCost = quantity * 15;
                productTotalCosts[2] = productCost;
                breadOverallTotalCost = 0;
                for (int i = 0; i < 14; i++)
                {
                    breadOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void pistoletDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(pistolet.Text);

            if (quantity > 0)
            {
                pistolet.Visible = true;
                quantity--;
                pistolet.Text = quantity.ToString();

                int productCost = quantity * 13;
                productTotalCosts[3] = productCost;
                breadOverallTotalCost = 0;
                for (int i = 0; i < 14; i++)
                {
                    breadOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void batardDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(batard.Text);

            if (quantity > 0)
            {
                batard.Visible = true;
                quantity--;
                batard.Text = quantity.ToString();

                int productCost = quantity * 15;
                productTotalCosts[4] = productCost;
                breadOverallTotalCost = 0;
                for (int i = 0; i < 14; i++)
                {
                    breadOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void ficellesDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(ficelles.Text);

            if (quantity > 0)
            {
                ficelles.Visible = true;
                quantity--;
                ficelles.Text = quantity.ToString();

                int productCost = quantity * 25;
                productTotalCosts[5] = productCost;
                breadOverallTotalCost = 0;
                for (int i = 0; i < 14; i++)
                {
                    breadOverallTotalCost += productTotalCosts[i];
                }

            }
        }
        private void muffinDcBtn_Click_1(object sender, EventArgs e)
        {
            int quantity = int.Parse(muffin.Text);

            if (quantity > 0)
            {
                muffin.Visible = true;
                quantity--;
                muffin.Text = quantity.ToString();

                int productCost = quantity * 15;
                productTotalCosts[6] = productCost;
                breadOverallTotalCost = 0;
                for (int i = 0; i < 14; i++)
                {
                    breadOverallTotalCost += productTotalCosts[i];
                }

            }
        }
       

        private void pretzelDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(pretzel.Text);

            if (quantity > 0)
            {
                pretzel.Visible = true;
                quantity--;
                pretzel.Text = quantity.ToString();

                int productCost = quantity * 15;
                productTotalCosts[7] = productCost;
                breadOverallTotalCost = 0;
                for (int i = 0; i < 14; i++)
                {
                    breadOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void slicedBreadDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(slicedBread.Text);

            if (quantity > 0)
            {
                slicedBread.Visible = true;
                quantity--;
                slicedBread.Text = quantity.ToString();

                int productCost = quantity * 10;
                productTotalCosts[8] = productCost;
                breadOverallTotalCost = 0;
                for (int i = 0; i < 14; i++)
                {
                    breadOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void cappuccinoDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(cappuccino.Text);

            if (quantity > 0)
            {
                cappuccino.Visible = true;
                quantity--;
                cappuccino.Text = quantity.ToString();

                int productCost = quantity * 30;
                productTotalCosts[9] = productCost;
                breadOverallTotalCost = 0;
                for (int i = 0; i < 14; i++)
                {
                    breadOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void cortadoDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(cortado.Text);

            if (quantity > 0)
            {
                cortado.Visible = true;
                quantity--;
                cortado.Text = quantity.ToString();

                int productCost = quantity * 30;
                productTotalCosts[10] = productCost;
                breadOverallTotalCost = 0;
                for (int i = 0; i < 14; i++)
                {
                    breadOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void americanoDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(americano.Text);

            if (quantity > 0)
            {
                americano.Visible = true;
                quantity--;
                americano.Text = quantity.ToString();

                int productCost = quantity * 25;
                productTotalCosts[11] = productCost;
                breadOverallTotalCost = 0;
                for (int i = 0; i < 14; i++)
                {
                    breadOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void cafeAuLaitDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(cafeAuLait.Text);

            if (quantity > 0)
            {
                cafeAuLait.Visible = true;
                quantity--;
                cafeAuLait.Text = quantity.ToString();

                int productCost = quantity * 30;
                productTotalCosts[12] = productCost;
                breadOverallTotalCost = 0;
                for (int i = 0; i < 14; i++)
                {
                    breadOverallTotalCost += productTotalCosts[i];
                }
            }
        }

        private void chocolateDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(chocolate.Text);

            if (quantity > 0)
            {
                chocolate.Visible = true;
                quantity--;
                chocolate.Text = quantity.ToString();

                int productCost = quantity * 30;
                productTotalCosts[13] = productCost;
                breadOverallTotalCost = 0;
                for (int i = 0; i < 14; i++)
                {
                    breadOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void petitPainAdd_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("item.txt", true))
            {
                writer.WriteLine("Petit Pain x " + petitPain.Text);
            }
            petitPainAdd.Visible = false;
        }

        private void croissantAdd_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("item.txt", true))
            {
                writer.WriteLine("Croissant x " + croissant.Text);
            }
            croissantAdd.Visible = false;
        }

        private void pistoletAdd_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("item.txt", true))
            {
                writer.WriteLine("Pistolet x " + pistolet.Text);
            }
            pistoletAdd.Visible = false;
        }

        private void batardAdd_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("item.txt", true))
            {
                writer.WriteLine("Batard x " + batard.Text);
            }
            batardAdd.Visible = false;
        }

        private void ficellesAdd_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("item.txt", true))
            {
                writer.WriteLine("Ficelles x " + ficelles.Text);
            }
            ficellesAdd.Visible = false;
        }
        private void muffinAdd_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("item.txt", true))
            {
                writer.WriteLine("Muffin x " + muffin.Text);
            }
            muffinAdd.Visible = false;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pretzelAdd_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("item.txt", true))
            {
                writer.WriteLine("Pretzel x " + pretzel.Text);
            }
            pretzelAdd.Visible = false;
        }

        private void silcedBreadAdd_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("item.txt", true))
            {
                writer.WriteLine("Sliced Bread x " + slicedBread.Text);
            }
            silcedBreadAdd.Visible = false;
        }

        private void cappuccinoAdd_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("item.txt", true))
            {
                writer.WriteLine("Cappucino x " + cappuccino.Text);
            }
            cappuccinoAdd.Visible = false;
        }

        private void cortadoAdd_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("item.txt", true))
            {
                writer.WriteLine("Cortado x " + cortado.Text);
            }
            cortadoAdd.Visible = false;
        }

        private void americanoAdd_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("item.txt", true))
            {
                writer.WriteLine("Americano x " + americano.Text);
            }
            americanoAdd.Visible = false;
        }

        private void cafeAuLaitAdd_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("item.txt", true))
            {
                writer.WriteLine("Cafe au Lait x " + cafeAuLait.Text);
            }
            cafeAuLaitAdd.Visible = false;
        }

        private void chocolateAdd_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("item.txt", true))
            {
                writer.WriteLine("Chocolate x " + chocolate.Text);
            }
            chocolateAdd.Visible = false;
        }

       
    }
}
