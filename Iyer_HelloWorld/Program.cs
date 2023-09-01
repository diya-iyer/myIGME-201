using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iyer_HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Printing the statement "hello world" to the console
            // Console.WriteLine("Hello World!");
            // Printing a different statement to test functionality
            Console.WriteLine("My name is Diya Iyer");

            // creating a counter variable that tells us how many times the loop has run
            int counter = 0;
            // A while loop that lists out numbers 1-10
            while (counter++ < 10)
            {
                Console.WriteLine(counter);
            }
        }
    }
}
