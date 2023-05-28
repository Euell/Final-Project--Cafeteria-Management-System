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
    public partial class SnacksControl1 : UserControl
    {
        public SnacksControl1()
        {
            InitializeComponent();
        }
        private int[] productTotalCosts = new int[16]; // Array to store the total cost
        public int snacksOverallTotalCost = 0; //Add up the total cost of all products in the productTotalCosts array

        private void vcutBtn_Click(object sender, EventArgs e)
        {
            vcut.Visible = true; // the label that holds the quantity of the snack will be visible
            int quantity = int.Parse(vcut.Text); // converts the label that holds the quantity of the snack to an integer 
            quantity++; // incrementing the quantity of the snack
            vcut.Text = quantity.ToString(); // converts the converted quantity to string so it can be displayed as "text"

            int productCost = quantity * 15; // A variable that holds the cost of the snack
            productTotalCosts[1] = productCost; // putting the product cost/variable to the first index of the array 

            snacksOverallTotalCost = 0; // calling a global variable to hold the total value of all the cost
            for (int i = 0; i < 16; i++)
            {
                snacksOverallTotalCost += productTotalCosts[i]; // created a for loop to sum up the total cost and returning it to the global variable
            }

        }

        private void cracklingsBtn_Click(object sender, EventArgs e)
        {
            cracklings.Visible = true;
            int quantity = int.Parse(cracklings.Text);
            quantity++;
            cracklings.Text = quantity.ToString();

            int productCost = quantity * 12;
            productTotalCosts[2] = productCost;
            snacksOverallTotalCost = 0;
            for (int i = 0; i < 13; i++)
            {
                snacksOverallTotalCost += productTotalCosts[i];
            }
        }

        private void mangJuanBtn_Click(object sender, EventArgs e)
        {
            mangJuan.Visible = true;
            int quantity = int.Parse(mangJuan.Text);
            quantity++;
            mangJuan.Text = quantity.ToString();

            int productCost = quantity * 15;
            productTotalCosts[3] = productCost;
            snacksOverallTotalCost = 0;
            for (int i = 0; i < 13; i++)
            {
                snacksOverallTotalCost += productTotalCosts[i];
            }
        }

        private void piattosBtn_Click(object sender, EventArgs e)
        {
            piattos.Visible = true;
            int quantity = int.Parse(piattos.Text);
            quantity++;
            piattos.Text = quantity.ToString();

            int productCost = quantity * 15;
            productTotalCosts[4] = productCost;
            snacksOverallTotalCost = 0;
            for (int i = 0; i < 13; i++)
            {
                snacksOverallTotalCost += productTotalCosts[i];
            }
        }

        private void cloverBtn_Click(object sender, EventArgs e)
        {
            clover.Visible = true;
            int quantity = int.Parse(clover.Text);
            quantity++;
            clover.Text = quantity.ToString();

            int productCost = quantity * 10;
            productTotalCosts[5] = productCost;
            snacksOverallTotalCost = 0;
            for (int i = 0; i < 13; i++)
            {
                snacksOverallTotalCost += productTotalCosts[i];
            }
        }

        private void pillowsBtn_Click(object sender, EventArgs e)
        {
            pillows.Visible = true;
            int quantity = int.Parse(pillows.Text);
            quantity++;
            pillows.Text = quantity.ToString();

            int productCost = quantity * 10;
            productTotalCosts[6] = productCost;
            snacksOverallTotalCost = 0;
            for (int i = 0; i < 13; i++)
            {
                snacksOverallTotalCost += productTotalCosts[i];
            }
        }

        private void dingDongBtn_Click(object sender, EventArgs e)
        {
            dingDong.Visible = true;
            int quantity = int.Parse(dingDong.Text);
            quantity++;
            dingDong.Text = quantity.ToString();

            int productCost = quantity * 18;
            productTotalCosts[7] = productCost;
            snacksOverallTotalCost = 0;
            for (int i = 0; i < 13; i++)
            {
                snacksOverallTotalCost += productTotalCosts[i];
            }
        }

        private void laysBtn_Click(object sender, EventArgs e)
        {
            lays.Visible = true;
            int quantity = int.Parse(lays.Text);
            quantity++;
            lays.Text = quantity.ToString();

            int productCost = quantity * 25;
            productTotalCosts[8] = productCost;
            snacksOverallTotalCost = 0;
            for (int i = 0; i < 13; i++)
            {
                snacksOverallTotalCost += productTotalCosts[i];
            }
        }

        private void cheetosBtn_Click(object sender, EventArgs e)
        {
            cheetos.Visible = true;
            int quantity = int.Parse(cheetos.Text);
            quantity++;
            cheetos.Text = quantity.ToString();

            int productCost = quantity * 20;
            productTotalCosts[9] = productCost;
            snacksOverallTotalCost = 0;
            for (int i = 0; i < 13; i++)
            {
                snacksOverallTotalCost += productTotalCosts[i];
            }
        }

        private void potatoChipsBtn_Click(object sender, EventArgs e)
        {
            potatoChips.Visible = true;
            int quantity = int.Parse(potatoChips.Text);
            quantity++;
            potatoChips.Text = quantity.ToString();

            int productCost = quantity * 18;
            productTotalCosts[10] = productCost;
            snacksOverallTotalCost = 0;
            for (int i = 0; i < 13; i++)
            {
                snacksOverallTotalCost += productTotalCosts[i];
            }
        }

        private void potatoFriesBtn_Click(object sender, EventArgs e)
        {
            potatoFries.Visible = true;
            int quantity = int.Parse(potatoFries.Text);
            quantity++;
            potatoFries.Text = quantity.ToString();

            int productCost = quantity * 12;
            productTotalCosts[11] = productCost;
            snacksOverallTotalCost = 0;
            for (int i = 0; i < 13; i++)
            {
                snacksOverallTotalCost += productTotalCosts[i];
            }
        }

        private void patataBtn_Click(object sender, EventArgs e)
        {
            patata.Visible = true;
            int quantity = int.Parse(patata.Text);
            quantity++;
            patata.Text = quantity.ToString();

            int productCost = quantity * 10;
            productTotalCosts[12] = productCost;
            snacksOverallTotalCost = 0;
            for (int i = 0; i < 13; i++)
            {
                snacksOverallTotalCost += productTotalCosts[i];
            }
        }

        private void checkPriceBtn_Click(object sender, EventArgs e)
        {
            amount.Text = "₱" + snacksOverallTotalCost.ToString(); // display the total cost of the product
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            snacksOverallTotalCost = 0;

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

            vcut.Visible = false;
            cracklings.Visible = false;
            mangJuan.Visible = false;
            piattos.Visible = false;
            clover.Visible = false;
            pillows.Visible = false;
            dingDong.Visible = false;
            lays.Visible = false;
            cheetos.Visible = false;
            potatoChips.Visible = false;
            potatoFries.Visible = false;
            patata.Visible = false;

            vcut.Text = "0";
            cracklings.Text = "0";
            mangJuan.Text = "0";
            piattos.Text = "0";
            clover.Text = "0";
            pillows.Text = "0";
            dingDong.Text = "0";
            lays.Text = "0";
            cheetos.Text = "0";
            potatoChips.Text = "0";
            potatoFries.Text = "0";
            patata.Text = "0";

            amount.Text = "";
        }
        //decrement buttons
        //decrement buttons
        //decrement buttons

        private void vcutDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(vcut.Text);

            if (quantity > 0)
            {
                vcut.Visible = true;
                quantity--;
                vcut.Text = quantity.ToString();

                int productCost = quantity * 15;
                productTotalCosts[1] = productCost;
                snacksOverallTotalCost = 0;
                for (int i = 0; i < 16; i++)
                {
                    snacksOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void cracklingsDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(cracklings.Text);

            if (quantity > 0)
            {
                cracklings.Visible = true;
                quantity--;
                cracklings.Text = quantity.ToString();

                int productCost = quantity * 12;
                productTotalCosts[2] = productCost;
                snacksOverallTotalCost = 0;
                for (int i = 0; i < 13; i++)
                {
                    snacksOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void mangJuanDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(mangJuan.Text);

            if (quantity > 0)
            {
                mangJuan.Visible = true;
                quantity--;
                mangJuan.Text = quantity.ToString();

                int productCost = quantity * 15;
                productTotalCosts[3] = productCost;
                snacksOverallTotalCost = 0;
                for (int i = 0; i < 13; i++)
                {
                    snacksOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void piattosDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(piattos.Text);

            if (quantity > 0)
            {
                piattos.Visible = true;
                quantity--;
                piattos.Text = quantity.ToString();

                int productCost = quantity * 15;
                productTotalCosts[4] = productCost;
                snacksOverallTotalCost = 0;
                for (int i = 0; i < 13; i++)
                {
                    snacksOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void cloverDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(clover.Text);

            if (quantity > 0)
            {
                clover.Visible = true;
                quantity--;
                clover.Text = quantity.ToString();

                int productCost = quantity * 10;
                productTotalCosts[5] = productCost;
                snacksOverallTotalCost = 0;
                for (int i = 0; i < 13; i++)
                {
                    snacksOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void pillowsDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(pillows.Text);

            if (quantity > 0)
            {
                pillows.Visible = true;
                quantity--;
                pillows.Text = quantity.ToString();

                int productCost = quantity * 10;
                productTotalCosts[6] = productCost;
                snacksOverallTotalCost = 0;
                for (int i = 0; i < 13; i++)
                {
                    snacksOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void dingDongDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(dingDong.Text);

            if (quantity > 0)
            {
                dingDong.Visible = true;
                quantity--;
                dingDong.Text = quantity.ToString();

                int productCost = quantity * 18;
                productTotalCosts[7] = productCost;
                snacksOverallTotalCost = 0;
                for (int i = 0; i < 13; i++)
                {
                    snacksOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void laysDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(lays.Text);

            if (quantity > 0)
            {
                lays.Visible = true;
                quantity--;
                lays.Text = quantity.ToString();

                int productCost = quantity * 25;
                productTotalCosts[8] = productCost;
                snacksOverallTotalCost = 0;
                for (int i = 0; i < 13; i++)
                {
                    snacksOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void cheetosDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(cheetos.Text);

            if (quantity > 0)
            {
                cheetos.Visible = true;
                quantity--;
                cheetos.Text = quantity.ToString();

                int productCost = quantity * 20;
                productTotalCosts[9] = productCost;
                snacksOverallTotalCost = 0;
                for (int i = 0; i < 13; i++)
                {
                    snacksOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void potatoChipsDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(potatoChips.Text);

            if (quantity > 0)
            {
                potatoChips.Visible = true;
                quantity--;
                potatoChips.Text = quantity.ToString();

                int productCost = quantity * 18;
                productTotalCosts[10] = productCost;
                snacksOverallTotalCost = 0;
                for (int i = 0; i < 13; i++)
                {
                    snacksOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void potatoFriesDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(potatoFries.Text);

            if (quantity > 0)
            {
                potatoFries.Visible = true;
                quantity--;
                potatoFries.Text = quantity.ToString();

                int productCost = quantity * 12;
                productTotalCosts[11] = productCost;
                snacksOverallTotalCost = 0;
                for (int i = 0; i < 13; i++)
                {
                    snacksOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void patataDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(patata.Text);

            if (quantity > 0)
            {
                patata.Visible = true;
                quantity--;
                patata.Text = quantity.ToString();

                int productCost = quantity * 10;
                productTotalCosts[12] = productCost;
                snacksOverallTotalCost = 0;
                for (int i = 0; i < 13; i++)
                {
                    snacksOverallTotalCost += productTotalCosts[i];
                }

            }
        }
    }
}
