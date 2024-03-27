using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        private List<Recipe> recipes = new List<Recipe>();
        private int selectedRecipeIndex = -1;

        //random number generator
        private Random random = new Random();

        public MainForm()
        {
            InitializeComponent();
            LoadRecipes();
            SetRandomWelcomeMessage(); //set random welcome
            LoadRandomImages(); //load random imgs
        }

        private void LoadRecipes()
        {
            try
            {
                string json = File.ReadAllText("recipes.json");
                recipes = JsonSerializer.Deserialize<List<Recipe>>(json);

                //populate listBox
                listBox1.DataSource = recipes;
                listBox1.DisplayMember = "Name";
            }
            catch (FileNotFoundException)
            {
                //exception check
            }
        }

        private void SaveRecipes()
        {
            string json = JsonSerializer.Serialize(recipes);
            File.WriteAllText("recipes.json", json);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateRecipeForm createRecipeForm = new CreateRecipeForm();
            DialogResult result = createRecipeForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Recipe newRecipe = new Recipe
                {
                    Name = createRecipeForm.RecipeName,
                    Description = createRecipeForm.RecipeDescription,
                    //photos must be .jpg
                    PhotoFileName = createRecipeForm.RecipeName + ".jpg"
                };

                //add to list
                recipes.Add(newRecipe);
                //update listbox
                listBox1.DataSource = null; //clear DataSource first
                listBox1.DataSource = recipes;
                listBox1.DisplayMember = "Name";

                SaveRecipes(); //save to file
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (selectedRecipeIndex >= 0 && selectedRecipeIndex < recipes.Count)
            {
                //remove from list
                recipes.RemoveAt(selectedRecipeIndex);
                //update listbox
                listBox1.DataSource = null; //clear DataSource first
                listBox1.DataSource = recipes;
                listBox1.DisplayMember = "Name";

                SaveRecipes(); //save to file
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedRecipeIndex = listBox1.SelectedIndex;

            if (selectedRecipeIndex >= 0 && selectedRecipeIndex < listBox1.Items.Count)
            {
                Recipe selectedRecipe = recipes[selectedRecipeIndex];
                label1.Text = selectedRecipe.Description;
                string photoPath = Path.Combine(Application.StartupPath, "Photos", selectedRecipe.PhotoFileName);

                if (File.Exists(photoPath))
                {
                    pictureBox2.Image = Image.FromFile(photoPath);
                }
                else
                {
                    pictureBox2.Image = null;
                }
            }
            else
            {
                pictureBox2.Image = null;
                label1.Text = string.Empty;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //close and start over
            this.Close();
            Form1 f1_3 = new Form1();
            f1_3.Show();
        }

        //Shuffle button
        private void button1_Click(object sender, EventArgs e)
        {
            //check if enough recipes
            if (recipes.Count <= 3)
            {
                MessageBox.Show("There are not enough recipes available to surprise you.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //generate 3 indices
            HashSet<int> randomIndices = new HashSet<int>();
            while (randomIndices.Count < 3)
            {
                randomIndices.Add(random.Next(0, recipes.Count));
            }

            //get recipes based on indices
            List<Recipe> randomRecipes = new List<Recipe>();
            foreach (int index in randomIndices)
            {
                randomRecipes.Add(recipes[index]);
            }

            //display the selected
            DisplayRandomRecipes(randomRecipes);
        }

        //Display method
        private void DisplayRandomRecipes(List<Recipe> recipes)
        {
            //clear previous
            panel1.Controls.Clear();

            //display each
            int y = 10;
            foreach (var recipe in recipes)
            {
                Label nameLabel = new Label();
                nameLabel.Text = recipe.Name;
                nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                nameLabel.AutoSize = true;
                nameLabel.Location = new System.Drawing.Point(10, y);
                panel1.Controls.Add(nameLabel);

                Label descriptionLabel = new Label();
                descriptionLabel.Text = recipe.Description;
                descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                descriptionLabel.AutoSize = true;
                descriptionLabel.Location = new System.Drawing.Point(10, y + 25);
                panel1.Controls.Add(descriptionLabel);

                y += 60; //adjust spacing
            }
        }

        //load and assign imgs to picture boxes
        private void LoadRandomImages()
        {
            //get all files
            string[] imageFiles = Directory.GetFiles(Path.Combine(Application.StartupPath, "Photos"), "*.jpg");

            //chekc for >2 imgs
            if (imageFiles.Length < 2)
            {
                MessageBox.Show("There are not enough images available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //shuffle the array
            imageFiles = imageFiles.OrderBy(f => random.Next()).ToArray();

            //load and assign to picture boxes
            if (imageFiles.Length > 0)
            {
                Image image1 = Image.FromFile(imageFiles[0]);
                pictureBox3.Image = image1;
            }

            if (imageFiles.Length > 1)
            {
                Image image2 = Image.FromFile(imageFiles[1]);
                pictureBox4.Image = image2;
            }
        }

        //random welcome msg
        private void SetRandomWelcomeMessage()
        {
            //prepared
            string[] welcomingMessages = {
                "Welcome to My Recipe App!",
                "Discover Delicious Recipes!",
                "Cooking Made Easy!",
                "Explore New Culinary Adventures!"
            };

            //pick random
            string message = welcomingMessages[random.Next(welcomingMessages.Length)];

            //update label
            label2.Text = message;
        }

        //close the app
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //recipe class definition
        public class Recipe
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string PhotoFileName { get; set; }

            public override string ToString()
            {
                return Name;
            }
        }
    }
}

