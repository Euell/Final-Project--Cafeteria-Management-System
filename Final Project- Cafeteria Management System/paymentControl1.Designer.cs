
namespace Final_Project__Cafeteria_Management_System
{
    partial class paymentControl1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.payBtn = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.paymentAmount = new System.Windows.Forms.TextBox();
            this.totalPayment = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.totalPayment);
            this.panel1.Controls.Add(this.payBtn);
            this.panel1.Controls.Add(this.paymentAmount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.amount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 625);
            this.panel1.TabIndex = 2;
            // 
            // panel11
            // 
            this.panel11.BackgroundImage = global::Final_Project__Cafeteria_Management_System.Properties.Resources._411dd3d08336a70457a3d8ef578f66b9;
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(907, 48);
            this.panel11.TabIndex = 31;
            // 
            // panel10
            // 
            this.panel10.BackgroundImage = global::Final_Project__Cafeteria_Management_System.Properties.Resources._411dd3d08336a70457a3d8ef578f66b9;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 577);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(907, 48);
            this.panel10.TabIndex = 30;
            // 
            // payBtn
            // 
            this.payBtn.BackColor = System.Drawing.Color.Teal;
            this.payBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.payBtn.FlatAppearance.BorderSize = 0;
            this.payBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payBtn.ForeColor = System.Drawing.Color.White;
            this.payBtn.Location = new System.Drawing.Point(76, 284);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(94, 35);
            this.payBtn.TabIndex = 35;
            this.payBtn.Text = "Pay";
            this.payBtn.UseVisualStyleBackColor = false;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // amount
            // 
            this.amount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.amount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.amount.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.ForeColor = System.Drawing.Color.White;
            this.amount.Location = new System.Drawing.Point(191, 164);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(196, 27);
            this.amount.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(72, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 22);
            this.label8.TabIndex = 34;
            this.label8.Text = "Total price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 35;
            this.label1.Text = "Payment amount";
            // 
            // paymentAmount
            // 
            this.paymentAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paymentAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentAmount.ForeColor = System.Drawing.Color.Black;
            this.paymentAmount.Location = new System.Drawing.Point(191, 220);
            this.paymentAmount.Multiline = true;
            this.paymentAmount.Name = "paymentAmount";
            this.paymentAmount.Size = new System.Drawing.Size(196, 22);
            this.paymentAmount.TabIndex = 36;
            // 
            // totalPayment
            // 
            this.totalPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.totalPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalPayment.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPayment.ForeColor = System.Drawing.Color.White;
            this.totalPayment.Location = new System.Drawing.Point(191, 292);
            this.totalPayment.Name = "totalPayment";
            this.totalPayment.Size = new System.Drawing.Size(196, 27);
            this.totalPayment.TabIndex = 37;
            // 
            // paymentControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "paymentControl1";
            this.Size = new System.Drawing.Size(907, 625);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button payBtn;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox paymentAmount;
        public System.Windows.Forms.Label totalPayment;
    }
}
