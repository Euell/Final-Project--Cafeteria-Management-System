
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
            this.checkPriceBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.panel10.Controls.Add(this.checkPriceBtn);
            this.panel10.Controls.Add(this.clearBtn);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 577);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(907, 48);
            this.panel10.TabIndex = 30;
            // 
            // checkPriceBtn
            // 
            this.checkPriceBtn.BackColor = System.Drawing.Color.Teal;
            this.checkPriceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkPriceBtn.FlatAppearance.BorderSize = 0;
            this.checkPriceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkPriceBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPriceBtn.ForeColor = System.Drawing.Color.White;
            this.checkPriceBtn.Location = new System.Drawing.Point(610, 8);
            this.checkPriceBtn.Name = "checkPriceBtn";
            this.checkPriceBtn.Size = new System.Drawing.Size(94, 35);
            this.checkPriceBtn.TabIndex = 35;
            this.checkPriceBtn.Text = "Check Price";
            this.checkPriceBtn.UseVisualStyleBackColor = false;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.Teal;
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Image = global::Final_Project__Cafeteria_Management_System.Properties.Resources.clear;
            this.clearBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearBtn.Location = new System.Drawing.Point(510, 8);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(94, 35);
            this.clearBtn.TabIndex = 34;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            // 
            // amount
            // 
            this.amount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.amount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.amount.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.ForeColor = System.Drawing.Color.White;
            this.amount.Location = new System.Drawing.Point(154, 159);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(197, 37);
            this.amount.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(46, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 22);
            this.label8.TabIndex = 34;
            this.label8.Text = "Total price";
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
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button checkPriceBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Label label8;
    }
}
