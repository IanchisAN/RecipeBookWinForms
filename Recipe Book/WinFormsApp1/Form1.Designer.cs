namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.IndianRed;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            textBox1.ForeColor = SystemColors.Menu;
            textBox1.Location = new Point(0, 0);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.MinimumSize = new Size(219, 63);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(700, 52);
            textBox1.TabIndex = 0;
            textBox1.Text = "Recipe Book";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.IndianRed;
            textBox2.ForeColor = SystemColors.Window;
            textBox2.Location = new Point(10, 52);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.MinimumSize = new Size(110, 27);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "Username";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.IndianRed;
            textBox3.ForeColor = SystemColors.Window;
            textBox3.Location = new Point(10, 90);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.MinimumSize = new Size(110, 27);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(110, 23);
            textBox3.TabIndex = 2;
            textBox3.Text = "Password";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = SystemColors.ButtonHighlight;
            checkBox1.Location = new Point(10, 128);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(104, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Remember Me";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.GreenYellow;
            button1.Location = new Point(10, 165);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.MinimumSize = new Size(82, 22);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.GreenYellow;
            button2.Location = new Point(98, 165);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.MinimumSize = new Size(130, 22);
            button2.Name = "button2";
            button2.Size = new Size(130, 22);
            button2.TabIndex = 6;
            button2.Text = "Forgot Password";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(10, 202);
            label1.MinimumSize = new Size(262, 56);
            label1.Name = "label1";
            label1.Size = new Size(262, 56);
            label1.TabIndex = 7;
            label1.Text = "Status";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            BackgroundImage = Properties.Resources.poza1;
            ClientSize = new Size(700, 338);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private CheckBox checkBox1;
        private Button button1;
        private Button button2;
        private Label label1;
    }
}
