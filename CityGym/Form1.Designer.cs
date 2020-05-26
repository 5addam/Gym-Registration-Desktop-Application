namespace CityGym
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_members = new System.Windows.Forms.Button();
            this.btn_payment = new System.Windows.Forms.Button();
            this.payment1 = new CityGym.payment();
            this.members1 = new CityGym.members();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OliveDrab;
            this.panel1.Controls.Add(this.btn_members);
            this.panel1.Controls.Add(this.btn_payment);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1337, 58);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_members
            // 
            this.btn_members.FlatAppearance.BorderSize = 0;
            this.btn_members.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_members.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_members.ForeColor = System.Drawing.Color.White;
            this.btn_members.Location = new System.Drawing.Point(198, 3);
            this.btn_members.Name = "btn_members";
            this.btn_members.Size = new System.Drawing.Size(165, 52);
            this.btn_members.TabIndex = 1;
            this.btn_members.Text = "Manage Members";
            this.btn_members.UseVisualStyleBackColor = true;
            this.btn_members.Click += new System.EventHandler(this.btn_members_Click);
            // 
            // btn_payment
            // 
            this.btn_payment.FlatAppearance.BorderSize = 0;
            this.btn_payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_payment.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_payment.ForeColor = System.Drawing.Color.White;
            this.btn_payment.Location = new System.Drawing.Point(12, 3);
            this.btn_payment.Name = "btn_payment";
            this.btn_payment.Size = new System.Drawing.Size(147, 52);
            this.btn_payment.TabIndex = 0;
            this.btn_payment.Text = "Fee Payment";
            this.btn_payment.UseVisualStyleBackColor = true;
            this.btn_payment.Click += new System.EventHandler(this.btn_payment_Click);
            this.btn_payment.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_payment_MouseClick);
            // 
            // payment1
            // 
            this.payment1.AutoScroll = true;
            this.payment1.BackColor = System.Drawing.Color.White;
            this.payment1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.payment1.Location = new System.Drawing.Point(0, 58);
            this.payment1.Name = "payment1";
            this.payment1.Size = new System.Drawing.Size(1337, 568);
            this.payment1.TabIndex = 2;
            // 
            // members1
            // 
            this.members1.AutoScroll = true;
            this.members1.BackColor = System.Drawing.Color.White;
            this.members1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.members1.Location = new System.Drawing.Point(0, 58);
            this.members1.Name = "members1";
            this.members1.Size = new System.Drawing.Size(1337, 568);
            this.members1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1337, 626);
            this.Controls.Add(this.payment1);
            this.Controls.Add(this.members1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_members;
        private System.Windows.Forms.Button btn_payment;
        private members members1;
        private payment payment1;
    }
}

