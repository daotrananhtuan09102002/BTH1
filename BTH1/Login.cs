using BTH1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baithuchanh1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private Boolean isShowPass = false;
        private Home HomeForm = null;
        public Login(Form callingForm)
        {
            HomeForm = callingForm as Home;
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // switch isShowPass to opposite value
            isShowPass = !isShowPass;
            if (isShowPass)
            {
                // show password
                textBox2.UseSystemPasswordChar = false;
                // get image from resource
                pictureBox1.Image = Image.FromFile("C:\\Users\\tuan\\source\\repos\\BTH1\\BTH1\\Resources\\hide.png");
            }
            else
            {
                // hide password
                textBox2.UseSystemPasswordChar = true;
                // get image from resource
                pictureBox1.Image = Image.FromFile("C:\\Users\\tuan\\source\\repos\\BTH1\\BTH1\\Resources\\eye.png");
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // switch to signup form and hide this form
            this.Hide();
            SignUp signup = new SignUp();
            signup.Show();

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.HomeForm.getPanel6 = false;
            this.HomeForm.getPanel8 = true;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            //resize picture
            pictureBox5.Image = Image.FromFile("C:\\Users\\tuan\\source\\repos\\BTH1\\BTH1\\Resources\\Login1.png");
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            // resize picture
            pictureBox5.Image = Image.FromFile("C:\\Users\\tuan\\source\\repos\\BTH1\\BTH1\\Resources\\Login.png");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
