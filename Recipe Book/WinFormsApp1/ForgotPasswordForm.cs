using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ForgotPasswordForm : Form
    {
        private const string securityQuestion = "What is your mother's maiden name?";
        private const string correctAnswer = "Bria";
        public ForgotPasswordForm()
        {
            InitializeComponent();
            label3.Text = securityQuestion;
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            string userAnswer = textBox1.Text;

            //check answer match
            if (userAnswer.ToLower() == correctAnswer.ToLower())
            {
                //answer ok, reset password
                MessageBox.Show("You may change your password", "Password Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); //close this form
                ChangePasswordForm cpf = new ChangePasswordForm();
                cpf.Show();
            }
            else
            {
                //error message
                label4.Text = "Incorrect answer. Please try again.";
                textBox1.Focus(); //change focus
                textBox1.SelectAll(); //autoselect text
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); //close and start over
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
