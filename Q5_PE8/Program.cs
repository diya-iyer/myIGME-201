using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_PE8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define the ranges and increments for x and y
            double minX = -1.0;
            double maxX = 1.0;
            double minY = 1.0;
            double maxY = 4.0;
            double increment = 0.1;

            // Calculate the number of steps for x and y
            int xSteps = (int)((maxX - minX) / increment) + 1;
            int ySteps = (int)((maxY - minY) / increment) + 1;

            // Create a 3-dimensional array to store the values of x, y, and z
            double[,,] results = new double[xSteps, ySteps, 3];

            // Calculate and store the values of x, y, and z
            double x = minX;
            for (int i = 0; i < xSteps; i++)
            {
                double y = minY;
                for (int j = 0; j < ySteps; j++)
                {
                    double z = 3 * y * y + 2 * x - 1;
                    results[i, j, 0] = x;
                    results[i, j, 1] = y;
                    results[i, j, 2] = z;
                    y += increment;
                }
                x += increment;
            }

            // Display the results
            for (int i = 0; i < xSteps; i++)
            {
                for (int j = 0; j < ySteps; j++)
                {
                    Console.WriteLine($"x = {results[i, j, 0]}, y = {results[i, j, 1]}, z = {results[i, j, 2]}");
                }
            }
        }
    }
}
