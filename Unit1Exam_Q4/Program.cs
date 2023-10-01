using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Unit1Exam_Q4
{
    // Class: Program
    // Author: Diya Iyer
    // Purpose: Asking 3 different questions to the user
    // Restrictions: None
    static class Program
    {
        // Checking if the user got timed out
        static bool bTimedOut = false;
        // string for response
        static string sResponse = "";

        // initialize timer for 5 seconds
        static System.Timers.Timer questionTimer = new System.Timers.Timer(5000);

        // Method: Main()
        // Author: Diya Iyer
        // Purpose: Prompting the user to answer a set of questions with predetermined answers under a time limit
        // Restrictions: User must select a question between 1-3
        static void Main()
        {

            // string and int of # of the question to be asked
            string sQuestions = "";
            int nQuestions = 0;

            // string and int of answers
            string sResponse = "";

            // declaring the arrays of questions and answers
            string[] questionArray = { "What is your favorite color?", "What is the answer to life, the universe, and everything?", "What is the airspeed velocity of an unladen swallow?" };
            string[] answerArray = { "black", "42", "What do you mean? African or European swallow?" };

            // play again?
            string sAgain = "";

            // valid state
            bool bValid = false;

            questionTimer.Elapsed += new ElapsedEventHandler(QuestionTimeout);

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

        // label to return to if they want to play again
        start:


            // ask which question the user wishes to answer until they provide a valid input
            do
            {
                Console.Write("Choose your question (1-3): ");
                sQuestions = Console.ReadLine();
                bValid = int.TryParse(sQuestions, out nQuestions);
                if (bValid)
                {
                    if (nQuestions < 1 || nQuestions > 3)
                    {
                        Console.WriteLine("Please enter a number between 1 - 3");
                        bValid = false;
                        continue;
                    }
                }
            } while (!bValid);

            Console.WriteLine();
            Console.WriteLine("You have 5 seconds to answer the following question: ");

            // assigning values based on validity 
            bValid = false;
            bTimedOut = false;

            // display the question and prompt for the answer until they enter a valid number
            do
            {
                Console.WriteLine(questionArray[nQuestions - 1]);
                // start the timer
                questionTimer.Start();
                sResponse = Console.ReadLine();
                if (bTimedOut)
                {
                    // reset values
                    bValid = true;
                    questionTimer.Stop();
                }
                else
                {
                    // check for input length 
                    bValid = sResponse.Length > 0;

                    if (!bValid)
                    {
                        Console.WriteLine("Please provide an answer");
                        questionTimer.Stop();
                    }
                }

            } while (!bValid);

            // if response == answer, congratulate the user
            if (sResponse.CompareTo(answerArray[nQuestions - 1]) == 0)
            {
                Console.WriteLine("Well done!");
            }
            // else tell the user if they gave the wrong answer or ran out of time
            else
            {
                if (bTimedOut)
                {
                    Console.WriteLine("Time's up!");
                    Console.WriteLine("The answer is: " + answerArray[nQuestions - 1]);
                    bTimedOut = false;
                }
                else
                {
                    Console.WriteLine("Wrong! The answer is: " + answerArray[nQuestions - 1]);
                }
            }

            Console.WriteLine("Please press enter.");

            do
            {
                // prompt if they want to play again
                Console.Write("Play again?");

                sAgain = Console.ReadLine();

                // if they type y or yes then play again
                // else if they type n or no then leave this loop
                if (sAgain.ToLower().Trim().StartsWith("y"))
                {
                    goto start;
                }
                else
                {
                    Environment.Exit(0);
                }
            } while (true);
        }

        // Method: QuestionTimeout
        // Author: Diya Iyer
        // Purpose: To check if the user has run out of time to answer
        // Restrictions: None
        static void QuestionTimeout(object source, ElapsedEventArgs e)
        {
            if (sResponse == null || sResponse.Length == 0)
            {
                bTimedOut = true;
            }
        }
    }
}
