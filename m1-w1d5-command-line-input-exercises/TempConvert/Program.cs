using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConvert
{
    class Program
    {
        /*
         The Fahrenheit to Celsius conversion formula is:
 	        Tc = (Tf - 32) / 1.8
 	        where 'Tc' is the temperature in Celsius, and 'Tf' is the temperature in Fahrenheit
 	
         The Celsius to Fahrenheit conversion formula is:
 	        Tf = Tc * 1.8 + 32
 	         
        Write a command line program which prompts a user to enter a temperature, and whether its in degrees (C)elsius or (F)arenheit.
        Convert the temperature to the opposite degrees, and display the old and new temperatures to the console.

         C:\Users> TempConvert
         Please enter the temperature: 58
         Is the temperature in (C)elcius, or (F)arenheit? F
         58F is 14C.
        
         */
        static void Main(string[] args)
        {
            Console.Write("Please enter temperature: ");
            string inputTemp = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Is the temperature in (C)elcius of (F)arenheit? ");
            string inputUnit = Console.ReadLine();
            {
                int tempC = int.Parse(inputTemp);
                int tempF = int.Parse(inputTemp);
                int convertToCelcius = (int)((tempF - 32) / 1.8);
                int convertToFahrenheit = (int)((tempC * 1.8) + 32);
                if (inputUnit == "C")
                Console.WriteLine(inputTemp + "C " + "is " + convertToFahrenheit + "F. ");
                else if (inputUnit == "F")
                Console.WriteLine(inputTemp + "F " + "is " + convertToCelcius + "C. ");
            }
        



        



    }
}
}
