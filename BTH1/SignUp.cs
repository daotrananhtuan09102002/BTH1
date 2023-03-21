using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baithuchanh1
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private bool isShowPass1 = false;
        private bool isShowPass2 = false;

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // switch to login form and hide this form
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // switch isShowPass to opposite value
            isShowPass1 = !isShowPass1;
            if (isShowPass1)
            {
                // show password
                textBox2.UseSystemPasswordChar = false;
                // get image from resource
                pictureBox1.Image = Image.FromFile("C:\\Users\\tuan\\source\\repos\\Baithuchanh1\\Baithuchanh1\\resources\\hide.png");
            }
            else
            {
                // hide password
                textBox2.UseSystemPasswordChar = true;
                // get image from resource
                pictureBox1.Image = Image.FromFile("C:\\Users\\tuan\\source\\repos\\Baithuchanh1\\Baithuchanh1\\resources\\eye.png");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // switch isShowPass to opposite value
            isShowPass2 = !isShowPass2;
            if (isShowPass2)
            {
                // show password
                textBox3.UseSystemPasswordChar = false;
                // get image from resource
                pictureBox2.Image = Image.FromFile("C:\\Users\\tuan\\source\\repos\\BTH1\\BTH1\\Resources\\hide.png");
            }
            else
            {
                // hide password
                textBox3.UseSystemPasswordChar = true;
                // get image from resource
                pictureBox2.Image = Image.FromFile("C:\\Users\\tuan\\source\\repos\\BTH1\\BTH1\\Resources\\eye.png");
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
