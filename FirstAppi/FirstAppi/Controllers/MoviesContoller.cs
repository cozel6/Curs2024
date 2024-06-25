using FirstAppi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace FirstAppi.Controllers
{
    [Route("api/[controller]")] // api/movies
    [ApiController]
    public class MoviesContoller : ControllerBase
    {
        private static List<Movie>? movies;
        public MoviesContoller()
        {
            movies = new List<Movie>
            {
                new Movie {Id = 1, Title = "Inception", ReleaseDate = DateTime.Now, Duration = 150, Rating = 4,},
                new Movie {Id = 2, Title = "Back to the future", ReleaseDate = DateTime.MinValue, Duration = 180, Rating = 8,}
            };
        }


        [HttpGet]
        public IActionResult Get()
        {
            // returns all movies
            return Ok(movies);
        }
        [HttpPost] // api/movies
        public IActionResult Create()
        {

            return Ok(movies);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id) //does that entity with id exists ?  if no retrun not found , if yes retrun ok
        {
            var existingMovie = movies?.FirstOrDefault(movie => movie.Id == id);
            if (existingMovie == null)
            {
                return NotFound();
            }
            return Ok(existingMovie);

        }
        [HttpHead("{id}")]


        public IActionResult CheckIfExists(int id)
        {
            if (movies.Any(c => c.Id == id))
            {
                return Ok(movies);
            }
            return BadRequest();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteOperation(int id)
        {
            var moveiWithId = movies.FirstOrDefault(m => m.Id == id);
            if(moveiWithId == null)
            {
                return NotFound();
            }
            movies.Remove(moveiWithId);
            return NoContent();
        }
    }
}
