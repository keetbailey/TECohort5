using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Airplane
    {
        private string planeNumber = "";
        private int bookedFirstClassSeats = 0;
        private int availableFirstClassSeats = 0;
        private int totalFirstClassSeats = 0;
        private int bookedCoachSeats = 0;
        private int availableCoachSeats = 0;

        public string PlaneNumber //Property 
        {
            get
            {
                return planeNumber;
            }
        }

        public int BookedFirstClassSeats //Property 
        {
            get
            {
                return bookedFirstClassSeats;
            }
            private set
            {
                bookedFirstClassSeats = value;
            }
        }
        public int AvailableFirstClassSeats //Property 
        {
            get
            {
                return availableFirstClassSeats;
            }
        }
        public int TotalFirstClassSeats //Property 
        {
            get
            {
                return totalFirstClassSeats;
            }
        }
        public int BookedCoachSeats //Property 
        {
            get
            {
                return bookedCoachSeats;
            }
            private set
            {
                bookedCoachSeats = value;
            }
        }
        public int AvailableCoachSeats //Property 
        {
            get
            {
                return TotalFirstClassSeats - BookedFirstClassSeats;
            }
        }

        public Airplane(string planeNumber, int totalFirstClassSeats, int totalCoachSeats) // constructor 
        {

        }
    }
}
