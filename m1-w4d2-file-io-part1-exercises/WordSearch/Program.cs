using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory = Environment.CurrentDirectory;
            string filename = "alices_adventures_in_wonderland.txt";

            string fullPath = Path.Combine(directory, filename);

            try
            {
                using (StreamReader sr = new StreamReader(fullPath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch(IOException e)
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
