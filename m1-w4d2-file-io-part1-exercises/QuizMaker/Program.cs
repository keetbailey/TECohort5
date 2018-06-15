using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QuizMaker
{
    // need to create a class that holds quiz question, user choices and correct answers and need to create list of quiz questions 
    public class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the file name for the Quiz Questions:");
            string inputFileName = Console.ReadLine();

            string combinedFilePath = Path.Combine(Environment.CurrentDirectory, inputFileName);

            while (!File.Exists(combinedFilePath))
            {
                Console.WriteLine("Error: File not found");
                inputFileName = Console.ReadLine();
                combinedFilePath = Path.Combine(Environment.CurrentDirectory, inputFileName);
            }

            List<QuestionsForQuiz> quizQuestions = FilePathForQuizQuestions(combinedFilePath);

            GetQuiz(quizQuestions);
        }

        private static List<QuestionsForQuiz> FilePathForQuizQuestions(string combinedFilePath)
        {
            List<QuestionsForQuiz> quizQuestions = new List<QuestionsForQuiz>();
            
            try
            {
                using (StreamReader sr = new StreamReader(combinedFilePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string lineContains = sr.ReadLine();
                        quizQuestions.Add(new QuestionsForQuiz(lineContains));
                    }

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error reading the file");
                Console.WriteLine(e.Message);
            }
            return quizQuestions;
        }

            private static void GetQuiz(List<QuestionsForQuiz> quizQuestions)
        {
            int numOfQuestions = 0;
            int numOfValidAnswers = 0;

            foreach (QuestionsForQuiz question in quizQuestions)
            {
                Console.WriteLine(question.Question);
                for (int i=0; i<question.Answers.Length; i++)
                {
                    //Console.WriteLine( $"{ i + 2}) {quizQuestions.Answers[i]}");
                }
                Console.Write("\n Your Answer: ");
                int answer = int.Parse(Console.ReadLine());

                //if (quizQuestions.IsCorrect(answer - 1))
                //{
                //    Console.WriteLine("Correct!\n");
                //}
                //else
                //{
                //    Console.WriteLine("Sorry, that is incorrect!\n");
                //}

                //numOfQuestions += 1;
            }

            Console.WriteLine($"Your score is {numOfValidAnswers} questions correct out of {numOfQuestions} presented!");
        }
    }
}

//Create a quiz maker program which asks the user a question. They should be presented with the possible multiple choice answers and allowed to specify the correct answer .
//The program should read the questions from an input file during startup.The questions and answers in the file will be pipe delimited | and correct answers will be marked with an asterisk in the file.
//Create a class that can hold a quiz question, its available answers, and the correct answer . Try holding each quiz question in a list of quiz question
////            Console.WriteLine("Should Lethal Weapon be considered a Christmas movie, a la Die Hard?");
//Console.WriteLine("");
//            Console.WriteLine($"{1}. If Die Hard is, then I guess...");
//            Console.WriteLine($"{2}. Of course not");
//            Console.WriteLine($"{3}. Of course!");
//            Console.WriteLine($"{4}. What is Lethal Weapon?");