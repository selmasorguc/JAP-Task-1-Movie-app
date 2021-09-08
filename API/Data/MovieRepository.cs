using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Entity;
using API.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class MovieRepository : IMovieRepository
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;
        public MovieRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<IEnumerable<MovieDto>> GetMoviesAsync()
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

        public async Task<MovieDto> GetMovieByIdAsync(int id)
        {
            var movie = await _context.Movies
            .Include(m => m.Cast)
            .Include(m => m.Ratings)
            .Where(m => m.IsMovie == true)
            .SingleOrDefaultAsync(m => m.Id == id);
            var movieDto = _mapper.Map<MovieDto>(movie);
            return movieDto;
        }
        public async Task<IEnumerable<MovieDto>> GetTVShowsAsync()
        {
            var tvshows = await _context.Movies.Include(m => m.Cast)
            .Include(m => m.Ratings).AsSplitQuery()
            .Where(m => m.IsMovie == false)
            .OrderByDescending(x => x.Ratings.Select(x => x.Value).Average())
            .ToListAsync();
            var tvshowsDto = _mapper.Map<IEnumerable<MovieDto>>(tvshows).ToList();

            return tvshowsDto;
        }

        public async Task<float> RateMovieAsync(Rating rating)
        {
            var movie = await _context.Movies
            .Include(m => m.Ratings).FirstOrDefaultAsync(m => m.Id == rating.MovieId);
            if (movie == null) return 2.3413345f;
            _context.Ratings.Add(rating);
            _context.Entry(movie).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return _mapper.Map<MovieDto>(movie).AverageRating;
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<MovieDto>> SearchMoviesAsync(string query)
        {
            var movies = await _context.Movies
            .Include(m => m.Cast).AsSplitQuery()
            .Include(m => m.Ratings)
            .Where(m => m.Title.ToLower().Contains(query.ToLower()))
            .OrderByDescending(x => x.Ratings.Select(x => x.Value).Average())
            .ToListAsync();
            var moviesDto = _mapper.Map<IEnumerable<MovieDto>>(movies).ToList();
            return moviesDto;
        }
    }
}