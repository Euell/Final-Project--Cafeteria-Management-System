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
    public partial class Login : Form
    {
        public Login()
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
    
        private void loginbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM tbl_users WHERE username = '"+txt_username.Text+"' and password= '"+txt_password.Text+"'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if(dr.Read() == true)
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_username.Text = "";
                txt_password.Text = "";
                txt_username.Focus();
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
