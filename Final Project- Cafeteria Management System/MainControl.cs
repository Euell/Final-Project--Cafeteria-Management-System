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
    public partial class MainControl : UserControl
    {
        private int[] productTotalCosts = new int[18]; // Array to store the total cost
        public int mainOverallTotalCost = 0; //Add up the total cost of all products in the productTotalCosts array
       
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
            quantity++; // incrementing the quantity of the sandwich
            eggSandwich.Text = quantity.ToString(); // converts the converted quantity to string so it can be displayed as "text"

            int productCost = quantity * 25; // A variable that holds the cost of the sandwich
            productTotalCosts[1] = productCost; // putting the product cost to the first index of the array 

            mainOverallTotalCost = 0; // calling a global variable to hold the total value of all the products
            for (int i = 0; i < 18; i++)
            {
                mainOverallTotalCost += productTotalCosts[i]; // created a for loop to sum up the total cost and returning it to the global variable
            }
            eggAdd.Visible = true;
        }

        private void cheeseSandwichBtn_Click(object sender, EventArgs e)
        {
            cheeseSandwich.Visible = true;
            int quantity = int.Parse(cheeseSandwich.Text);
            quantity++;
            cheeseSandwich.Text = quantity.ToString();

            int productCost = quantity * 20;
            productTotalCosts[2] = productCost;
            mainOverallTotalCost = 0;
            for (int i = 0; i < 18; i++)
            {
                mainOverallTotalCost += productTotalCosts[i];
            }
            cheeseAdd.Visible = true;
        }

        private void chickenSandwichBtn_Click(object sender, EventArgs e)
        {
            chickenSandwich.Visible = true;
            int quantity = int.Parse(chickenSandwich.Text);
            quantity++;
            chickenSandwich.Text = quantity.ToString();

            int productCost = quantity * 30;
            productTotalCosts[3] = productCost;
            mainOverallTotalCost = 0;
            for (int i = 0; i < 18; i++)
            {
                mainOverallTotalCost += productTotalCosts[i];
            }
            chickenAdd.Visible = true;
        }

        private void vegSandwichBtn_Click(object sender, EventArgs e)
        {
            vegSandwich.Visible = true;
            int quantity = int.Parse(vegSandwich.Text);
            quantity++;
            vegSandwich.Text = quantity.ToString();

            int productCost = quantity * 25;
            productTotalCosts[4] = productCost;
            mainOverallTotalCost = 0;
            for (int i = 0; i < 18; i++)
            {
                mainOverallTotalCost += productTotalCosts[i];
            }
            vegAdd.Visible = true;
        }

        private void eggAndCheeseSandwichBtn_Click(object sender, EventArgs e)
        {
            eggAndCheeseSandwich.Visible = true;
            int quantity = int.Parse(eggAndCheeseSandwich.Text);
            quantity++;
            eggAndCheeseSandwich.Text = quantity.ToString();

            int productCost = quantity * 30;
            productTotalCosts[5] = productCost;
            mainOverallTotalCost = 0;
            for (int i = 0; i < 18; i++)
            {
                mainOverallTotalCost += productTotalCosts[i];
            }
            eggAndCheeseAdd.Visible = true;
        }

        private void vegAndCheeseSandwichBtn_Click(object sender, EventArgs e)
        {
            vegAndCheeseSandwich.Visible = true;
            int quantity = int.Parse(vegAndCheeseSandwich.Text);
            quantity++;
            vegAndCheeseSandwich.Text = quantity.ToString();

            int productCost = quantity * 30;
            productTotalCosts[6] = productCost;
            mainOverallTotalCost = 0;
            for (int i = 0; i < 18; i++)
            {
                mainOverallTotalCost += productTotalCosts[i];
            }
            begAndCheeseAdd.Visible = true;
        }

        private void chickenAndCheeseSandwichBtn_Click(object sender, EventArgs e)
        {
            chickenAndCheeseSandwich.Visible = true;
            int quantity = int.Parse(chickenAndCheeseSandwich.Text);
            quantity++;
            chickenAndCheeseSandwich.Text = quantity.ToString();

            int productCost = quantity * 35;
            productTotalCosts[7] = productCost;
            mainOverallTotalCost = 0;
            for (int i = 0; i < 18; i++)
            {
                mainOverallTotalCost += productTotalCosts[i];
            }
            chickenAndCheeseAdd.Visible = true;
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
            mainOverallTotalCost = 0;
            for (int i = 0; i < 18; i++)
            {
                mainOverallTotalCost += productTotalCosts[i];
            }
            kwekkwekAdd.Visible = true;
        }

        private void fishBallsBtn_Click(object sender, EventArgs e)
        {
            fishBalls.Visible = true;
            int quantity = int.Parse(fishBalls.Text);
            quantity++;
            fishBalls.Text = quantity.ToString();

            int productCost = quantity * 20;
            productTotalCosts[9] = productCost;
            mainOverallTotalCost = 0;
            for (int i = 0; i < 18; i++)
            {
                mainOverallTotalCost += productTotalCosts[i];
            }
            fishBallAdd.Visible = true;
        }

        private void squidBallsBtn_Click(object sender, EventArgs e)
        {
            squidBalls.Visible = true;
            int quantity = int.Parse(squidBalls.Text);
            quantity++;
            squidBalls.Text = quantity.ToString();

            int productCost = quantity * 20;
            productTotalCosts[10] = productCost;
            mainOverallTotalCost = 0;
            for (int i = 0; i < 18; i++)
            {
                mainOverallTotalCost += productTotalCosts[i];
            }
            squidBallAdd.Visible = true;
        }

        private void BananacueBtn_Click(object sender, EventArgs e)
        {
            Bananacue.Visible = true;
            int quantity = int.Parse(Bananacue.Text);
            quantity++;
            Bananacue.Text = quantity.ToString();

            int productCost = quantity * 25;
            productTotalCosts[11] = productCost;
            mainOverallTotalCost = 0;
            for (int i = 0; i < 18; i++)
            {
                mainOverallTotalCost += productTotalCosts[i];
            }
            bananaCueAdd.Visible = true;
        }

        private void TuronBtn_Click(object sender, EventArgs e)
        {
            Turon.Visible = true;
            int quantity = int.Parse(Turon.Text);
            quantity++;
            Turon.Text = quantity.ToString();

            int productCost = quantity * 25;
            productTotalCosts[12] = productCost;
            mainOverallTotalCost = 0;
            for (int i = 0; i < 18; i++)
            {
                mainOverallTotalCost += productTotalCosts[i];
            }
            turonAdd.Visible = true;
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
            mainOverallTotalCost = 0;
            for (int i = 0; i < 18; i++)
            {
                mainOverallTotalCost += productTotalCosts[i];
            }
            chickenNoodlesAdd.Visible = true;
        }

        private void beefBtn_Click(object sender, EventArgs e)
        {
            beef.Visible = true;
            int quantity = int.Parse(beef.Text);
            quantity++;
            beef.Text = quantity.ToString();

            int productCost = quantity * 25;
            productTotalCosts[14] = productCost;
            mainOverallTotalCost = 0;
            for (int i = 0; i < 18; i++)
            {
                mainOverallTotalCost += productTotalCosts[i];
            }
            beefAdd.Visible = true;
        }

        private void porkBtn_Click(object sender, EventArgs e)
        {
            pork.Visible = true;
            int quantity = int.Parse(pork.Text);
            quantity++;
            pork.Text = quantity.ToString();

            int productCost = quantity * 25;
            productTotalCosts[15] = productCost;
            mainOverallTotalCost = 0;
            for (int i = 0; i < 18; i++)
            {
                mainOverallTotalCost += productTotalCosts[i];
            }
            porkAdd.Visible = true;
        }

        private void laPazBatchoyBtn_Click(object sender, EventArgs e)
        {
            laPazBatchoy.Visible = true;
            int quantity = int.Parse(laPazBatchoy.Text);
            quantity++;
            laPazBatchoy.Text = quantity.ToString();

            int productCost = quantity * 25;
            productTotalCosts[16] = productCost;
            mainOverallTotalCost = 0;
            for (int i = 0; i < 18; i++)
            {
                mainOverallTotalCost += productTotalCosts[i];
            }
            laPazAdd.Visible = true;
        }

        private void bulaloBtn_Click(object sender, EventArgs e)
        {
            bulalo.Visible = true;
            int quantity = int.Parse(bulalo.Text);
            quantity++;
            bulalo.Text = quantity.ToString();

            int productCost = quantity * 25;
            productTotalCosts[17] = productCost;
            mainOverallTotalCost = 0;
            for (int i = 0; i < 18; i++)
            {
                mainOverallTotalCost += productTotalCosts[i];
            }
            bulaloAdd.Visible = true;
        }

        private void checkPriceBtn_Click(object sender, EventArgs e)
        {
            amount.Text = "₱" + mainOverallTotalCost.ToString(); // display the total cost of the product
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            mainOverallTotalCost = 0; // the total cost of the products will be 0

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

        //decrement of Sandwich
        //decrement of Sandwich
        //decrement of Sandwich
        private void eggDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(eggSandwich.Text);

            if (quantity > 0)
            {
                eggSandwich.Visible = true;
                quantity--;
                eggSandwich.Text = quantity.ToString();

                int productCost = quantity * 25;
                productTotalCosts[1] = productCost;
                mainOverallTotalCost = 0;
                for (int i = 0; i < 18; i++)
                {
                    mainOverallTotalCost += productTotalCosts[i];
                }
            }
          
        }

        private void cheeseDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(cheeseSandwich.Text);

            if (quantity > 0)
            {
                cheeseSandwich.Visible = true;
                quantity--;
                cheeseSandwich.Text = quantity.ToString();

                int productCost = quantity * 20;
                productTotalCosts[2] = productCost;
                mainOverallTotalCost = 0;
                for (int i = 0; i < 18; i++)
                {
                    mainOverallTotalCost += productTotalCosts[i];
                }
            }

        }

        private void chickenDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(chickenSandwich.Text);

            if (quantity > 0)
            {
                chickenSandwich.Visible = true;
                quantity--;
                chickenSandwich.Text = quantity.ToString();

                int productCost = quantity * 30;
                productTotalCosts[3] = productCost;
                mainOverallTotalCost = 0;
                for (int i = 0; i < 18; i++)
                {
                    mainOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void vegDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(vegSandwich.Text);

            if (quantity > 0)
            {
                vegSandwich.Visible = true;
                quantity--;
                vegSandwich.Text = quantity.ToString();

                int productCost = quantity * 25;
                productTotalCosts[4] = productCost;
                mainOverallTotalCost = 0;
                for (int i = 0; i < 18; i++)
                {
                    mainOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void eggCheeseDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(eggAndCheeseSandwich.Text);

            if (quantity > 0)
            {
                eggAndCheeseSandwich.Visible = true;
                quantity--;
                eggAndCheeseSandwich.Text = quantity.ToString();

                int productCost = quantity * 30;
                productTotalCosts[5] = productCost;
                mainOverallTotalCost = 0;
                for (int i = 0; i < 18; i++)
                {
                    mainOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void vegCheeseDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(vegAndCheeseSandwich.Text);

            if (quantity > 0)
            {
                vegAndCheeseSandwich.Visible = true;
                quantity--;
                vegAndCheeseSandwich.Text = quantity.ToString();

                int productCost = quantity * 30;
                productTotalCosts[6] = productCost;
                mainOverallTotalCost = 0;
                for (int i = 0; i < 18; i++)
                {
                    mainOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void chickenCheeseDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(chickenAndCheeseSandwich.Text);

            if (quantity > 0)
            {
                chickenAndCheeseSandwich.Visible = true;
                quantity--;
                chickenAndCheeseSandwich.Text = quantity.ToString();

                int productCost = quantity * 35;
                productTotalCosts[7] = productCost;
                mainOverallTotalCost = 0;
                for (int i = 0; i < 18; i++)
                {
                    mainOverallTotalCost += productTotalCosts[i];
                }

            }
        }
        //decrement of street foods
        //decrement of street foods
        //decrement of street foods
        private void kwekkwekDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(kwekkwek.Text);

            if (quantity > 0)
            {
                kwekkwek.Visible = true;
                quantity--;
                kwekkwek.Text = quantity.ToString();

                int productCost = quantity * 20;
                productTotalCosts[8] = productCost;
                mainOverallTotalCost = 0;
                for (int i = 0; i < 18; i++)
                {
                    mainOverallTotalCost += productTotalCosts[i];
                }
            }
        }

        private void fishBallDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(fishBalls.Text);

            if (quantity > 0)
            {
                fishBalls.Visible = true;
                quantity--;
                fishBalls.Text = quantity.ToString();

                int productCost = quantity * 20;
                productTotalCosts[9] = productCost;
                mainOverallTotalCost = 0;
                for (int i = 0; i < 18; i++)
                {
                    mainOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void squidBallDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(squidBalls.Text);

            if (quantity > 0)
            {
                squidBalls.Visible = true;
                quantity--;
                squidBalls.Text = quantity.ToString();

                int productCost = quantity * 20;
                productTotalCosts[10] = productCost;
                mainOverallTotalCost = 0;
                for (int i = 0; i < 18; i++)
                {
                    mainOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void bananaCueDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(Bananacue.Text);

            if (quantity > 0)
            {
                Bananacue.Visible = true;
                quantity--;
                Bananacue.Text = quantity.ToString();

                int productCost = quantity * 25;
                productTotalCosts[11] = productCost;
                mainOverallTotalCost = 0;
                for (int i = 0; i < 18; i++)
                {
                    mainOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void turonDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(Turon.Text);

            if (quantity > 0)
            {
                Turon.Visible = true;
                quantity--;
                Turon.Text = quantity.ToString();

                int productCost = quantity * 25;
                productTotalCosts[12] = productCost;
                mainOverallTotalCost = 0;
                for (int i = 0; i < 18; i++)
                {
                    mainOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        //decrement of noodles
        //decrement of noodles
        //decrement of noodles
        private void chickenNoodlesDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(chicken.Text);

            if (quantity > 0)
            {
                chicken.Visible = true;
                quantity--;
                chicken.Text = quantity.ToString();

                int productCost = quantity * 25;
                productTotalCosts[13] = productCost;
                mainOverallTotalCost = 0;
                for (int i = 0; i < 18; i++)
                {
                    mainOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void beefDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(beef.Text);

            if (quantity > 0)
            {
                beef.Visible = true;
                quantity--;
                beef.Text = quantity.ToString();

                int productCost = quantity * 25;
                productTotalCosts[14] = productCost;
                mainOverallTotalCost = 0;
                for (int i = 0; i < 18; i++)
                {
                    mainOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void porkDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(pork.Text);

            if (quantity > 0)
            {
                pork.Visible = true;
                quantity--;
                pork.Text = quantity.ToString();

                int productCost = quantity * 25;
                productTotalCosts[15] = productCost;
                mainOverallTotalCost = 0;
                for (int i = 0; i < 18; i++)
                {
                    mainOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void laPazBatchoyDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(laPazBatchoy.Text);

            if (quantity > 0)
            {
                laPazBatchoy.Visible = true;
                quantity--;
                laPazBatchoy.Text = quantity.ToString();

                int productCost = quantity * 25;
                productTotalCosts[16] = productCost;
                mainOverallTotalCost = 0;
                for (int i = 0; i < 18; i++)
                {
                    mainOverallTotalCost += productTotalCosts[i];
                }

            }
        }

        private void bulaloDcBtn_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(bulalo.Text);

            if (quantity > 0)
            {
                bulalo.Visible = true;
                quantity--;
                bulalo.Text = quantity.ToString();

                int productCost = quantity * 25;
                productTotalCosts[17] = productCost;
                mainOverallTotalCost = 0;
                for (int i = 0; i < 18; i++)
                {
                    mainOverallTotalCost += productTotalCosts[i];
                }

            }
        }
         
       private void addToCart_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("item.txt", true))
            {
                writer.WriteLine("Egg Sandwich x " + eggSandwich.Text);
            }
            eggAdd.Visible = false;
        }

        private void cheeseAdd_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("item.txt", true))
            {
                writer.WriteLine("Cheese Sandwich x " + cheeseSandwich.Text);
            }
            cheeseAdd.Visible = false;
        }

        private void chickenAdd_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("item.txt", true))
            {
                writer.WriteLine("Chicken Sandwich x " + chickenSandwich.Text);
            }
            chickenAdd.Visible = false;
        }

        private void vegAdd_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("item.txt", true))
            {
                writer.WriteLine("Veg Sandwich x " + vegSandwich.Text);
            }
            vegAdd.Visible = false;
        }

        private void eggAndCheeseAdd_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("item.txt", true))
            {
                writer.WriteLine("Egg and Cheese Sandwich x " + eggAndCheeseSandwich.Text);
            }
            eggAndCheeseAdd.Visible = false;
        }

        private void begAndCheeseAdd_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("item.txt", true))
            {
                writer.WriteLine("Veg and Cheese Sandwich x " + vegAndCheeseSandwich.Text);
            }
            begAndCheeseAdd.Visible = false;
        }

        private void chickenAndCheeseAdd_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("item.txt", true))
            {
                writer.WriteLine("Chicken and Cheese sandwich x " + chickenAndCheeseSandwich.Text);
            }
            chickenAndCheeseAdd.Visible = false;
        }
        //Street Foods
        //Street Foods
        //Street Foods
        private void kwekkwekAdd_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("item.txt", true))
            {
                writer.WriteLine("Kwek Kwek x " + kwekkwek.Text);
            }
            kwekkwekAdd.Visible = false;
        }

        private void fishBallAdd_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("item.txt", true))
            {
                writer.WriteLine("Fish Balls x " + fishBalls.Text);
            }
            fishBallAdd.Visible = false;
        }

        private void squidBallAdd_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("item.txt", true))
            {
                writer.WriteLine("Squid Balls x " + squidBalls.Text);
            }
            squidBallAdd.Visible = false;

        }
        private void bananaCueAdd_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("item.txt", true))
            {
                writer.WriteLine("Banana Cue x " + Bananacue.Text);
            }
            bananaCueAdd.Visible = false;
        }
        private void turonAdd_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("item.txt", true))
            {
                writer.WriteLine("Turon x " + Turon.Text);
            }
            turonAdd.Visible = false;
        }
        //noodles
        //noodles
        //noodles


        private void chickenNoodlesAdd_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("item.txt", true))
            {
                writer.WriteLine("Chicken Noodles x " + chicken.Text);
            }
            chickenNoodlesAdd.Visible = false;
        }

        private void beefAdd_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("item.txt", true))
            {
                writer.WriteLine("Beef Noodles x " + beef.Text);
            }
            beefAdd.Visible = false;

        }

        private void porkAdd_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("item.txt", true))
            {
                writer.WriteLine("Pork Noodles x " + pork.Text);
            }
            porkAdd.Visible = false;
        }

        private void laPazAdd_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("item.txt", true))
            {
                writer.WriteLine("La Paz Batchoy Noodles x " + laPazBatchoy.Text);
            }
            laPazAdd.Visible = false;
        }

        private void bulaloAdd_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("item.txt", true))
            {
                writer.WriteLine("Bulalo Noodles x " + bulalo.Text);
            }
            bulaloAdd.Visible = false;
        }
    }
}
