using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Airplane
    {
        private string planeNumber;
        private int bookedFirstClassSeats = 0;
        private int totalFirstClassSeats;
        private int bookedCoachSeats = 0;
        private int totalCoachSeats;

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
                return totalFirstClassSeats - bookedFirstClassSeats;
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
        public int TotalCoachSeats
        {
            get
            {
                return TotalCoachSeats;
            }
        }

        public Airplane(string planeNumber, int totalFirstClassSeats, int totalCoachSeats) // constructor 
        {
            this.planeNumber = planeNumber;
            this.totalCoachSeats = totalCoachSeats;
            this.totalFirstClassSeats = totalFirstClassSeats;
            
        }

        public bool ReserveSeats(bool forFirstClass, int totalNumberOfSeats)
        {
            if (forFirstClass)
            {
                if (totalNumberOfSeats > AvailableFirstClassSeats) 
                {
                    return false;
                }
            }
            else if (totalNumberOfSeats > AvailableCoachSeats) 
            {
                return false;
            }
            return true;
        }

    }
}
