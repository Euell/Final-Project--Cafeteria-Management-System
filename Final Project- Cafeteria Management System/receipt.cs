using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Final_Project__Cafeteria_Management_System
{
    public partial class receipt : Form
    {
        public receipt()
        {
            
            InitializeComponent();
        }

        private void receipt_Load(object sender, EventArgs e)
        {
            string filePath = "item.txt"; // Replace with the path to your file

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        listBox.Items.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

       
        private void closebtn_Click(object sender, EventArgs e)
        {
            paymentControl1 payment = new paymentControl1();
            this.Hide();
            payment.Show();
            // receipt back = new receipt();
        }
    }

}
