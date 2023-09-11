using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE4_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    int numberOne = 0;
                    int numberTwo = 0;
                    while (true)
                    {
                        Console.WriteLine("Type in the first number: ");
                        string inputOne = Console.ReadLine();
                        
                        if (!int.TryParse(inputOne, out numberOne))
                        {
                            Console.WriteLine("The given input must be an integer");
                        }
                        else
                        {
                            break;
                        }
                    }

                    while (true)
                    {
                        Console.WriteLine("Type in the second number: ");
                        string inputTwo = Console.ReadLine();
                        if (!int.TryParse(inputTwo, out numberTwo))
                        {
                            Console.WriteLine("The given input must be an integer");
                        }
                        else
                        {
                            break;
                        }
                    }
                   
                    Console.WriteLine("The given numbers are: " + numberOne + " and " + numberTwo);
                    if (numberOne > 10 && numberTwo > 10)
                    {
                        Console.WriteLine("The input has been rejected. Both must be numbers that are less than 10");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("The input has been rejected. Both must be numbers that are less than 10");
                }

               
            }
        }
    }
}
