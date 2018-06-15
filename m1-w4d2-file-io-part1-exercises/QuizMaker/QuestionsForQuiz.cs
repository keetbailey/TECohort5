using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QuizMaker
{
    public class QuestionsForQuiz:Program
    {
        private string question;
        private const char delimiter = '|'; //identifies spacers

        public string Question { get; }

        private List<string> answers = new List<string> { };
        public string[] Answers
        {
            get
            {
                return answers.ToArray();
            }
        }
        public int correctAnswer;
        public bool IsCorrect(int userAnswer)
        {
            return correctAnswer == userAnswer;
        }

        public QuestionsForQuiz(string line)
        {

            if (!String.IsNullOrEmpty(line))
            {
                string[] spaces = line.Split(delimiter);
                question = spaces[0];
                
                for (int i=1; i<spaces.Length; i++)
                {
                    string answer = spaces[i].Trim(); //google tells me that Trim removes the whitespace! 

                    if (answer.EndsWith("*"))
                    {
                        answer = answer.Substring(0, answer.Length - 1);
                        correctAnswer = i - 1; 
                    }
                    answers.Add(answer);
                }
            }

        }
    }
}
