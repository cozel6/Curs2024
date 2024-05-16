namespace CustomExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Song song = new Song();
                song.Artist = "Aaaa";
                song.Minutes = 3;
                song.Seconds = 10;
                song.Name = "Jony";
                Console.WriteLine(song.Artist);
                Console.WriteLine(song.Minutes);
                Console.WriteLine(song.Seconds);
                Console.WriteLine(song.Name);
            }
            catch (InvalidArtistException iae) 
            {
                Console.WriteLine(iae.Message);
            }
        }
    }
}
