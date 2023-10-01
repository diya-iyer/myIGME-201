using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit1Exam_Q12
{
    // Class: Program
    // Author: Diya Iyer
    // Purpose: Calculating a salary based on the user's name
    // Restrictions: None
    static class Program
    {
        static string myName = "Diya";

        // Method: Main()
        // Author: Diya Iyer
        // Purpose: Displaying the user's current salary
        // Restrictions: None
        static void Main(string[] args)
        {
            string sName;
            double dSalary = 30000;

            // asking user for their name
            Console.WriteLine("What is your name?: ");
            sName = Console.ReadLine();

            // displaying the user's current salary
            if (GiveRaise(sName, ref dSalary))
            {
                Console.WriteLine("Congratulations, {0}! You got a raise, here is your new salary: $" + Math.Round(dSalary, 2), sName);
            }
            else
            {
                Console.WriteLine("Hi {0}! Here is your current salary: $" + Math.Round(dSalary, 2), sName);
            }

        }

        // Method: GiveRaise()
        // Author: Diya Iyer
        // Purpose: Calculating the user's new salary if they get a raise
        // Restrictions: None
        static bool GiveRaise(string name, ref double salary)
        {
            // If the names match, add the raise to the salary
            if (name.ToLower().CompareTo(myName.ToLower()) == 0) 
            {
                salary += 19999.99;
                return true;
            }
            return false;
        }
    }
}
