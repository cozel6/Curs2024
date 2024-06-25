using System.ComponentModel.DataAnnotations;

namespace FirstAppi.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        public DateTime ReleaseDate{ get; set; }

        public double Rating { get; set; }

        public ushort Duration { get; set; }
    }
}
