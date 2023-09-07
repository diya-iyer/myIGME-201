using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE3_IyerDiya
{
  
    static internal class Program
    // Method: Main
    // Purpose: Gather 4 numbers from the user and display the product
    // Restrictions: None
    {
        static void Main(string[] args)
        {
            // Collecting the 4 numbers from the user and storing them 
            Console.WriteLine("Type in the first number: ");
            string numberOne = Console.ReadLine();
            Console.WriteLine("Type in the second number: ");
            string numberTwo = Console.ReadLine();
            Console.WriteLine("Type in the third number: ");
            string numberThree = Console.ReadLine();
            Console.WriteLine("Type in the fourth number: ");
            string numberFour = Console.ReadLine();
            // Converting the inputted strings into integers to calculate product
            int product = Convert.ToInt32(numberOne) * Convert.ToInt32(numberTwo) * Convert.ToInt32(numberThree) * Convert.ToInt32(numberFour);
            // Printing product onto the console to view
            Console.WriteLine("The product of your four numbers is: " + product);
        }
    }
}
