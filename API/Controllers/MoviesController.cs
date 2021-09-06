using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly DataContext _context;
        public MoviesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> GetMovies()
        { 
            var movies = await _context.Movies.Include(m => m.Cast)
            .ToListAsync();
            return movies;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Movie>> GetMovieById(int id)
        { 
            var movie = await _context.Movies.FindAsync(id);
            return movie;
        }
    }

}