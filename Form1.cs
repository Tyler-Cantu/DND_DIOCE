namespace DND_DIOCE
{
    public partial class lbl8 : Form
    {
        public lbl8()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd=new Random();
            int randomNumber = rnd.Next(1, 7);

            lbld6.Text=randomNumber.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random=new Random();
            int randomNumber   = random.Next(1, 9);

            lbld8.Text=randomNumber.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 11);

            lbld10.Text = randomNumber.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 13);

            lbld12.Text = randomNumber.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 21);

            lbld20.Text = randomNumber.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);

            lbld100.Text = randomNumber.ToString();
        }

        private void button7_Click(object sender, EventArgs e) 
        {
            Random random = new Random();
            int randomNumber = random.Next(1,5);

            lbld4.Text = randomNumber.ToString();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}