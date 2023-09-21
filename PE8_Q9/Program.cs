using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_Q9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            // Place double quotes around each word
            string quotedString = QuoteWords(input);

            Console.WriteLine("Quoted string: " + quotedString);

            // Wait for user input to close the console window
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static string QuoteWords(string input)
        {
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = $"\"{words[i]}\"";
            }
            return string.Join(" ", words);
        }
    }
}
