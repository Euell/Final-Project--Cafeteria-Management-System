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
            Main main = new Main();
            main.Show();
            this.Hide();
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

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
