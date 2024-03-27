using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class CreateRecipeForm : Form
    {
        public string RecipeName { get; private set; }
        public string RecipeDescription { get; private set; }
        public Image RecipePhoto { get; private set; }

        public CreateRecipeForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //browse and select photo
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp|All files (*.*)|*.*";
            openFileDialog.Title = "Select Recipe Photo";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //load and display
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //validate
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter a recipe name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //save detailes
            RecipeName = textBox1.Text;
            RecipeDescription = textBox2.Text;
            RecipePhoto = pictureBox1.Image;

            //close form
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //close with no changes
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
