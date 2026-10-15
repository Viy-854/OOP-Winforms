namespace WinFormsApp1
{
    public partial class firstSample : Form
    {
        public firstSample()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "This is my first Label";
            lblWelcome.BorderStyle = BorderStyle.FixedSingle;
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            lblWelcome.Text = "welcome " + txtName.Text;

        }
    }
}
