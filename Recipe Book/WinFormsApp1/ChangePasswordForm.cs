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
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string newPassword = textBox1.Text;
            string confirmedPassword = textBox2.Text;

            //check password
            if (IsValidPassword(newPassword))
            {
                //check match
                if (newPassword == confirmedPassword)
                {
                    Form1.UpdateValidPassword(newPassword);//password update
                    MessageBox.Show("Your password has been successfully changed.", "Password Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); //close and start over
                    Form1 f1_2 = new Form1();
                    f1_2.Show();
                }
                else
                {
                    //error if match fail
                    label2.Text = "Passwords do not match. Please try again.";
                    textBox1.Focus(); //focus on password field
                    textBox1.SelectAll(); //select all for easier handling of user
                }
            }
            else
            {
                //error id invalid
                label2.Text = "Invalid new password. Password must be at least 8 characters long and contain at least one letter and one number.";
                textBox1.Focus();
                textBox1.SelectAll();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); //close form, start over
            Form1 f1_2 = new Form1();
            f1_2.Show();
        }

        private bool IsValidPassword(string password)
        {
            //8 char, 1 digit password
            return password.Length >= 8 && ContainsLetter(password) && ContainsNumber(password);
        }
        //conditions check
        private bool ContainsLetter(string input)
        {
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    return true;
                }
            }
            return false;
        }

        private bool ContainsNumber(string input)
        {
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
