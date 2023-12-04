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
    public partial class MaterialForm : Form
    {
        Thread explosionThread;
        public MaterialForm()
        {
            InitializeComponent();



            this.timer1.Tick += new EventHandler(Timer1__Tick);
            this.tornadoRadioButton.CheckedChanged += new EventHandler(TornadoRadioButton__CheckedChanged);
            this.explodeRadioButton.CheckedChanged += new EventHandler(ExplodeRadioButton__CheckedChanged);
            this.saveInventionButton.Click += new EventHandler(SaveInventionButton__Click);

            this.timer1.Start();


        }

        private void Timer1__Tick(object sender, EventArgs e)
        {
            --progressBar1.Value;

            if (progressBar1.Value == 15)
            {
                MessageBox.Show("Oh no! The head scientist is stealing your materials! Click the button to save them!");
                this.saveInventionButton.Visible = true;
                this.saveInventionButton.Enabled = false;

                if (!(this.specialItemGroupBox.Controls.OfType<RadioButton>().Any(rb => rb.Checked)))
                {
                    this.specialItemGroupBox.Enabled = false;

                }
            }
            else if (progressBar1.Value == 10)
            {
                this.saveInventionButton.Enabled = true;
            }
            else if (progressBar1.Value == 0)
            {
                this.timer1.Stop();
                this.specialItemGroupBox.Enabled = false;
                this.disasterGroupBox.Enabled = false;

            }
        }

        private void TornadoRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            this.materialsGroupBox.Location = new Point(random.Next(0, Width - this.materialsGroupBox.Width), random.Next(0, Height - this.materialsGroupBox.Height));
        }

        private void Explode()
        {
            this.BackColor = Color.FromArgb(255, 0, 0);
            Thread.Sleep(2000);
            this.materialsGroupBox.Visible = false;
            this.specialItemGroupBox.Visible = false;
            this.disasterGroupBox.Visible = false;
            this.saveInventionButton.Visible = false;
            this.explosionLabel.Visible = false;
            explosionThread.Abort();

        }

        private void ExplodeRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                this.explosionLabel.Visible = true;
                explosionThread = new Thread(new ThreadStart(Explode));
                explosionThread.Start();
                this.timer1.Stop();
            }
        }

        private void SaveInventionButton__Click(object sender, EventArgs e)
        {
            SaveInvention saveInvention = new SaveInvention();
            saveInvention.ShowDialog();
        }
    }
}


