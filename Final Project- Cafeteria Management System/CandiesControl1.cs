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
    public partial class CandiesControl1 : UserControl
    {
        public CandiesControl1()
        {
            InitializeComponent();
        }

        private int[] productTotalCosts = new int[16]; // Array to store the total cost
        public int candiesOverallTotalCost = 0; //Add up the total cost of all products in the productTotalCosts array

        private void frutosBtn_Click(object sender, EventArgs e)
        {
            frutos.Visible = true; // the label that holds the quantity of the candy will be visible
            int quantity = int.Parse(frutos.Text); // converts the label that holds the quantity of the candy to an integer 
            quantity++; // incrementing the quantity of the candy
            frutos.Text = quantity.ToString(); // converts the converted quantity to string so it can be displayed as "text"

            int productCost = quantity * 1; // A variable that holds the cost of the candy
            productTotalCosts[1] = productCost; // putting the product cost/variable to the first index of the array 

            candiesOverallTotalCost = 0; // calling a global variable to hold the total value of all the cost
            for (int i = 0; i < 16; i++)
            {
                candiesOverallTotalCost += productTotalCosts[i]; // created a for loop to sum up the total cost and returning it to the global variable
            }

        }

        private void maxxBtn_Click(object sender, EventArgs e)
        {
            maxx.Visible = true;
            int quantity = int.Parse(maxx.Text);
            quantity++;
            maxx.Text = quantity.ToString();

            int productCost = quantity * 1;
            productTotalCosts[2] = productCost;
            candiesOverallTotalCost = 0;
            for (int i = 0; i < 16; i++)
            {
                candiesOverallTotalCost += productTotalCosts[i];
            }
        }

        private void lushBtn_Click(object sender, EventArgs e)
        {
            lush.Visible = true;
            int quantity = int.Parse(lush.Text);
            quantity++;
            lush.Text = quantity.ToString();

            int productCost = quantity * 1;
            productTotalCosts[3] = productCost;
            candiesOverallTotalCost = 0;
            for (int i = 0; i < 16; i++)
            {
                candiesOverallTotalCost += productTotalCosts[i];
            }
        }

        private void hanyBtn_Click(object sender, EventArgs e)
        {
            hany.Visible = true;
            int quantity = int.Parse(hany.Text);
            quantity++;
            hany.Text = quantity.ToString();

            int productCost = quantity * 4;
            productTotalCosts[4] = productCost;
            candiesOverallTotalCost = 0;
            for (int i = 0; i < 16; i++)
            {
                candiesOverallTotalCost += productTotalCosts[i];
            }
        }

        private void vfreshBtn_Click(object sender, EventArgs e)
        {
            vfresh.Visible = true;
            int quantity = int.Parse(vfresh.Text);
            quantity++;
            vfresh.Text = quantity.ToString();

            int productCost = quantity * 1;
            productTotalCosts[5] = productCost;
            candiesOverallTotalCost = 0;
            for (int i = 0; i < 16; i++)
            {
                candiesOverallTotalCost += productTotalCosts[i];
            }
        }
        //-----------------------------------------------------------//
        //-----------------------------------------------------------//
        //-----------------------------------------------------------//

        private void nipsBtn_Click(object sender, EventArgs e)
        {
            nips.Visible = true;
            int quantity = int.Parse(nips.Text);
            quantity++;
            nips.Text = quantity.ToString();

            int productCost = quantity * 10;
            productTotalCosts[6] = productCost;
            candiesOverallTotalCost = 0;
            for (int i = 0; i < 16; i++)
            {
                candiesOverallTotalCost += productTotalCosts[i];
            }
        }

        private void chochnutBtn_Click(object sender, EventArgs e)
        {
            chocnut.Visible = true;
            int quantity = int.Parse(chocnut.Text);
            quantity++;
            chocnut.Text = quantity.ToString();

            int productCost = quantity * 3;
            productTotalCosts[7] = productCost;
            candiesOverallTotalCost = 0;
            for (int i = 0; i < 16; i++)
            {
                candiesOverallTotalCost += productTotalCosts[i];
            }
        }

        private void goyaBtn_Click(object sender, EventArgs e)
        {
            goya.Visible = true;
            int quantity = int.Parse(goya.Text);
            quantity++;
            goya.Text = quantity.ToString();

            int productCost = quantity * 20;
            productTotalCosts[8] = productCost;
            candiesOverallTotalCost = 0;
            for (int i = 0; i < 16; i++)
            {
                candiesOverallTotalCost += productTotalCosts[i];
            }
        }

        private void snickersBtn_Click(object sender, EventArgs e)
        {
            snickers.Visible = true;
            int quantity = int.Parse(snickers.Text);
            quantity++;
            snickers.Text = quantity.ToString();

            int productCost = quantity * 16;
            productTotalCosts[9] = productCost;
            candiesOverallTotalCost = 0;
            for (int i = 0; i < 16; i++)
            {
                candiesOverallTotalCost += productTotalCosts[i];
            }
        }

        private void reesesBtn_Click(object sender, EventArgs e)
        {
            reeses.Visible = true;
            int quantity = int.Parse(reeses.Text);
            quantity++;
            reeses.Text = quantity.ToString();

            int productCost = quantity * 17;
            productTotalCosts[10] = productCost;
            candiesOverallTotalCost = 0;
            for (int i = 0; i < 16; i++)
            {
                candiesOverallTotalCost += productTotalCosts[i];
            }
        }
        //-----------------------------------------------------------//
        //-----------------------------------------------------------//
        //-----------------------------------------------------------//

        private void hersheysBtn_Click(object sender, EventArgs e)
        {
            hersheys.Visible = true;
            int quantity = int.Parse(hersheys.Text);
            quantity++;
            hersheys.Text = quantity.ToString();

            int productCost = quantity * 18;
            productTotalCosts[11] = productCost;
            candiesOverallTotalCost = 0;
            for (int i = 0; i < 16; i++)
            {
                candiesOverallTotalCost += productTotalCosts[i];
            }
        }

        private void twixBtn_Click(object sender, EventArgs e)
        {
            twix.Visible = true;
            int quantity = int.Parse(twix.Text);
            quantity++;
            twix.Text = quantity.ToString();

            int productCost = quantity * 16;
            productTotalCosts[12] = productCost;
            candiesOverallTotalCost = 0;
            for (int i = 0; i < 16; i++)
            {
                candiesOverallTotalCost += productTotalCosts[i];
            }
        }

        private void crunchBtn_Click(object sender, EventArgs e)
        {
            crunch.Visible = true;
            int quantity = int.Parse(crunch.Text);
            quantity++;
            crunch.Text = quantity.ToString();

            int productCost = quantity * 18;
            productTotalCosts[13] = productCost;
            candiesOverallTotalCost = 0;
            for (int i = 0; i < 16; i++)
            {
                candiesOverallTotalCost += productTotalCosts[i];
            }
        }

        private void mentosBtn_Click(object sender, EventArgs e)
        {
            mentos.Visible = true;
            int quantity = int.Parse(mentos.Text);
            quantity++;
            mentos.Text = quantity.ToString();

            int productCost = quantity * 10;
            productTotalCosts[14] = productCost;
            candiesOverallTotalCost = 0;
            for (int i = 0; i < 16; i++)
            {
                candiesOverallTotalCost += productTotalCosts[i];
            }
        }

        private void kopikoBtn_Click(object sender, EventArgs e)
        {
            kopiko.Visible = true;
            int quantity = int.Parse(kopiko.Text);
            quantity++;
            kopiko.Text = quantity.ToString();

            int productCost = quantity * 1;
            productTotalCosts[15] = productCost;
            candiesOverallTotalCost = 0;
            for (int i = 0; i < 16; i++)
            {
                candiesOverallTotalCost += productTotalCosts[i];
            }
        }

        private void checkPriceBtn_Click(object sender, EventArgs e)
        {
            amount.Text = "₱" + candiesOverallTotalCost.ToString(); // display the total cost of the product
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            candiesOverallTotalCost = 0; // the total cost of the products will be 0

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


            frutos.Visible = false; // hide all the labels that holds the quantity of Cnadies
            maxx.Visible = false;
            lush.Visible = false;
            hany.Visible = false;
            vfresh.Visible = false;
            nips.Visible = false;
            chocnut.Visible = false;
            goya.Visible = false;
            snickers.Visible = false;
            reeses.Visible = false;
            hersheys.Visible = false;
            twix.Visible = false;
            crunch.Visible = false;
            mentos.Visible = false;
            kopiko.Visible = false;

            frutos.Text = "0"; // change the value of candies to "zero" so it will reset
            maxx.Text = "0";
            lush.Text = "0";
            hany.Text = "0";
            vfresh.Text = "0";
            nips.Text = "0";
            chocnut.Text = "0";
            goya.Text = "0";
            snickers.Text = "0";
            reeses.Text = "0";
            hersheys.Text = "0";
            twix.Text = "0";
            crunch.Text = "0";
            mentos.Text = "0";
            kopiko.Text = "0";

            amount.Text = "";
        }

        private void frutosDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(frutos.Text);

            if (quantity > 0)
            {
                frutos.Visible = true;
                quantity--;
                frutos.Text = quantity.ToString();

                int productCost = quantity * 1;
                productTotalCosts[1] = productCost;
                candiesOverallTotalCost = 0;
                for (int i = 0; i < 16; i++)
                {
                    candiesOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void maxxDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(maxx.Text);

            if (quantity > 0)
            {
                maxx.Visible = true;
                quantity--;
                maxx.Text = quantity.ToString();

                int productCost = quantity * 1;
                productTotalCosts[2] = productCost;
                candiesOverallTotalCost = 0;
                for (int i = 0; i < 16; i++)
                {
                    candiesOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void lushDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(lush.Text);

            if (quantity > 0)
            {
                lush.Visible = true;
                quantity--;
                lush.Text = quantity.ToString();

                int productCost = quantity * 1;
                productTotalCosts[3] = productCost;
                candiesOverallTotalCost = 0;
                for (int i = 0; i < 16; i++)
                {
                    candiesOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void hanyDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(hany.Text);

            if (quantity > 0)
            {
                hany.Visible = true;
                quantity--;
                hany.Text = quantity.ToString();

                int productCost = quantity * 4;
                productTotalCosts[4] = productCost;
                candiesOverallTotalCost = 0;
                for (int i = 0; i < 16; i++)
                {
                    candiesOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void vfreshDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(vfresh.Text);

            if (quantity > 0)
            {
                vfresh.Visible = true;
                quantity--;
                vfresh.Text = quantity.ToString();

                int productCost = quantity * 1;
                productTotalCosts[5] = productCost;
                candiesOverallTotalCost = 0;
                for (int i = 0; i < 16; i++)
                {
                    candiesOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void nipsDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(nips.Text);

            if (quantity > 0)
            {
                nips.Visible = true;
                quantity--;
                nips.Text = quantity.ToString();

                int productCost = quantity * 10;
                productTotalCosts[6] = productCost;
                candiesOverallTotalCost = 0;
                for (int i = 0; i < 16; i++)
                {
                    candiesOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void chocnutDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(chocnut.Text);

            if (quantity > 0)
            {
                chocnut.Visible = true;
                quantity--;
                chocnut.Text = quantity.ToString();

                int productCost = quantity * 3;
                productTotalCosts[7] = productCost;
                candiesOverallTotalCost = 0;
                for (int i = 0; i < 16; i++)
                {
                    candiesOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void goyaDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(goya.Text);

            if (quantity > 0)
            {
                goya.Visible = true;
                quantity--;
                goya.Text = quantity.ToString();

                int productCost = quantity * 20;
                productTotalCosts[8] = productCost;
                candiesOverallTotalCost = 0;
                for (int i = 0; i < 16; i++)
                {
                    candiesOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void snickersDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(snickers.Text);

            if (quantity > 0)
            {
                snickers.Visible = true;
                quantity--;
                snickers.Text = quantity.ToString();

                int productCost = quantity * 16;
                productTotalCosts[9] = productCost;
                candiesOverallTotalCost = 0;
                for (int i = 0; i < 16; i++)
                {
                    candiesOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void reeseDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(reeses.Text);

            if (quantity > 0)
            {
                reeses.Visible = true;
                quantity--;
                reeses.Text = quantity.ToString();

                int productCost = quantity * 17;
                productTotalCosts[10] = productCost;
                candiesOverallTotalCost = 0;
                for (int i = 0; i < 16; i++)
                {
                    candiesOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void hersheysDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(hersheys.Text);

            if (quantity > 0)
            {
                hersheys.Visible = true;
                quantity--;
                hersheys.Text = quantity.ToString();

                int productCost = quantity * 18;
                productTotalCosts[11] = productCost;
                candiesOverallTotalCost = 0;
                for (int i = 0; i < 16; i++)
                {
                    candiesOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void twixDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(twix.Text);

            if (quantity > 0)
            {
                twix.Visible = true;
                quantity--;
                twix.Text = quantity.ToString();

                int productCost = quantity * 16;
                productTotalCosts[12] = productCost;
                candiesOverallTotalCost = 0;
                for (int i = 0; i < 16; i++)
                {
                    candiesOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void crunchDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(crunch.Text);

            if (quantity > 0)
            {
                crunch.Visible = true;
                quantity--;
                crunch.Text = quantity.ToString();

                int productCost = quantity * 18;
                productTotalCosts[13] = productCost;
                candiesOverallTotalCost = 0;
                for (int i = 0; i < 16; i++)
                {
                    candiesOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void mentosDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(mentos.Text);

            if (quantity > 0)
            {
                mentos.Visible = true;
                quantity--;
                mentos.Text = quantity.ToString();

                int productCost = quantity * 10;
                productTotalCosts[14] = productCost;
                candiesOverallTotalCost = 0;
                for (int i = 0; i < 16; i++)
                {
                    candiesOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void kopikoDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(kopiko.Text);

            if (quantity > 0)
            {
                kopiko.Visible = true;
                quantity--;
                kopiko.Text = quantity.ToString();

                int productCost = quantity * 1;
                productTotalCosts[15] = productCost;
                candiesOverallTotalCost = 0;
                for (int i = 0; i < 16; i++)
                {
                    candiesOverallTotalCost += productTotalCosts[i];
                }

            }
        }
    }
}
