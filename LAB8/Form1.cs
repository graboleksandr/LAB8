namespace LAB8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Привіт, " + textBox1.Text + "!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.AntiqueWhite;
        }
    }
}
