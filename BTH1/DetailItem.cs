using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH1
{
    public partial class DetailItem : Form
    {
        public DetailItem()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_hover(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox6.Image;
            pictureBox6.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BorderStyle = BorderStyle.None;
        }

        private void pictureBox2_hover(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox2.Image;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BorderStyle = BorderStyle.None;
        }

        private void pictureBox3_hover(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox3.Image;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BorderStyle = BorderStyle.None;
        }
        private void pictureBox4_hover(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox4.Image;
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BorderStyle = BorderStyle.None;
        }
        private void pictureBox5_hover(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox5.Image;
            pictureBox5.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BorderStyle = BorderStyle.None;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                this.detailItemandFeedback1.Visible = true;
                this.feedback1.Visible = false;
            }
            else
            {
                this.detailItemandFeedback1.Visible = false;
                this.feedback1.Visible = true;
            }

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }
    }
}
