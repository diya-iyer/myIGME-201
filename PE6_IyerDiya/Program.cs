using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE6_IyerDiya
{
    // Class: Program
    // Author: Diya Iyer
    // Purpose: Hosting the main method
    // Restrictions: None
    static internal class Program
    {
        // Method: Main
        // Purpose: Creating a game where the user tries to guess a randomly generated number between 1-100
        // Restrictions: None
        static void Main(string[] args)
        {
            Random rand = new Random();
            // generate a random number between 0 inclusive and 101 exclusive
            int randomNumber = rand.Next(0, 101);

            // for testing purposes
            // Console.WriteLine(randomNumber);

            // creating a counter to keep track of the user's attempts
            int counter = 1;
            int guessedNumber = 0;

            // A loop to limit the user to eight tries 
            while (counter < 9)
            {
               // Using tryParse to check if the input is a valid integer
                while (true)
                {
                    Console.WriteLine("Turn #" + (counter) + ": Enter your guess: ");
                    string guessedInput = Console.ReadLine();
                    if (!int.TryParse(guessedInput, out guessedNumber))
                    {
                        Console.WriteLine("Invalid guess - The given input must be an integer");
                    }
                    else
                    {
                        // Checking if the number is within range and prompting the user again if not
                        if (guessedNumber < 0 || guessedNumber > 100)
                        {
                            Console.WriteLine("Invalid guess – try again");
                            continue;
                        }
                        break;
                    }
                }
               // Based on the input the user gives, informing them if they are correct or too high or too low
                if (guessedNumber == randomNumber)
                {
                    Console.WriteLine("Correct! You won in " + (counter) + " turns");
                    break;
                }
                else if (guessedNumber > randomNumber)
                {
                    Console.WriteLine("Too high!");
                }
                else if (guessedNumber < randomNumber)
                {
                    Console.WriteLine("Too low!");
                }
                // Incrementing the counter to keep track of the user attempts
                counter++;
            }
            // Checking if the user got the value right by the final turn
            if (guessedNumber != randomNumber)
            {
                Console.WriteLine("You ran out of turns. The number was " + randomNumber);
            }
        }
    }
}
