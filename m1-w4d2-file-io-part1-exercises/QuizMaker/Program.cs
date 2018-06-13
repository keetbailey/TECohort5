using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QuizMaker
{
    // need to create a class that holds quiz question, user choices and correct answers and need to create list of quiz questions 
    class Program
    {
        //private List<QuestionsForQuiz> FilePathForQuizQuestions(string combinedFilePath)
        //{
        //    List<QuestionsForQuiz> QuizQuestions = new List<QuestionsForQuiz>();
        //}
        static void Main(string[] args)
        {
            Console.WriteLine("Should Lethal Weapon be considered a Christmas movie, a la Die Hard?");
            Console.WriteLine("");
            Console.WriteLine($"{1}. If Die Hard is, then I guess...");
            Console.WriteLine($"{2}. Of course not");
            Console.WriteLine($"{3}. Of course!");
            Console.WriteLine($"{4}. What is Lethal Weapon?");
            //int input = (Console.ReadLine());

            try
            {
            //    using (StreamReader sr = new StreamReader(combinedFilePath))
            //    {
            //        while (!sr.EndOfStream)
            //        {
            //            string lineContains = sr.ReadLine();
            //            Console.WriteLine(lineContains);
            //        }

            //    }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error reading the file");
                Console.WriteLine(e.Message);
            }
        }
    }
}

//Create a quiz maker program which asks the user a question. They should be presented with the possible multiple choice answers and allowed to specify the correct answer .
//The program should read the questions from an input file during startup.The questions and answers in the file will be pipe delimited | and correct answers will be marked with an asterisk in the file.
//Create a class that can hold a quiz question, its available answers, and the correct answer . Try holding each quiz question in a list of quiz question
