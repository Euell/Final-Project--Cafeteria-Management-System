
namespace Final_Project__Cafeteria_Management_System
{
    partial class PaymentControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.totalCost = new System.Windows.Forms.Label();
            this.checkTotalBtn = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.totalTxt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.drinksControl1 = new Final_Project__Cafeteria_Management_System.DrinksControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mainPanel.Controls.Add(this.dataGridView1);
            this.mainPanel.Controls.Add(this.totalCost);
            this.mainPanel.Controls.Add(this.checkTotalBtn);
            this.mainPanel.Controls.Add(this.txt_username);
            this.mainPanel.Controls.Add(this.totalTxt);
            this.mainPanel.Controls.Add(this.label7);
            this.mainPanel.Controls.Add(this.panel12);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(907, 625);
            this.mainPanel.TabIndex = 16;
            // 
            // totalCost
            // 
            this.totalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalCost.Enabled = false;
            this.totalCost.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.totalCost.Location = new System.Drawing.Point(203, 250);
            this.totalCost.Name = "totalCost";
            this.totalCost.Size = new System.Drawing.Size(195, 35);
            this.totalCost.TabIndex = 44;
            // 
            // checkTotalBtn
            // 
            this.checkTotalBtn.BackColor = System.Drawing.Color.Teal;
            this.checkTotalBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkTotalBtn.FlatAppearance.BorderSize = 0;
            this.checkTotalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkTotalBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTotalBtn.ForeColor = System.Drawing.Color.White;
            this.checkTotalBtn.Location = new System.Drawing.Point(25, 250);
            this.checkTotalBtn.Name = "checkTotalBtn";
            this.checkTotalBtn.Size = new System.Drawing.Size(148, 35);
            this.checkTotalBtn.TabIndex = 43;
            this.checkTotalBtn.Text = "Check total cost";
            this.checkTotalBtn.UseVisualStyleBackColor = false;
            this.checkTotalBtn.Click += new System.EventHandler(this.checkTotalBtn_Click);
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_username.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.White;
            this.txt_username.Location = new System.Drawing.Point(203, 320);
            this.txt_username.Multiline = true;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(195, 27);
            this.txt_username.TabIndex = 40;
            // 
            // totalTxt
            // 
            this.totalTxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalTxt.Enabled = false;
            this.totalTxt.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.totalTxt.Location = new System.Drawing.Point(203, 262);
            this.totalTxt.Name = "totalTxt";
            this.totalTxt.Size = new System.Drawing.Size(29, 23);
            this.totalTxt.TabIndex = 39;
            this.totalTxt.Visible = false;
            this.totalTxt.Click += new System.EventHandler(this.totalTxt_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Teal;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(24, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 34);
            this.label7.TabIndex = 33;
            this.label7.Text = "Enter payment";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel12
            // 
            this.panel12.BackgroundImage = global::Final_Project__Cafeteria_Management_System.Properties.Resources._411dd3d08336a70457a3d8ef578f66b9;
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(0, 577);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(907, 48);
            this.panel12.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vivaldi", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(349, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 76);
            this.label2.TabIndex = 7;
            this.label2.Text = "Payment";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Final_Project__Cafeteria_Management_System.Properties.Resources._411dd3d08336a70457a3d8ef578f66b9;
            this.panel1.Controls.Add(this.drinksControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 48);
            this.panel1.TabIndex = 32;
            // 
            // drinksControl1
            // 
            this.drinksControl1.Location = new System.Drawing.Point(0, -3);
            this.drinksControl1.Name = "drinksControl1";
            this.drinksControl1.Size = new System.Drawing.Size(907, 625);
            this.drinksControl1.TabIndex = 0;
            this.drinksControl1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(443, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(400, 214);
            this.dataGridView1.TabIndex = 46;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "product";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "quantity";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "price";
            this.Column3.Name = "Column3";
            // 
            // PaymentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Name = "PaymentControl";
            this.Size = new System.Drawing.Size(907, 625);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_username;
        public System.Windows.Forms.Label totalTxt;
        private System.Windows.Forms.Button checkTotalBtn;
        public System.Windows.Forms.Label totalCost;
        private DrinksControl drinksControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}
