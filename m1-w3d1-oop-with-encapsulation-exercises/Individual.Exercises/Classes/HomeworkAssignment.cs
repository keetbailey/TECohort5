using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class HomeworkAssignment
    {
        private int totalMarks = 0;
        private int possibleMarks = 0;
        private string submitterName = "";
        private string letterGrade = "";

        public int TotalMarks //Property 
        {
            get
            {
                return totalMarks;
            }
            set
            {
                totalMarks = value;
            }
        }
        public int PossibleMarks //property
        {
            get
            {
                return possibleMarks;
            }
            
        }
        public string SubmitterName //property - no set due to ReadOnly
        {
            get
            {
                return submitterName;
            }
        }
        public string LetterGrade  //property
        {
            get
            {
                double scorePercent = (double)totalMarks / possibleMarks; //assign double from casted integer values to utilize in "If/Else" statement
                if (scorePercent >= 0.90)
                    return "A";
                else if (scorePercent >= 0.80)
                    return "B";
                else if (scorePercent >= 0.70)
                    return "C";
                else if (scorePercent >= 0.60)
                    return "D";
                else
                    return "F";
            }
           
        }

        public HomeworkAssignment(int possibleMarks, string submitterName) //Constructor - no type associated
        {
            this.possibleMarks = possibleMarks;
        }
    }
}
