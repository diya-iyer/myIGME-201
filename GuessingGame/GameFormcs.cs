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

namespace GuessingGame
{
    public partial class GameFormcs : Form
    {
        public int lowNumber;
        public int highNumber;
        public int targetNumber;
        public int nGuesses;
        public GameFormcs(int min, int max)
        {
            InitializeComponent();

            lowNumber = min; 
            highNumber = max;
        
            // Initialize the random number
            Random rand = new Random();
            targetNumber = rand.Next(lowNumber, highNumber + 1);

            // Initialize other components
            nGuesses = 0;
            this.timer1.Tick += new EventHandler(Timer_Tick);

            // Set the AcceptButton for the form
            this.AcceptButton = guessButton;

            // Button Click Event Handler
            this.guessButton.Click += new EventHandler(GuessButton_Click);

            // Start the timer1
            this.timer1.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            --this.progressBar1.Value;
            if (this.progressBar1.Value == 0)
            {
                // Game over
                this.timer1.Stop();
                MessageBox.Show("Sorry, you ran out of time. The correct number was " + targetNumber);
                this.Close();
            }
        }

        private void GuessButton_Click(object sender, EventArgs e)
        {
            // Process user's guess
            int guess;
            if (Int32.TryParse(guessTextBox.Text, out guess))
            {
                nGuesses++;

                if (guess == targetNumber)
                {
                    // Correct guess
                    this.timer1.Stop();
                    MessageBox.Show($"Woohoo, you got it in {nGuesses} guesses!");
                    this.Close();
                }
                else if (guess < targetNumber)
                {
                    // Incorrect guess
                    outputLabel.Text = "Your guess was too low!";
                }
                else if (guess > targetNumber)
                {
                    outputLabel.Text = "Your guess was too high!";
                }
            }
            else
            {
                // Invalid guess
                MessageBox.Show("Invalid guess. Please enter a valid number.");
            }
        }
    }
}
