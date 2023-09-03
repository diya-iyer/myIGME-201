using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SquashTheBugs
{
    // Class Program
    // Author: David Schuh
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter
            //int i = 0
            // The above statement was a syntax error, not having a semicolon at the end
            int i = 0;

            // moving the string declaration to above the for loop in order to access it outside the loop during printing to the console
            string allNumbers = null;
            // loop through the numbers 1 through 10
            //for (i = 1; i < 10; ++i)
            // The statement above caused a runtime error of dividing by zero. By starting at the second index, the second statement needs to be modified to i <= 10
            for (i = 1; i <= 10; i++)
            {
                // declare string to hold all numbers
                // string allNumbers = null;
                // The above statement causes a syntax error below, as being declared inside the for loop makes it inaccessible outside of the loop

                // output explanation of calculation
                //Console.Write(i + "/" + i - 1 + " = ")
                // adding parantheses to the operation above , in order to avoid str and int operation syntax error

                // adding a if else block to combat the intial runtime error of dividing by 0
                if ((i - 1) == 0)
                {
                    Console.WriteLine(i + " / 0 = undefined");
                }
                else
                {
                    Console.Write(i + "/" + (i - 1) + " = ");
                    // output the calculation based on the numbers
                    Console.WriteLine(i / (i - 1));
                }

                // concatenate each number to allNumbers
                allNumbers += i + " ";

                // increment the counter
                // i = i + 1;
                // The for loop is already incrementing the counter, therefore this is a logic error causing a double increment
            }

            // output all numbers which have been processed
            // Console.WriteLine("These numbers have been processed: " allNumbers);
            Console.WriteLine("These numbers have been processed: " + allNumbers);
        }
    }
}

