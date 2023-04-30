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

            bool result = CheckUSER(txt_username.Text);

            if(result == false)
            {
                INSERTUSER();
            }
            else
            {
                MessageBox.Show("USER ALREADY EXIST!");
            }
        }

        public void INSERTUSER()
        {
            try 
            { 
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Server=DESKTOP-MUA28CG;Initial Catalog=FinalProject_CafeteriaManagementSystem;Integrated Security=SSPI";
            cnn = new SqlConnection(connetionString);
            //try
            //{
            cnn.Open();
            string query = @"INSERT INTO TBL_USERS  (USER_NAME,PASSWORD,DATE_REGISTERED) VALUES (@USERNAME,@PASSWORD,GETDATE())";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.AddWithValue("@USERNAME", txt_username.Text);
            cmd.Parameters.AddWithValue("@PASSWORD", txt_password.Text);


            cmd.ExecuteNonQuery();

            cnn.Close();
                MessageBox.Show("USER SUCCESSFULLY REGISTERED!");

                Login login = new Login();
                login.Show();
                this.Hide();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public bool CheckUSER(string USERID)
        {
            bool result = false;
            int counter = 0;
          
            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Server=DESKTOP-MUA28CG;Initial Catalog=FinalProject_CafeteriaManagementSystem;Integrated Security=SSPI";
            cnn = new SqlConnection(connetionString);
           
            cnn.Open();
            string query = @"SELECT COUNT(1) AS MYCOUNT FROM TBL_USERS WHERE USER_NAME = @USERNAME";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.AddWithValue("@USERNAME", USERID);


            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                    while (reader.Read())
                    {
                        counter = Convert.ToInt32(reader["MYCOUNT"].ToString());
                    }

            }
            cnn.Close();       
            if (counter > 0)
            {
                result = true;
            }

            return result;
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
