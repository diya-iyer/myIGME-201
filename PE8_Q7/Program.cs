using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_Q7
{
    // class: Program
    // Author: Diya Iyer
    // Purpose: The main class hosting the methods
    // Restrictions: None
    internal class Program
    {
        // Method: Main 
        // Purpose: Main method managing the user inputted string
        // Restrictions: None
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            // Call a method to reverse the string
            string reversed = ReverseString(input);

            Console.WriteLine("Reversed string: " + reversed);


        // Method: ReverseString
        // Purpose: Manages reversing the string the user inputs
        // Restrictions: None
        static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    
    }
}
