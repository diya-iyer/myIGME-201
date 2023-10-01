using System;

namespace UT1_BugSquash
{
    class Program
    {
        // Calculate x^y for y > 0 using a recursive function
        static void Main(string[] args)
        {
            string sNumber;
            int nX;
            // adding a semicolon at the end of declaring the variable - syntax error
            int nY;
            int nAnswer;

            // putting the string in quotations - syntax error
            Console.WriteLine("This program calculates x ^ y.");

            do
            {
                Console.Write("Enter a whole number for x: ");
                // set sNumber to assign the user's input to the variable - logic error
                sNumber = Console.ReadLine();
            } while (!int.TryParse(sNumber, out nX));

            do
            {
                Console.Write("Enter a positive whole number for y: ");
                sNumber = Console.ReadLine();
                // the out variable must be nY - logic error
                // should loop until a valid number is entered, negation is missing - logic error
            } while (!int.TryParse(sNumber, out nY));

            // compute the exponent of the number using a recursive function
            nAnswer = Power(nX, nY);

            // Make the variables as arguments to display their values - logic error
            Console.WriteLine("{0}^{1} = {2}", nX, nY, nAnswer);
        }


        // static keyword is missing for use in a static class - syntax error
        static int Power(int nBase, int nExponent)
        {
            int returnVal = 0;
            int nextVal = 0;

            // the base case for exponents is 0 (x^0 = 1)
            if (nExponent == 0)
            {
                // return the base case and do not recurse
                // a value to the 0th power should return 1 - logic error
                returnVal = 1;
            }
            else
            {
                // compute the subsequent values using nExponent-1 to eventually reach the base case
                // Computation using +1 instead of -1, causing StackOverflowException due to infinite runs - logic / runtime error
                nextVal = Power(nBase, nExponent - 1);

                // multiply the base with all subsequent values
                returnVal = nBase * nextVal;
            }

            // missing the return keyword - syntax error
            return returnVal;
        }
    }
}

