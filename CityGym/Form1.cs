using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityGym
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            members1.Visible = false;
            payment1.Visible = false;



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            btn_payment.ForeColor = Color.Black;
            btn_members.ForeColor = Color.White;

            payment1.Visible = true;
            payment1.BringToFront();
        }

        private void btn_members_Click(object sender, EventArgs e)
        {
            btn_payment.ForeColor = Color.White;
            btn_members.ForeColor = Color.Black;
            members1.Visible = true;
            members1.BringToFront();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void btn_payment_MouseClick(object sender, MouseEventArgs e)
        {
            
            



        }

    }
}