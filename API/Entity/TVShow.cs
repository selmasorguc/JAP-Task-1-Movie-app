using System;
using System.Collections.Generic;

namespace API.Entity
{
    public class TVShow
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string CoverUrl { get; set; }
        public float Rating { get; set; }
        public int SeasonNumber { get; set; }
        public IEnumerable<Actor> Cast { get; set; }
    }
}