using Baithuchanh1;

namespace BTH1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue; // change to the desired color
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black; // change back to the original color
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Blue; // change to the desired color
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black; // change back to the original color
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            label8.ForeColor = Color.Blue; // change to the desired color
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.ForeColor = Color.Black; // change back to the original color
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Blue; // change to the desired color
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Black; // change back to the original color
        }


        private void label2_Click(object sender, EventArgs e)
        {
            Login login = new Login(this);
            login.Show();
        }

        public bool getPanel6
        {
            get { return panel6.Visible; }
            set { panel6.Visible = value; }
        }

        public bool getPanel8
        {
            get { return panel8.Visible; }
            set { panel8.Visible = value; }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.panel6.Visible = true;
            this.panel8.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DetailItem item = new DetailItem();
            item.Show();
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            //resize picture
            pictureBox6.Size = new Size(243, 182); //resize 
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            // resize picture
            pictureBox6.Size = new Size(249, 188); //resize 
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            //resize picture
            pictureBox9.Size = new Size(243, 182); //resize 
        }

        private void pictureBox9_MouseEnter(object sender, EventArgs e)
        {
            // resize picture
            pictureBox9.Size = new Size(249, 188); //resize 
        }

        // change color when hover picture box 10
        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            //resize picture
            pictureBox10.Size = new Size(243, 182); //resize 
        }

        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            // resize picture
            pictureBox10.Size = new Size(249, 188); //resize 
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            //resize picture
            pictureBox11.Size = new Size(243, 182); //resize 
        }

        private void pictureBox11_MouseEnter(object sender, EventArgs e)
        {
            // resize picture
            pictureBox11.Size = new Size(249, 188); //resize 
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            //resize picture
            pictureBox7.Size = new Size(243, 182); //resize 
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            // resize picture
            pictureBox7.Size = new Size(249, 188); //resize 
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            //resize picture
            pictureBox8.Size = new Size(243, 182); //resize 
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            // resize picture
            pictureBox8.Size = new Size(249, 188); //resize 
        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            //resize picture
            pictureBox12.Size = new Size(243, 182); //resize 
        }

        private void pictureBox12_MouseEnter(object sender, EventArgs e)
        {
            // resize picture
            pictureBox12.Size = new Size(249, 188); //resize 
        }

        private void pictureBox13_MouseLeave(object sender, EventArgs e)
        {
            //resize picture
            pictureBox13.Size = new Size(243, 182); //resize 
        }

        private void pictureBox13_MouseEnter(object sender, EventArgs e)
        {
            // resize picture
            pictureBox13.Size = new Size(249, 188); //resize 
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            DetailItem detailItem = new DetailItem();
            detailItem.Show();
        }

        private void panel10_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
        }
    }
}