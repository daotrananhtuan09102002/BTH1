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
    }
}