using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE9_Q3
{
    
    static internal class Program
    {
        // setting up the delegate function
        delegate string ReadLine();

        // Method : Main 
        // Author: Diya Iyer
        // Purpose: To use the delegate function to replace the Console.ReadLine() functionality
        // Restrictions: None
        static void Main(string[] args)
        {
            // Create an instance of the delegate and assign it to Console.ReadLine
            ReadLine readLineDelegate = Console.ReadLine;

            Console.WriteLine("Enter something:");

            // Use the delegate to read user input
            string userInput = readLineDelegate();

            // Print the user input
            Console.WriteLine($"You entered: {userInput}");
        }
    }
}
