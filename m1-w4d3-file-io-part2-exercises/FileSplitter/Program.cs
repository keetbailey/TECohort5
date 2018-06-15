using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSplitter
{
    class Program
    {
        static void Main(string[] args)
        {

            string fullPath = Path.Combine(Environment.CurrentDirectory, "input.txt");

            Console.WriteLine("How many lines of text should be in each file? ");
            string input = Console.ReadLine();
            int numOfLines = int.Parse(input);

            using (StreamReader sr = new StreamReader(fullPath, false))
            {
                int fileIdentifier = 0;
                while (!sr.EndOfStream)
                {
                    string outputPath = Path.Combine(Environment.CurrentDirectory, $"input-{fileIdentifier}.txt");

                    using (StreamWriter sw = new StreamWriter(outputPath))
                    {
                        for (int i = 0; !sr.EndOfStream && i < numOfLines; i++)
                        {
                            sw.WriteLine(sr.ReadLine());
                        }
                    }

                    fileIdentifier++;
                }
            }
        }
    }
}
