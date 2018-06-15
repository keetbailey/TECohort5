using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What are you searching for?");
            string searchString = Console.ReadLine();
            Console.WriteLine("What is the file path?");
            string inputFilePath = Console.ReadLine();


            string directory = Environment.CurrentDirectory;
            string combinedFilePath = Path.Combine(directory, inputFilePath);

            try
            {
                using (StreamReader sr = new StreamReader(combinedFilePath))
                {
                    int i = 1;
                    while (!sr.EndOfStream)
                    {
                        string lineContains = sr.ReadLine();
                        bool searchFound = lineContains.IndexOf(searchString) > 0;
                        if (searchFound)
                        {
                            Console.WriteLine($"{i} {lineContains}");
                        }
                        i++;
                    }

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error reading the file");
                Console.WriteLine(e.Message);
            }

            //1. Ask the user for the search string
            //2. Ask the user for the file path
            //3. Open the file
            //4. Loop through each line in the file
            //5. If the line contains the search string, print it out along with its line number


        }
    }
}
