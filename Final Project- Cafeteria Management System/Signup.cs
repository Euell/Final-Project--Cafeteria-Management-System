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
    public partial class Signup : Form
    {
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
            string filePath = "credentials.txt";
            
            if (txt_password.Text != txt_confirmPassword.Text || txt_username.Text == "" || txt_password.Text == "" || txt_confirmPassword.Text == "")
            {
                MessageBox.Show("UNMATCHED PASSWORD");
                txt_confirmPassword.Clear();
            } else if(txt_password.Text == txt_confirmPassword.Text && txt_password.Text != "" && txt_confirmPassword.Text != "")
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(txt_username.Text + ":" + txt_password.Text);
                }
                MessageBox.Show("USER SUCCESSFULLY REGISTERED!");
                Login login = new Login();
                login.Show();
                this.Hide();
            }
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
