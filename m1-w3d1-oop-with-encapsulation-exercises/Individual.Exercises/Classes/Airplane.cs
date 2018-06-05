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
        private int bookedFirstClassSeats;
        private int totalFirstClassSeats;
        private int bookedCoachSeats;
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
                return totalFirstClassSeats - BookedFirstClassSeats;
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
        public int TotalCoachSeats
        {
            get
            {
                return totalCoachSeats;
            }
        }
        public int AvailableCoachSeats //Property 
        {
            get
            {
                return totalCoachSeats - BookedCoachSeats;
            }
        }

        public Airplane(string planeNumber, int totalFirstClassSeats, int totalCoachSeats) // constructor 
        {
            this.planeNumber = planeNumber;
            this.totalFirstClassSeats = totalFirstClassSeats;
            this.totalCoachSeats = totalCoachSeats;
            

        }

        public bool ReserveSeats(bool forFirstClass, int totalNumberOfSeats)
        {
            if (forFirstClass)
            {
                if (totalNumberOfSeats <= AvailableFirstClassSeats)
                {
                    bookedFirstClassSeats += totalNumberOfSeats;
                    return true;
                }
            }
            else
            {
                if (totalNumberOfSeats <= AvailableCoachSeats)
                {
                    bookedCoachSeats += totalNumberOfSeats;
                    return true;
                }
            }
                
            return false;
        }
            
        }

}

