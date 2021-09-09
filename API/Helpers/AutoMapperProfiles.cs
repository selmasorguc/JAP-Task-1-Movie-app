using API.Extensions;
using API.DTOs;
using API.Entity;
using AutoMapper;

namespace API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Movie, MovieDto>()
            .ForMember(dest => dest.AverageRating, opt => opt.MapFrom(src => src.Ratings.CalculateAverageRating()));
            CreateMap<Actor, ActorDto>();
            CreateMap<Rating, RatingDto>();
        }
    }
}