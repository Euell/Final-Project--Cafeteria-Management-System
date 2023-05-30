
namespace Final_Project__Cafeteria_Management_System
{
    partial class receipt
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox = new System.Windows.Forms.ListBox();
            this.closebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(13, 39);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(530, 589);
            this.listBox.TabIndex = 0;
            // 
            // closebtn
            // 
            this.closebtn.BackColor = System.Drawing.Color.Transparent;
            this.closebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closebtn.FlatAppearance.BorderSize = 0;
            this.closebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.ForeColor = System.Drawing.Color.White;
            this.closebtn.Location = new System.Drawing.Point(508, 0);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(40, 40);
            this.closebtn.TabIndex = 2;
            this.closebtn.Text = "X";
            this.closebtn.UseVisualStyleBackColor = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(555, 640);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.listBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "receipt";
            this.Text = "receipt";
            this.Load += new System.EventHandler(this.receipt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button closebtn;
    }
}