using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE4_Q6
{
    /// <summary>
    /// This class generates Mandelbrot sets in the console window!
    /// </summary>

    class Class1
    {
        /// <summary>
        /// This is the Main() method for Class1 -
        /// this is where we call the Mandelbrot generator!
        /// </summary>
        /// <param name="args">
        /// The args parameter is used to read in
        /// arguments passed from the console window
        /// </param>

        [STAThread]
       
        static void Main(string[] args)
        {
            double realCoord, imagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;
           
            // Informing the user on the guidelines (default values of the coordinates) 
            Console.WriteLine("Guidelines: ");
            Console.WriteLine("The default value for the Image Coordinate: Start: 1.2, End: -1.2");
            Console.WriteLine("The default value for the Real Coordinate: Start: -0.6, End: 1.77");
            double imagCoordStart = 1.2;
            double imagCoordEnd = -1.2;
            double decrementVal = 0.05;
            double realCoordStart = -0.6;
            double realCoordEnd = 1.77;
            double incrementVal = 0.03;

            // Prompting the user to input the starting image coordinate
            while (true)
            {
                Console.WriteLine("Type in the starting value for the image coordinate or press Enter to keep default: ");
                string inputImageCoordStart = Console.ReadLine();
                // checking if the user inputs a value, if not continue with default value
                if (inputImageCoordStart.Length > 0)
                {
                    // validating that the input is a number
                    if (!double.TryParse(inputImageCoordStart, out imagCoordStart))
                    {
                        Console.WriteLine("The given input must be a number");
                    }
                    else
                    {
                        break;
                    }

                }
                else
                {
                    break;
                }
            }

            // Prompting the user to input the ending image coordinate
            while (true)
            {
                Console.WriteLine("Type in the ending value for the image coordinate or press Enter to keep default: ");
                string inputImageCoordEnd = Console.ReadLine();
                // checking if the user inputs a value, if not continue with default value
                if (inputImageCoordEnd.Length > 0)
                {
                    // validating that the input is a number
                    if (!double.TryParse(inputImageCoordEnd, out imagCoordEnd))
                    {
                        Console.WriteLine("The given input must be a number");
                    }
                    else
                    {
                        // validating that the image start coordinate is always greater than the image ending coordinate
                        if (imagCoordStart < imagCoordEnd)
                        {
                            Console.WriteLine("Image end coordinate must be less than the image start coordinate.");
                            continue;
                        }
                        break;
                    }
                }
               else
                {
                    break;
                }
            }

            // Prompting the user to input the starting real coordinate
            while (true)
            {
                Console.WriteLine("Type in the starting value for the real coordinate or press Enter to keep default: ");
                string inputRealCoordStart = Console.ReadLine();
                // checking if the user inputs a value, if not continue with default value
                if (inputRealCoordStart.Length > 0)
                {
                    // validating that the input is a number
                    if (!double.TryParse(inputRealCoordStart, out realCoordStart))
                    {
                        Console.WriteLine("The given input must be a number");
                    }
                    else
                    {
                        break;
                    }
                }
               else
                {
                    break;
                }
            }

            // Prompting the user to input the ending real coordinate
            while (true)
            {
                Console.WriteLine("Type in the ending value for the real coordinate or press Enter to keep default: ");
                string inputRealCoordEnd = Console.ReadLine();
                // checking if the user inputs a value, if not continue with default value
                if (inputRealCoordEnd.Length > 0)
                {
                    // validating that the input is a number
                    if (!double.TryParse(inputRealCoordEnd, out realCoordEnd))
                    {
                        Console.WriteLine("The given input must be a number");
                    }
                    else
                    {
                        // validating that the real start coordinate is always lesser than the real ending coordinate
                        if (realCoordStart > realCoordEnd)
                        {
                            Console.WriteLine("Real end coordinate must be greater than the real start coordinate.");
                            continue;
                        }
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
            // Calculating the new increment and decrement value based on inputs
            // Ensuring there are 48 values within the image coordinates
            decrementVal = (imagCoordStart - imagCoordEnd) / 48;
            // Ensuring there are 80 values within the real coordinates
            incrementVal = (realCoordEnd - realCoordStart) / 80;

            for (imagCoord = imagCoordStart; imagCoord >= imagCoordEnd; imagCoord -= decrementVal)
            {
                for (realCoord = realCoordStart; realCoord <= realCoordEnd; realCoord += incrementVal)
                {
                    iterations = 0;
                    realTemp = realCoord;
                    imagTemp = imagCoord;
                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                           - realCoord;
                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                }
                Console.Write("\n");
            }

        }
    }
}
