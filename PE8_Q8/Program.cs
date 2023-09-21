using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_Q8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            // Perform case-insensitive replacement
            string replacedString = ReplaceNoWithYes(input);

            Console.WriteLine("Replaced string: " + replacedString);
        }

        static string ReplaceNoWithYes(string input)
        {
            // Split the input string into words
            string[] words = input.Split(' ');

            // Iterate through the words and replace "no" with "yes" (case-insensitive)
            for (int i = 0; i < words.Length; i++)
            {
                if (string.Equals(words[i], "no", StringComparison.OrdinalIgnoreCase))
                {
                    words[i] = "yes";
                }
                else if (string.Equals(words[i], "yes", StringComparison.OrdinalIgnoreCase))
                {
                    words[i] = "no";
                }
            }

            // Reconstruct the string from the modified words
            string replacedString = string.Join(" ", words);

            return replacedString;

        }
    }
}
