using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FizzWriter
{
    public static class Program
    {
        private static bool DivisibleBy3And5(int i) //establish bool statements for if statement inside ForLoop
        {
            return (i % 3 == 0) && (i % 5 == 0);
        }
        private static bool DivisibleBy3(int i) //establish bool statements for if statement inside ForLoop
        {
            return (i % 3 == 0);
        }
        private static bool DivisibleBy5(int i) //establish bool statements for if statement inside ForLoop
        {
            return (i % 5 == 0);
        }

        public static void Main(string[] args)
        {
            string directory = Environment.CurrentDirectory;
            string filename = "FizzBuzz.txt";
            string fullPath = Path.Combine(directory, filename);

            try
            {
                using (StreamWriter sw = new StreamWriter(filename, false))
                {
                    for (int i = 1; i < 301; i++)
                    {
                        if (DivisibleBy3And5(i))
                        {
                            sw.WriteLine("FizzBuzz");
                        }
                        else if (DivisibleBy3(i))
                        {
                            sw.WriteLine("Fizz");
                        }
                        else if (DivisibleBy5(i))
                        {
                            sw.WriteLine("Buzz");
                        }
                        else
                        {
                            sw.WriteLine(i);
                        }
                    }
                }
            }
            catch (IOException e)
            {

            }
        }

    }
}


////        public List<string> FizzBuzzList(int[] integerArray)
//        {
//            List<string> numOutput = new List<string>();

//            foreach (int ourNum in integerArray)
//            {
//                if (ourNum % 3 == 0 && ourNum % 5 == 0)
//                {
//                    numOutput.Add("FizzBuzz");
//                }
//                else if (ourNum % 5 == 0)
//                {
//                    numOutput.Add("Buzz");
//                }
//                else if (ourNum % 3 == 0)
//                {
//                    numOutput.Add("Fizz");
//                }
//                else
//                {
//                    numOutput.Add(ourNum.ToString());
//                }
//            }
//            return numOutput;        }
