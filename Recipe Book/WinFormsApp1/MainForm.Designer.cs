namespace WinFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pictureBox4 = new PictureBox();
            button5 = new Button();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            tabPage3 = new TabPage();
            panel1 = new Panel();
            button1 = new Button();
            tabPage4 = new TabPage();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.Buttons;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1034, 820);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = Properties.Resources.poza1;
            tabPage1.Controls.Add(pictureBox4);
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(pictureBox3);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 27);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(1026, 789);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Home";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox4.Location = new Point(620, 489);
            pictureBox4.MinimumSize = new Size(300, 300);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(300, 300);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = Color.IndianRed;
            button5.Location = new Point(943, 758);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 2;
            button5.Text = "Exit";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox3.Location = new Point(51, 489);
            pictureBox3.MinimumSize = new Size(300, 300);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(300, 300);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.IndianRed;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(3, 2);
            label2.Name = "label2";
            label2.Size = new Size(88, 37);
            label2.TabIndex = 0;
            label2.Text = "Hello!";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            tabPage3.BackgroundImage = Properties.Resources.poza3;
            tabPage3.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage3.Controls.Add(panel1);
            tabPage3.Controls.Add(button1);
            tabPage3.Location = new Point(4, 27);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1026, 789);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Surprise Me";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.poza1;
            panel1.Location = new Point(8, 478);
            panel1.Name = "panel1";
            panel1.Size = new Size(1010, 232);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Dock = DockStyle.Bottom;
            button1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(0, 715);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(1026, 74);
            button1.TabIndex = 0;
            button1.Text = "Shuffle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tabPage4
            // 
            tabPage4.BackgroundImage = Properties.Resources.poza1;
            tabPage4.Controls.Add(label1);
            tabPage4.Controls.Add(pictureBox2);
            tabPage4.Controls.Add(button4);
            tabPage4.Controls.Add(button3);
            tabPage4.Controls.Add(button2);
            tabPage4.Controls.Add(listBox1);
            tabPage4.Controls.Add(textBox2);
            tabPage4.Controls.Add(textBox1);
            tabPage4.Controls.Add(pictureBox1);
            tabPage4.Location = new Point(4, 27);
            tabPage4.Margin = new Padding(3, 2, 3, 2);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1026, 789);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Account";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.IndianRed;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(371, 3);
            label1.MinimumSize = new Size(250, 400);
            label1.Name = "label1";
            label1.Size = new Size(250, 400);
            label1.TabIndex = 9;
            label1.Text = "Recipe";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom;
            pictureBox2.ErrorImage = Properties.Resources.poza1;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(347, 481);
            pictureBox2.MaximumSize = new Size(700, 700);
            pictureBox2.MinimumSize = new Size(300, 300);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(300, 300);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.IndianRed;
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(8, 297);
            button4.Name = "button4";
            button4.Size = new Size(93, 23);
            button4.TabIndex = 6;
            button4.Text = "Delete Recipe";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(8, 268);
            button3.Name = "button3";
            button3.Size = new Size(93, 23);
            button3.TabIndex = 5;
            button3.Text = "Add Recipe";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.IndianRed;
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(898, 737);
            button2.Name = "button2";
            button2.Size = new Size(120, 44);
            button2.TabIndex = 4;
            button2.Text = "Log Out";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.IndianRed;
            listBox1.ForeColor = SystemColors.Window;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(8, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(231, 259);
            listBox1.TabIndex = 3;
            listBox1.Tag = "";
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox2.BackColor = Color.IndianRed;
            textBox2.ForeColor = SystemColors.Window;
            textBox2.Location = new Point(918, 188);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.BackColor = Color.IndianRed;
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(918, 159);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(873, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 820);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Form2";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button button1;
        private PictureBox pictureBox1;
        private ListBox listBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox3;
        private Label label2;
        private Button button5;
        private PictureBox pictureBox4;
    }
}