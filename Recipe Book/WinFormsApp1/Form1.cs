namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        //defining credentials
        private const string validUsername = "Ianchis";
        private static string validPassword = "1234";
        public Form1()
        {
            InitializeComponent();
        }
        public static void UpdateValidPassword(string newPassword)
        {
            validPassword = newPassword;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Center;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox2.Text;
            string password = textBox3.Text;

            //checking the match
            if (username == validUsername && password == validPassword)
            {
                //if the credentials match we proceed
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide(); //hide this form
            }
            else
            {
                //error message
                label1.Text = "Invalid username or password. Please try again.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm fpf = new ForgotPasswordForm();
            fpf.Show();
            this.Hide(); //hide this form
        }
    }
}
