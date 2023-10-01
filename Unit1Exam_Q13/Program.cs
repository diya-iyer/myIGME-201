using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit1Exam_Q12
{
    // creating a struct to hold the properties of the user's name and salary
    struct Employee
    {
        public string sName;
        public double dSalary;
    }

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
            // declaring a new Employee object
            Employee e = new Employee();

            // initializing the salary
            e.dSalary = 30000;

            // asking user for their name
            Console.WriteLine("What is your name?: ");
            e.sName = Console.ReadLine();

            // displaying the user's current salary
            if (GiveRaise(ref e))
            {
                Console.WriteLine("Congratulations, {0}! You got a raise, here is your new salary: $" + Math.Round(e.dSalary, 2), e.sName);
            }
            else
            {
                Console.WriteLine("Hi {0}! Here is your current salary: $" + Math.Round(e.dSalary, 2), e.sName);
            }

        }

        // Method: GiveRaise()
        // Author: Diya Iyer
        // Purpose: Calculating the user's new salary if they get a raise
        // Restrictions: None

        // changing the paramaters to only accept the struct object
        static bool GiveRaise(ref Employee e)
        {
            // If the names match, add the raise to the salary
            if (e.sName.ToLower().CompareTo(myName.ToLower()) == 0)
            {
                e.dSalary += 19999.99;
                return true;
            }
            return false;
        }
    }
}

