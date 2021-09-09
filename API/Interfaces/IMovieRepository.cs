using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTOs;
using API.Entity;
using API.Helpers;

namespace API.Interfaces
{
    public interface IMovieRepository
    {

        Task<bool> SaveAllAsync();
        Task<IEnumerable<MovieDto>> GetMoviesAsync();

        Task<MovieDto> GetMovieByIdAsync(int id);
        Task<IEnumerable<MovieDto>> GetTVShowsAsync();
        Task<float> RateMovieAsync(Rating rating);
        Task<IEnumerable<MovieDto>> SearchMoviesAsync(string query);
        Task<IEnumerable<MovieDto>> GetPaged(MovieParams movieParams);
        Task<IEnumerable<MovieDto>> GetTVShowsPaged(MovieParams movieParams);

    }
}