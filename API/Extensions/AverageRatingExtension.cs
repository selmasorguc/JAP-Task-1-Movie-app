using System;
using System.Collections.Generic;
using System.Linq;
using API.Entity;

namespace API.Extensions
{
    public static class AverageRatingExtension
    {
        public static float CalculateAverageRating(this IEnumerable<Rating> ratings){
            var ratingAvg = ratings.Average(x => x.Value);
            return (float)Math.Round(ratingAvg, 1);
        }
    }
}