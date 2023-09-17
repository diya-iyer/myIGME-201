using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    internal class Program
    {
        // Method: PlayMadLib
        // Purpose: Main method that allows for the user to choose if they want to play the game
        // Restrictions: None
        static void Main(string[] args)
        {
            int cntr = 0;
            int playCntr = 0;
            string userAns = null;
            string userName = null;
            while (true)
            {
                // Checking if it is the first time the user is playing the game
                if (playCntr == 0)
                {
                    Console.WriteLine("Do you want to play MadLibs? (Yes/No): ");
                    userAns = Console.ReadLine();
                    // prompt the user for their name 
                    Console.WriteLine("Please enter your name: ");
                    userName = Console.ReadLine();
                }
                // If the user is playing another time in the same run
                else
                {
                    Console.WriteLine("Do you want to play MadLibs again? (Yes/No): ");
                    userAns = Console.ReadLine();
                }
                // Starting the game and updating the count of times played
                if (userAns.ToLower() == "yes")
                {
                    PlayMadLib(userName);
                    playCntr++;
                }
                // Exiting the program
                else if (userAns.ToLower() == "no")
                {
                    Console.WriteLine("Goodbye!");
                    return;
                }
                // Prompting the user to give a valid input
                else
                {
                    // Checking how many times an invalid input has been given
                    // Future plan implementation: Put various statements in an array and randomly choose an index to display a random statement
                    if (cntr > 2)
                    {
                        Console.WriteLine("It's an easy choice, yes or no! Try again!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, try again."); 
                    }
                }
                // Updating input counter
                cntr++;
            }
           
        }
        // Method: PlayMadLib
        // Purpose: The method that hosts the actual MadLib game and gathers inputs based on prompts from the user
        // Restrictions: None
        static void PlayMadLib(string userName)
        {
            int cntr = 0;
            int numLibs = 0;
            int nChoice = 0;


            string finalStory = "";

            StreamReader input;

            // open the template file to count how many Mad Libs it contains
            input = new StreamReader("c:\\templates\\MadLibsTemplate.txt");
            //input = new StreamReader("c:/templates/MadLibsTemplate.txt");

            string line = null;
            while ((line = input.ReadLine()) != null)
            {
                ++numLibs;
            }

            // close it
            input.Close();

            // only allocate as many strings as there are Mad Libs
            string[] madLibs = new string[numLibs];

            // read the Mad Libs into the array of strings
            input = new StreamReader("c:\\templates\\MadLibsTemplate.txt");

            line = null;
            while ((line = input.ReadLine()) != null)
            {
                // set this array element to the current line of the template file
                madLibs[cntr] = line;

                // replace the "\\n" tag with the newline escape character
                madLibs[cntr] = madLibs[cntr].Replace("\\n", "\n");

                ++cntr;
            }

            input.Close();
           
           // Telling the user their story choice options
            Console.WriteLine("Hello " + userName + "! Here are the list of stories to choose from: ");
            Console.WriteLine("1. Dinner at a restaurant");
            Console.WriteLine("2. A recipe");
            Console.WriteLine("3. Inspection at the school cafeteria");
            Console.WriteLine("4. Pilot announcement");
            Console.WriteLine("5. Letter from camp");
            Console.WriteLine("6. Imagination prompt");
            while (true)
            {
                // prompt the user for which Mad Lib they want to play (nChoice)
                Console.WriteLine("Please enter the number of the story you wish to work on (1-6): ");
                string inputStory = Console.ReadLine();
                // Checking if the input is valid 
                if (int.TryParse(inputStory, out nChoice))
                {
                    // Checking if the number is in range
                    if (nChoice > 6 || nChoice < 1)
                    {
                        Console.WriteLine("Invalid input, please choose a story from the above list");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                // For other forms of invalid input
                else
                {
                    Console.WriteLine("Invalid input, please choose a story from the above list");
                    continue;
                }
            }
            // split the Mad Lib into separate words
            string[] words = madLibs[nChoice - 1].Split(' ');

            foreach (string word in words)
            {
                // if word is a placeholder
                if (word[0] == '{')
                {
                    string replaceWord = word.Replace("{", "").Replace("}", "").Replace("_", " ");
                    // prompt the user for the replacement
                    Console.Write("Input a {0}: ", replaceWord);
                    // and append the user response to the result string
                    finalStory += Console.ReadLine() + " ";

                }
                // else append word to the result string
                else
                {
                    finalStory += word + " ";
                }
            }
            // Printing the final story for the user
            Console.WriteLine("Here is your final story: ");
            Console.WriteLine(finalStory);
        }
    }
}
