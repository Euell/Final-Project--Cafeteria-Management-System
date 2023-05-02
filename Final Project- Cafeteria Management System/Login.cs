using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Final_Project__Cafeteria_Management_System
{
    public partial class Login : Form
    {
    
        public Login()
        {
            InitializeComponent();
            
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    
        private void loginbtn_Click(object sender, EventArgs e)
        {
            string filePath = "credentials.txt";
  
            StreamReader reader = new StreamReader(filePath);

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] credentials = line.Split(':');
                if (credentials[0] == txt_username.Text && credentials[1] == txt_password.Text)
                {
                    MessageBox.Show("USER SUCCESSFULLY LOGGED IN!");
                    Main main = new Main();
                    main.Show();
                    this.Hide();
                }
                else if (credentials[0] != txt_username.Text || credentials[1] != txt_password.Text || txt_username.Text == " " || txt_password.Text == " ")
                {
                    MessageBox.Show("INVALID USERNAME OR PASSWORD");
                }
            }
        }

        private void signupbtn_Click_1(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();
        }
    
        private void showpassbtn_Click_1(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = false;
            showpassbtn.Visible = false;
            hidepassbtn.Visible = true;
        }

        private void hidepassbtn_Click_1(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = true;
            hidepassbtn.Visible = false;
            showpassbtn.Visible = true;
        }

    }
}
