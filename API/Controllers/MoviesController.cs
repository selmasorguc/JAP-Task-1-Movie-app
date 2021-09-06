using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.DTOs;
using API.Entity;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("movies")]
    public class MoviesController : ControllerBase
    {

        private readonly IMapper _mapper;

        private readonly DataContext _context;
        public MoviesController(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MovieDto>>> GetMovies()
        {
            var movies = await _context.Movies
            .Include(m => m.Cast).AsSplitQuery()
            .Include(m => m.Ratings)
            .Where(m => m.IsMovie == true)
            .OrderByDescending(x => x.Ratings.Select(x => x.Value).Average())
            .ToListAsync();
            var moviesDto = _mapper.Map<IEnumerable<MovieDto>>(movies).ToList();
            return moviesDto;
        }

        [HttpGet("/tvshows")]
        public async Task<ActionResult<IEnumerable<MovieDto>>> GetTVShows()
        {
            var tvshows = await _context.Movies.Include(m => m.Cast)
            .Include(m => m.Ratings).AsSplitQuery()
            .Where(m => m.IsMovie == false)
            .OrderByDescending(x => x.Ratings.Select(x => x.Value).Average())
            .ToListAsync();
            var tvshowsDto = _mapper.Map<IEnumerable<MovieDto>>(tvshows).ToList();

            return tvshowsDto;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Movie>> GetMovieById(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            return movie;
        }
    }

}