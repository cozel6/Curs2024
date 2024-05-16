using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
    public class InvalidSongsExceptions : ApplicationException
    {
        //this = aceasta instanta de clasa
        //base = instanta parintelui (cea de mai sus)
        public InvalidSongsExceptions(string message = "Invalid song") : base(message)
        {

        }
    }
    public class InvalidArtistException : ApplicationException
    {
        public InvalidArtistException(string message = "Artist name should be between 2 and 30 characters") : base (message)
        {
            
        }
    }
    public class InvalidMinutesException : InvalidArtistException
    {
        public InvalidMinutesException(string message = "Minutes should be between 0 and 14 minutes") : base(message)
        {
        }
    }
    public class InvalidSecondsException : InvalidMinutesException
    {
        public InvalidSecondsException(string message = "Minutes should be between 0 and 59 seconds") : base(message)
        {
        }
    }
}
