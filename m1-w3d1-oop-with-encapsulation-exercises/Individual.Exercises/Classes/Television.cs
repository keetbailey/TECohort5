using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Television
    {
        private bool isOn;
        private int currentChannel = 3;
        private int currentVolume = 2;

        public bool IsOn
        {
            get
            {
                return isOn;
            }
            private set
            {
                isOn = value;
            }
        }
        public int CurrentChannel
        {
            get
            {
                return currentChannel;
            }
            private set
            {
                currentChannel = value;
            }
        }
        public int CurrentVolume
        {
            get
            {
                return currentVolume;
            }
            private set
            {
                currentVolume = value;
            }
        }
        public void TurnOn()
        {
            isOn = true;
            currentChannel = 3;
        }
        public void TurnOff()
        {
            isOn = false;
        }

        public void ChangeChannel(int newChannel)
        {
            if (IsOn && newChannel > 3 && newChannel < 18)
            {
                currentChannel = newChannel;
            }

        }
        public void ChannelUp()
        {
            if (IsOn)
            {
                if (currentChannel >= 18)
                {
                    currentChannel = 3;
                }
                else
                {
                    currentChannel++;
                }
            }
                   
        }
        public void ChannelDown()
        {
            if (IsOn)
            {
                if (currentChannel <= 3)
                {
                    currentChannel = 18;
                }
                else
                {
                    currentChannel--;
                }
            }
        }
        public void RaiseVolume()
        {
            if (IsOn)
            {
                if (currentVolume < 10)
                {
                    currentVolume++;
                }
            }
        }
        public void LowerVolume()
        {
            if (IsOn)
            {
               if(currentVolume > 0)
            
                currentVolume--;
            }
        }
    }
}
