using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Elevator
    {
       private int numberOfLevels;
       private int currentLevel;
       private bool doorIsOpen;
       

       public int CurrentLevel //property
        {
            get
            {
                return currentLevel;
            }
            private set
            {
                currentLevel = value;
            }
        }
        public int NumberOfLevels //property
        {
            get
            {
                return numberOfLevels;
            }
        }
        public bool DoorIsOpen //property 
        {
            get
            {
                return doorIsOpen;
            }
            private set
            {
                doorIsOpen = value;
            }
        }
        public Elevator(int numberOfLevels) //constructor 
        {
            this.numberOfLevels = numberOfLevels;
            currentLevel = 1;
        }
        public void OpenDoor()
        {
            doorIsOpen = true;
        }
        public void CloseDoor()
        {
            doorIsOpen = false;
        }
        
 
        public void GoUp(int desiredFloor)
        {
            if (!DoorIsOpen && desiredFloor > CurrentLevel && desiredFloor <= NumberOfLevels)
            {
                currentLevel = desiredFloor;
            }
                
        }
        public void GoDown(int desiredFloor)
        {
            if (!DoorIsOpen && desiredFloor < CurrentLevel && desiredFloor > 0)
            {
                currentLevel = desiredFloor;
            }
                
        }
    }

}
