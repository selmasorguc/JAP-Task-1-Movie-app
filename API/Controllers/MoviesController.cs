using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.DTOs;
using API.Entity;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("movies")]
    public class MoviesController : ControllerBase
    {

        private readonly IMovieRepository _movieRepository;

        public MoviesController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MovieDto>>> GetMovies()
        {
            return Ok(await _movieRepository.GetMoviesAsync());
        }

        [HttpGet("/tvshows")]
        public async Task<ActionResult<IEnumerable<MovieDto>>> GetTVShows()
        {
            return Ok(await _movieRepository.GetTVShowsAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<MovieDto>>> GetMovieById(int id)
        {
            return Ok(await _movieRepository.GetMovieByIdAsync(id));
        }

        [HttpGet("search/movies")]
        public async Task<ActionResult<IEnumerable<MovieDto>>> SearchMoviesAsync(string query)
        {
            return Ok(await _movieRepository.SearchMoviesAsync(query));
        }
    }

}