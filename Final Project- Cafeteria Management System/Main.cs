﻿using System;
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
        //private decimal CalculateOverallTotalCost()
        //{
        //    decimal overallTotalCost = 0;
        //    overallTotalCost += drinksControl1.overallTotalCost;
        //    overallTotalCost += product2.GetTotalCost();
        //    // ...

        //    return overallTotalCost;
        //}

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

            mainControl1.BringToFront();
            drinksControl1.SendToBack();
            candiesControl11.SendToBack();
            snacksControl11.SendToBack();
            breadControl1.SendToBack();
        }

        private void drinksbtn_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            drinksPanel.Visible = true;
            candiesPanel.Visible = false;
            snacksPanel.Visible = false;
            breadsPanel.Visible = false;
          
            drinksControl1.BringToFront();
            mainControl1.SendToBack();
            candiesControl11.SendToBack();
            snacksControl11.SendToBack();
            breadControl1.SendToBack();
        }

        private void candiesbtn_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            drinksPanel.Visible = false;
            candiesPanel.Visible = true;
            snacksPanel.Visible = false;
            breadsPanel.Visible = false;

            candiesControl11.BringToFront();
            drinksControl1.SendToBack();
            mainControl1.SendToBack();
            snacksControl11.SendToBack();
            breadControl1.SendToBack();
        }

        private void snacksbtn_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            drinksPanel.Visible = false;
            candiesPanel.Visible = false;
            snacksPanel.Visible = true;
            breadsPanel.Visible = false;

            snacksControl11.BringToFront();
            candiesControl11.SendToBack();
            drinksControl1.SendToBack();
            mainControl1.SendToBack();
            breadControl1.SendToBack();
        }

        private void breadsbtn_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            drinksPanel.Visible = false;
            candiesPanel.Visible = false;
            snacksPanel.Visible = false;
            breadsPanel.Visible = true;

            breadControl1.BringToFront();
            snacksControl11.SendToBack();
            candiesControl11.SendToBack();
            drinksControl1.SendToBack();
            mainControl1.SendToBack();
        }
    }
}
