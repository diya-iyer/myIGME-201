using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace U3_Q3
{
    public partial class SaveInvention : Form
    {
        Thread thread;
        public SaveInvention()
        {
            InitializeComponent();

            this.q1TextBox.TextChanged += new EventHandler(TextBox__TextChanged);
            this.q2MaskedTextBox.TextChanged += new EventHandler(MaskedTextBox__TextChanged);
            this.q3TextBox.TextChanged += new EventHandler(TextBox__TextChanged);
            this.saveMeButton.Click += new EventHandler(SaveMeButton__Click);
            this.congratsButton.Click += new EventHandler(CongratsButton__Click);
        }

        private void TextBox__TextChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            TextBox[] textBoxes = this.Controls.OfType<TextBox>().ToArray();
            foreach (TextBox textBox in textBoxes)
            {
                int newX = random.Next(0, this.Width - textBox.Width);
                int newY = random.Next(0, this.Height - textBox.Height);

                textBox.Location = new Point(newX, newY);
            }
        }

        private void MaskedTextBox__TextChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            int newWidth = random.Next(10, 300);
            q2MaskedTextBox.Width = newWidth;
        }

        private void WrongAnswer()
        {
            this.titleLabel.Text = "WRONG";
            this.titleLabel.ForeColor = Color.Red;
            
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(500);
                if (this.titleLabel.Visible)
                {
                    this.titleLabel.Visible = false;
                }
                else
                {
                    this.titleLabel.Visible = true;
                }
            }

            this.q1TextBox.Text = "";
            this.q2MaskedTextBox.Text = "";
            this.q3TextBox.Text = "";
            this.q1TextBox.Location = new Point(273, 115);
            this.q3TextBox.Location = new Point(386, 189);
            thread.Abort();
            
        }

        private void SaveMeButton__Click(object sender, EventArgs e)
        {
            if (q1TextBox.Text.Length > 0 && q2MaskedTextBox.Text.Length > 0 && q3TextBox.Text.Length > 0)
            {
                if (q1TextBox.Text == q1TextBox.Tag.ToString() && q2MaskedTextBox.Text == q2MaskedTextBox.Tag.ToString() && q3TextBox.Text == q3TextBox.Tag.ToString())
                {
                    this.congratsButton.Visible = true;
                }
                else
                {
                    thread = new Thread(new ThreadStart(WrongAnswer));
                    thread.Start();
                }
            }
            else
            {
                this.q1TextBox.Text = "";
                this.q2MaskedTextBox.Text = "";
                this.q3TextBox.Text = "";
            }
        }

        private void CongratsButton__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
