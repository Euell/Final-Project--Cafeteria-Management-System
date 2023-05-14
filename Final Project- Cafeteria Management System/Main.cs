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
    public partial class Main : Form
    {
        decimal overallTotalCost = 0;
        private decimal CalculateOverallTotalCost()
        {
            overallTotalCost += mainControl1.mainOverallTotalCost;
            overallTotalCost += drinksControl1.drinksOverallTotalCost;
            overallTotalCost += candiesControl11.candiesOverallTotalCost;
            overallTotalCost += snacksControl11.snacksOverallTotalCost;
            overallTotalCost += breadControl1.breadOverallTotalCost;

            return overallTotalCost;
        }

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            homePanel.Visible = true;
            drinksPanel.Visible = false;
            candiesPanel.Visible = false;
            snacksPanel.Visible = false;
            breadsPanel.Visible = false;
            paymentPanel.Visible = false;

            mainControl1.BringToFront();
            drinksControl1.SendToBack();
            candiesControl11.SendToBack();
            snacksControl11.SendToBack();
            breadControl1.SendToBack();
            paymentControl11.SendToBack();

        }

        private void drinksbtn_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            drinksPanel.Visible = true;
            candiesPanel.Visible = false;
            snacksPanel.Visible = false;
            breadsPanel.Visible = false;
            paymentPanel.Visible = false;

            drinksControl1.BringToFront();
            mainControl1.SendToBack();
            candiesControl11.SendToBack();
            snacksControl11.SendToBack();
            breadControl1.SendToBack();
            paymentControl11.SendToBack();

        }

        private void candiesbtn_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            drinksPanel.Visible = false;
            candiesPanel.Visible = true;
            snacksPanel.Visible = false;
            breadsPanel.Visible = false;
            paymentPanel.Visible = false;

            candiesControl11.BringToFront();
            drinksControl1.SendToBack();
            mainControl1.SendToBack();
            snacksControl11.SendToBack();
            breadControl1.SendToBack();
            paymentControl11.SendToBack();

        }

        private void snacksbtn_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            drinksPanel.Visible = false;
            candiesPanel.Visible = false;
            snacksPanel.Visible = true;
            breadsPanel.Visible = false;
            paymentPanel.Visible = false;

            snacksControl11.BringToFront();
            candiesControl11.SendToBack();
            drinksControl1.SendToBack();
            mainControl1.SendToBack();
            breadControl1.SendToBack();
            paymentControl11.SendToBack();

        }

        private void breadsbtn_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            drinksPanel.Visible = false;
            candiesPanel.Visible = false;
            snacksPanel.Visible = false;
            paymentPanel.Visible = false;
            breadsPanel.Visible = true;

            breadControl1.BringToFront();
            snacksControl11.SendToBack();
            candiesControl11.SendToBack();
            drinksControl1.SendToBack();
            mainControl1.SendToBack();
            paymentControl11.SendToBack();


        }

        private void paymentBtn_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            drinksPanel.Visible = false;
            candiesPanel.Visible = false;
            snacksPanel.Visible = false;
            breadsPanel.Visible = false;
            paymentPanel.Visible = true;

            paymentControl11.BringToFront();
            breadControl1.SendToBack();
            snacksControl11.SendToBack();
            candiesControl11.SendToBack();
            drinksControl1.SendToBack();
            mainControl1.SendToBack();

            CalculateOverallTotalCost();
            paymentControl11.amount.Text = overallTotalCost.ToString();
        }
    }
}
