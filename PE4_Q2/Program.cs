using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE4_Q2
{
    // Class: Program
    // Author: Diya Iyer
    // Restrictions: None
    static internal class Program
    {
        // Method: Main
        // Purpose: Get the user to input two numbers and check if it meets the requirements of being less than 10
        // Restrictions: None
        static void Main(string[] args)
        {
            while (true)
            {
                // Used a try / catch originally then went with the TryParse method instead, still kept this as a backup
                try
                {
                    int numberOne = 0;
                    int numberTwo = 0;
                    while (true)
                    {
                        // Prompting the user to enter a value
                        Console.WriteLine("Type in the first number: ");
                        string inputOne = Console.ReadLine();
                        // Checking if the input is a valid integer and rejecting it if not
                        if (!int.TryParse(inputOne, out numberOne))
                        {
                            Console.WriteLine("The given input must be an integer");
                        }
                        else
                        {
                            break;
                        }
                    }

                    while (true)
                    {
                        // Prompting the user to enter a value
                        Console.WriteLine("Type in the second number: ");
                        string inputTwo = Console.ReadLine();
                        // Checking if the input is a valid integer and rejecting it if not
                        if (!int.TryParse(inputTwo, out numberTwo))
                        {
                            Console.WriteLine("The given input must be an integer");
                        }
                        else
                        {
                            break;
                        }
                    }
                   // Displaying the inputted values
                    Console.WriteLine("The given numbers are: " + numberOne + " and " + numberTwo);
                    // Checking if both values are less than 10 and rejecting them if not
                    if (numberOne > 10 && numberTwo > 10)
                    {
                        Console.WriteLine("The input has been rejected. Both must be numbers that are less than 10");
                    }
                    else
                    {
                        break;
                    }
                }
                // If a system error comes up, display this message to the user so they can present a valid input
                catch (System.FormatException)
                {
                    Console.WriteLine("The input has been rejected. Both must be numbers that are less than 10");
                }

               
            }
        }
    }
}
