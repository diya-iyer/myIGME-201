using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit1Exam_Q8
{
    internal class Program
    {
        // declaring the delegate function 
        delegate double RoundedValue(double value, int decimalPlace);
        static void Main(string[] args)
        {
            // Define the range and step size for x and y
            double minX = 0;
            double maxX = 4;
            double minY = -1;
            double maxY = 1;
            double step = 0.1;

            // Calculate the number of data points in each dimension
            int numXPoints = (int)((maxX - minX) / step) + 1;
            int numYPoints = (int)((maxY - minY) / step) + 1;

            // Create a 2D array to store the values of z
            double[,] zValues = new double[numYPoints, numXPoints];

            // declare the delegate method variable
            RoundedValue roundingResult = new RoundedValue(RoundingOperation);

            // Loop through the values of x and y
            for (int i = 0; i < numYPoints; i++)
            {
                double y = minY + i * step;
                y = roundingResult(y, 1);
                for (int j = 0; j < numXPoints; j++)
                {
                    double x = minX + j * step;
                    x = roundingResult(x, 1);


                    // Calculate the value of z using the formula
                    double z = 4 * Math.Pow(y, 3) + 2 * Math.Pow(x, 2) - 8 * x + 7;
                    z = roundingResult(z, 3);

                    // Store the value of z in the array
                    zValues[i, j] = z;
                }
            }
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
