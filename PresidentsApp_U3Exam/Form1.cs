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
using static System.Windows.Forms.ToolTip;


namespace PresidentsApp_U3Exam
{
    public partial class Form1 : Form
    {
       

        // Create variables to hold the URLS for the wikipedia page and the picture
        public string wikiURLPrefix = "https://en.m.wikipedia.org/wiki/";
        public string pictureURLPrefix = "http://people.rit.edu/dxsigm/";
        public Form1()
        {
            InitializeComponent();

            // Add necessary code to use Internet Explorer v12 with the WebBroswer control
            try

            {

                // Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.2; WOW64; Trident / 7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729; wbx 1.0.0)

                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(

                @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",

                true);

                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 12001, Microsoft.Win32.RegistryValueKind.DWord);

                key.Close();

            }

            catch

            {


            }

            // Set the exit button to be disabled
            this.exitButton.Enabled = false;


            // Include checked event handlers for checking the radio buttons associating with the president's names 
            RadioButton[] radioButtons = this.Controls.OfType<RadioButton>().ToArray();
            foreach (RadioButton radioButton in radioButtons)
            {
                radioButton.CheckedChanged += new EventHandler(PresidentRadioButton__Checked);
            }

            // Include checked event handlers for checking the radio buttons associating with the filters 
            RadioButton[] filterRadioButtons = this.filterGroupBox.Controls.OfType<RadioButton>().ToArray();
            foreach (RadioButton radioButton in filterRadioButtons)
            {
                radioButton.CheckedChanged += new EventHandler(FilterRadioButton__Checked);
            }
            
            // Check the Benjamin Harrison Radio Button to keep it as default when the user opens the form
            PresidentRadioButton__Checked(this.benjaminHarrisonRadioButton, null);

            // Include mouse hover event handler for the picture box
            this.pictureBox1.MouseHover += new EventHandler(PictureBox1__MouseHover);

            // Include a mouse leave event handler for the picture box to return normal size
            this.pictureBox1.MouseLeave += new EventHandler(PictureBox1__MouseLeave);

            
            // Include cancel event handler for validating user input in the textboxes
            MaskedTextBox[] textBoxes = this.Controls.OfType<MaskedTextBox>().ToArray();
            foreach (MaskedTextBox textBox in textBoxes)
            {
                textBox.Validating += new CancelEventHandler(PresidentTextBox__Validating);
                textBox.TextChanged += new EventHandler(PresidentTextBox__TextChanged);
                textBox.MouseHover += new EventHandler(PresidentTextBox__MouseHover);
            }

            // Include tick event handler for the timer to decrement the progress bar
            this.timer1.Tick += new EventHandler(Timer1__Tick);

            // Include click event handler for the exit button
            this.exitButton.Click += new EventHandler(ExitButton__Click);

            // Include a FormClosing handler in order to make sure the form can still close even if the answer isn't correct
            this.FormClosing += new FormClosingEventHandler(FormClose);
        }

        private void FormClose (object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void PresidentRadioButton__Checked(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                string tagName = ((RadioButton)sender).Tag.ToString();
                string[] url = tagName.Split('~');

                if (url.Length > 0)
                {
                    webBrowser1.Url = new Uri(this.wikiURLPrefix + url[0]);
                    pictureBox1.ImageLocation = this.pictureURLPrefix + url[1];
                    browserGroupBox.Text = this.wikiURLPrefix + url[0];
                }
            }
           
        }

        private void FilterRadioButton__Checked (object sender, EventArgs e)
        {
            string buttonName = ((RadioButton)sender).Name;
            if (((RadioButton)sender).Checked) 
            {
                RadioButton[] radioButtons = this.Controls.OfType<RadioButton>().ToArray();
                foreach (RadioButton radioButton in radioButtons)
                {
                  
                        if (buttonName == "filterDemocratRadioButton")
                        {
                            if (radioButton.Tag.ToString().Split('~')[2] == "D")
                            {
                                radioButton.Visible = true;
                            }
                            else
                            {
                                radioButton.Visible = false;
                            }
                        }
                        else if (buttonName == "filterRepublicanRadioButton")
                        {
                            if (radioButton.Tag.ToString().Split('~')[2] == "R")
                            {
                                radioButton.Visible = true;
                            }
                            else
                            {
                                radioButton.Visible = false;
                            }
                        }
                        else if (buttonName == "filterDemocraticRepublicanRadioButton")
                        {
                            if (radioButton.Tag.ToString().Split('~')[2] == "DR")
                            {
                                radioButton.Visible = true;
                            }
                            else
                            {
                                radioButton.Visible = false;
                            }
                        }
                        else if (buttonName == "filterFederalistRadioButton")
                        {
                            if (radioButton.Tag.ToString().Split('~')[2] == "F")
                            {
                                radioButton.Visible = true;
                            }
                            else
                            {
                                radioButton.Visible = false;
                            }
                        }
                        else
                        {
                            radioButton.Visible = true;
                        }
                  
                }
                
            }
        }

        private void PresidentTextBox__Validating(object sender, CancelEventArgs e)
        {
           MaskedTextBox textBox = (MaskedTextBox)sender;
            if (textBox.Tag.ToString() != textBox.Text.ToString())
            {
                errorProvider1.SetError(textBox, "That is the wrong number");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox, "");
            }
        }

        private void PresidentTextBox__TextChanged(object sender, EventArgs e)
        {
            bool allInputValid = false;
            this.timer1.Start();
            MaskedTextBox[] textBoxes = this.Controls.OfType<MaskedTextBox>().ToArray();
            foreach (MaskedTextBox textBox in textBoxes)
            {
                if (textBox.Tag.ToString() != textBox.Text.ToString())
                {
                    allInputValid = false;
                    break;
                }
                else
                {
                    allInputValid = true;
                }
            }
            if (allInputValid)
            {
                this.exitButton.Enabled = true;
                this.timer1.Stop();
            }
        }

        private void PresidentTextBox__MouseHover(object sender, EventArgs e)
        {
            MaskedTextBox textBox = (MaskedTextBox)sender;
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.IsBalloon = true;
            toolTip.Show("Which # President?", textBox);

        }

        private void PictureBox1__MouseHover(object sender, EventArgs e)
        {
            // The width and height of the picture box needs to double
                this.pictureBox1.Width *= 2;
                this.pictureBox1.Height *= 2;
                this.filterGroupBox.SendToBack();
            
        }

        private void PictureBox1__MouseLeave(object sender, EventArgs e)
        {
            // Return the size of the picture box to it's original state by dividing by 2
            this.pictureBox1.Width /= 2;
            this.pictureBox1.Height /= 2;
        }

        private void Timer1__Tick(object sender, EventArgs e)
        {
            --this.progressBar1.Value;

            if (this.progressBar1.Value == 0)
            {
                this.timer1.Stop();
                MaskedTextBox[] textBoxes = this.Controls.OfType<MaskedTextBox>().ToArray();
                foreach (MaskedTextBox textBox in textBoxes)
                {
                    textBox.Text = "0";
                }
                this.progressBar1.Value = 120;
            }
        }

        private void ExitButton__Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }

  
       
    }
}
