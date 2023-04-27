using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Final_Project__Cafeteria_Management_System
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();

           
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
          

            if (txt_username.Text == "" && txt_password.Text == "" && txt_confirmPassword.Text == "")
            {
                MessageBox.Show("Username and Passwords are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_password.Text == txt_confirmPassword.Text)
            {
                con.Open();
                string register = "INSERT INTO tbl_users VALUES ('" + txt_username.Text + "' , '" + txt_password.Text + "')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                txt_username.Text = "";
                txt_password.Text = "";
                txt_confirmPassword.Text = "";

                MessageBox.Show("Account Succesfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Password does not match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_password.Text = "";
                txt_confirmPassword.Text = "";
                txt_password.Focus();
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
