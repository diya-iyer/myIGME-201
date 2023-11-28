using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.startButton.Click += new EventHandler(StartButton_Click);
            this.lowNumberTextBox.KeyPress += new KeyPressEventHandler(LowNumberTextBox_KeyPress);
            this.highNumberTextBox.KeyPress += new KeyPressEventHandler(HighNumberTextBox_KeyPress);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            bool bConv;
            int lowNumber = 0;
            int highNumber = 0;

            // convert the strings entered in lowTextBox and highTextBox
            // to lowNumber and highNumber Int32.Parse

            bConv = Int32.TryParse(this.lowNumberTextBox.Text, out lowNumber);
            bConv &= Int32.TryParse(this.highNumberTextBox.Text, out highNumber);

            // if not a valid range
            if (!bConv || lowNumber >= highNumber)
            {
                // show a dialog that the numbers are not valid
                MessageBox.Show("The numbers are invalid.");
            }
            else
            {
                // otherwise we're good
                // create a form object of the second form 
                // passing in the number range
                GameFormcs gameForm = new GameFormcs(lowNumber, highNumber);

                // display the form as a modal dialog, 
                // which makes the first form inactive
                gameForm.ShowDialog();
            }
        }

        private void LowNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits 
            e.Handled = !Char.IsDigit(e.KeyChar); 
        }

        private void HighNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control keys
            e.Handled = !Char.IsDigit(e.KeyChar); 
        }

    }
}
