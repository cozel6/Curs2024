using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
    public class Song
    {
        private string name;
        private string artist;
        private int minutes;
        private int seconds;

        public Song()
        {

        }


        //lenght minim 3 , max 30
        public string Name
        {
            get { return name; }
            set
            {
                if(value.Length >= 3 && value.Length <= 30)
                {
                    name = value;
                }
                else
                {
                    throw new InvalidArtistException();
                }
            }

        }


        //lenght min 2 , max 30

        public string Artist
        {
            get
            {
                return artist;
            }
            set
            {
                if (value.Length >= 2 && value.Length <= 30)
                {
                    artist = value;
                }
                else
                {
                    throw new InvalidArtistException();
                }
                
            }
        }
        //lenght no more then 14 min

        public int Minutes
        {
            get
            {
                return minutes;
            }
            set
            {
                if ((value >= 0) || (value <= 14))
                {
                    minutes = value;
                }
                else
                {
                    throw new InvalidMinutesException();
                }
                

            }
        }
        //lenght no more than 59 sec

        public int Seconds
        {
            get
            {
                return seconds;
            }
            set
            {
                if ((value > 0) || (value <= 59))
                {
                    seconds = value;

                }
                else
                {
                    throw new InvalidSecondsException();
                }

            }
        }
    }
}
