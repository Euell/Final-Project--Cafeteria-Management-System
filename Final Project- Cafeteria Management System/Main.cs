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
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        bool sidebarExpand;
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }

            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }
        private void menubtn_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();


            homePanel.Visible = false;
            drinksPanel.Visible = false;
            candiesPanel.Visible = false;
            snacksPanel.Visible = false;
            breadsPanel.Visible = false;
            menuPanel.Visible = true;
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
            menuPanel.Visible = false;
        }

        private void drinksbtn_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            drinksPanel.Visible = true;
            candiesPanel.Visible = false;
            snacksPanel.Visible = false;
            breadsPanel.Visible = false;
            menuPanel.Visible = false;
        }

        private void candiesbtn_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            drinksPanel.Visible = false;
            candiesPanel.Visible = true;
            snacksPanel.Visible = false;
            breadsPanel.Visible = false;
            menuPanel.Visible = false;
        }

        private void snacksbtn_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            drinksPanel.Visible = false;
            candiesPanel.Visible = false;
            snacksPanel.Visible = true;
            breadsPanel.Visible = false;
            menuPanel.Visible = false;
        }

        private void breadsbtn_Click(object sender, EventArgs e)
        {
            homePanel.Visible = false;
            drinksPanel.Visible = false;
            candiesPanel.Visible = false;
            snacksPanel.Visible = false;
            breadsPanel.Visible = true;
              menuPanel.Visible = false;
        }

       
    }
}
