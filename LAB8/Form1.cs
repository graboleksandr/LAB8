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

        private void button2_Click(object sender, EventArgs e)
        {
            string password = textBox2.Text;

            bool hasUpper = false;
            bool hasDigit = false;
            bool length = password.Length >= 8;

            foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpper = true; 
                if (char.IsDigit(c)) hasDigit = true;
            }

            if (length && hasUpper && hasDigit)
            {
                label3.Text = "Пароль надійний!";
                label3.ForeColor = Color.Green;
            }
            else
            {
                label3.Text = "Пароль не підходить!";
                label3.ForeColor = Color.Red;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
