using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearConvert
{
    class Program
    {
        /*
         The foot to meter conversion formula is:
 	        m = f * 0.3048
 	
         The meter to foot conversion formula is:
 	        f = m * 3.2808399
 	
         Write a command line program which prompts a user to enter a length, and whether the measurement is in (m)eters or (f)eet.
         Convert the length to the opposite measurement, and display the old and new measurements to the console.
  
         C:\Users> LinearConvert
         Please enter the length: 58
         Is the measurement in (m)eter, or (f)eet? f
         58f is 17m.
         */

        static void Main(string[] args)
        {
            Console.Write("Enter a length: ");
            string lengthInput = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Is the measurement in (m)eters or (f)eet? ");
            string measurementInput = Console.ReadLine();
            {
                int totalFeet = int.Parse(lengthInput);
                int totalMeter = int.Parse(lengthInput);
                int convertToFeet = (int)(totalFeet * 0.3048);
                int convertToMeter = (int)(totalMeter * 3.2808399);
                if (measurementInput == "m")
                    Console.WriteLine(lengthInput + "m is " + convertToMeter + "f ");
                else if (measurementInput == "f")
                    Console.WriteLine(lengthInput + "f is " + convertToFeet + "m ");
            }


            
        }
    }
}
