using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using System.Web;
using static System.Net.WebRequestMethods;

namespace TriviaApp
{
    class TriviaResult
    {
        public string category;
        public string type;
        public string difficulty;
        public string question;
        public string correct_answer;
        public List<string> incorrect_answers;
    }
    class Trivia
    {
        public int response_code;
        public List<TriviaResult> results;

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string url = null;
            string s = null;

            HttpWebRequest request;
            HttpWebResponse response;
            StreamReader reader;

            url = "https://opentdb.com/api.php?amount=1&type=multiple";

            request = (HttpWebRequest)WebRequest.Create(url);
            response = (HttpWebResponse)request.GetResponse();
            reader = new StreamReader(response.GetResponseStream());

            s = reader.ReadToEnd();
            reader.Close();

            Trivia trivia =JsonConvert.DeserializeObject<Trivia>(s);

            trivia.results[0].question = HttpUtility.HtmlDecode(trivia.results[0].question);
            trivia.results[0].correct_answer = HttpUtility.HtmlDecode(trivia.results[0].correct_answer);


            for (int i = 0; i < trivia.results[0].incorrect_answers.Count; ++i)
            {
                trivia.results[0].incorrect_answers[i] = HttpUtility.HtmlDecode(trivia.results[0].incorrect_answers[i]);
            }

            // Display the question
            Console.WriteLine(trivia.results[0].question);

            // Combine correct and incorrect answers
            List<string> allAnswers = new List<string>(trivia.results[0].incorrect_answers);
            allAnswers.Add(trivia.results[0].correct_answer);

            // Shuffle the answers
            Random rand = new Random();
            allAnswers.Sort((x, y) => rand.Next(-1, 2));

            // Display the shuffled answers
            for (int i = 0; i < allAnswers.Count; ++i)
            {
                Console.WriteLine($"{i + 1}. {allAnswers[i]}");
            }

            // Prompt the user for an answer
            Console.Write("Enter your answer (1-4): ");
            int userChoice = Convert.ToInt32(Console.ReadLine());

            // Validate user input
            if (userChoice >= 1 && userChoice <= 4)
            {
                string userAnswer = allAnswers[userChoice - 1];

                // Display the correct answer
                Console.WriteLine($"The correct answer is \"{trivia.results[0].correct_answer}");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
            }

        }
    }
}
