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
    public class TVShowsController : ControllerBase
    {
        private readonly DataContext _context;
        public TVShowsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TVShow>>> GetTVShows()
        { 
            var tvshows = await _context.TVShows.Include(m => m.Cast)
            .ToListAsync();
            return tvshows;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TVShow>> GetTVShowById(int id)
        { 
            var tvshow = await _context.TVShows.FindAsync(id);
            return tvshow;
        }
    }

}