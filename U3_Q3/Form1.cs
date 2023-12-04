using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U3_Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.scientistNameTextBox.TextChanged += new EventHandler(ScientistNameTextBox__TextChanged);
            this.inventionNameTextBox.TextChanged += new EventHandler(InventionNameTextBox__TextChanged);
            this.submitNamebutton.Click += new EventHandler(SubmitNameButton__Click);
            this.toLabButton.Click += new EventHandler(ToLabButton__Click);
        }

        private void ScientistNameTextBox__TextChanged (object sender, EventArgs e)
        {
            Random random = new Random();
            Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            this.scientistNameTextBox.BackColor = randomColor;
        }

        private void InventionNameTextBox__TextChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            float randomFontSize = random.Next(8, 24);

            Font currentFont = this.inventionNameTextBox.Font;
            this.inventionNameTextBox.Font = new Font(currentFont.FontFamily, randomFontSize, currentFont.Style);
        }

        private void SubmitNameButton__Click (object sender, EventArgs e)
        {
            if (this.scientistNameTextBox.Text == "" || this.inventionNameTextBox.Text == "")
            {
                MessageBox.Show("Message from Head Scientist: Hey! You need to give us SOME name! Go do that before coming to the lab!");
                return;
            }
            else
            {
                Random random = new Random();
                submitNamebutton.Location = new Point(random.Next(0, Width - submitNamebutton.Width), random.Next(0, Height - submitNamebutton.Height));

                string[] letters = { "a", "e", "i", "o", "u" };
                string[] replacements = { "4", "3", "1", "0", "2" };

                for (int i = 0; i < letters.Length; i++)
                {
                    this.scientistNameTextBox.Text = this.scientistNameTextBox.Text.Replace(letters[i], replacements[i]);
                    this.inventionNameTextBox.Text = this.inventionNameTextBox.Text.Replace(letters[i], replacements[i]);
                }

                this.nameChangeLabel.Visible = true;

                this.scientistNameChangedLabel.Text = "Scientist Name: " + this.scientistNameTextBox.Text;
                this.scientistNameChangedLabel.Visible = true;

                this.inventionNameChangedLabel.Text = "Invention Name: " + this.inventionNameTextBox.Text;
                this.inventionNameChangedLabel.Visible = true;

                this.toLabButton.Visible = true;
            }
           
        }

        private void ToLabButton__Click(object sender, EventArgs e)
        {
            MaterialForm materialForm = new MaterialForm();
            materialForm.ShowDialog();
        }
    }
}
