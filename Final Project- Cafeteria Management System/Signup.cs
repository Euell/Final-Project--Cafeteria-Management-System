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
    public partial class Signup : Form
    {
        private void txt_confirmPassword_TextChanged(object sender, EventArgs e)
        {

        }
        public Signup()
        {
            InitializeComponent();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
       

        private void showpassbtn_Click(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = false;
            showpassbtn1.Visible = false;
            hidepassbtn1.Visible = true;
        }

        private void hidepassbtn_Click(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = true;
            hidepassbtn1.Visible = false;
            showpassbtn1.Visible = true;

        }

        private void showpassbtn2_Click(object sender, EventArgs e)
        {
            txt_confirmPassword.UseSystemPasswordChar = false;
            showpassbtn2.Visible = false;
            hidepassbtn2.Visible = true;
        }

        private void hidepassbtn2_Click(object sender, EventArgs e)
        {
            txt_confirmPassword.UseSystemPasswordChar = true;
            hidepassbtn2.Visible = false;
            showpassbtn2.Visible = true;
        }
    }
}
