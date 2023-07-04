namespace Hospital1
{
    public partial class Form1 : Form
    {
        private Form form2;

        private Form form3;

        private Form form4;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.form4 = new Form4();
            form4.Show();
            this.Hide();
        }
    }
}