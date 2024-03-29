﻿using System;
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

        private void OkBtn_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("item.txt"))
            {
                sw.Write(string.Empty);
            }
            this.Close();
        }

        private void purchaseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
