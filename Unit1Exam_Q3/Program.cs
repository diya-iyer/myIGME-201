using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Unit1Exam_Q3
{
    internal class Program
    // Class: Program
    // Author: Diya Iyer
    // Purpose: Takes a number and decimal place and rounds the number accordingly
    // Restrictions: None
    {
        // declaring the delegate function 
        delegate double RoundedValue(double value, int decimalPlace);

        // Method: Main 
        // Author: Diya Iyer
        // Purpose: Rounds a number using various functionalities such as delegate, lambda operator, anonymous functions and the generic template
        // Restrictions: None
        static void Main(string[] args)
        {
            string sNumber = null;
            string rNumber = null;
            double dNum1 = 0;
            int iNum2 = 0;

            // prompt and convert the inputted numbers to the correct data types
            do
            {
                Console.Write("Enter a number to round: ");
                sNumber = Console.ReadLine();

                if (!double.TryParse(sNumber, out dNum1))
                {
                    Console.WriteLine("Please enter a valid number");
                    continue;
                }
                else
                {
                    break;
                }
            } while (true);

            do
            {
                Console.WriteLine("How many decimal places do you want to round to: ");
                rNumber = Console.ReadLine();

                if (!int.TryParse(rNumber, out iNum2))
                {
                    Console.WriteLine("Please enter a valid integer");
                    continue;
                }
                else
                {
                    break;
                }
            } while (true);

            RoundedValue roundingResult = new RoundedValue(RoundingOperation);

            // using the delegate method to round the inputted number to the specified decimal place
            Console.WriteLine("The rounded number using the delegate method is: " + roundingResult(dNum1, iNum2));

            // use an anonymous codeblock using the delegate keyword
            roundingResult = delegate (double n1, int n2)
            {
                return RoundingOperation(n1, n2);
            };
            Console.WriteLine("The rounded number using the anonymous method is: " + roundingResult(dNum1, iNum2));

            // using the lambda operator 
            roundingResult = (n1, n2) =>
            {
                return RoundingOperation(n1, n2);
            };
            Console.WriteLine("The rounded number using the lambda operator is: " + roundingResult(dNum1, iNum2));

            // using generic template 
            Func<double, int, double> roundingResult1 = new Func<double, int, double>(RoundingOperation);
            Console.WriteLine("The rounded number using the generic template is: " + roundingResult1(dNum1, iNum2));
        }

        // Method: RoundingOperations 
        // Author: Diya Iyer
        // Purpose: The method that rounds the inputted number to the desried decimal place
        // Restrictions: Returns a double
        static double RoundingOperation(double value, int decimalPlace)
        {
            return Math.Round(value, decimalPlace);
        } 
    }
}
