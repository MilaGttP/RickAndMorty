using System;
using System.Collections.Generic;

namespace RickAndMorty
{
    public class Episode
    {
       public int ID { get; set; }
       public string ? Name { get; set; }
       public string ? AirDate { get; set; }
       public string ? EpisodeCode { get; set; }
       public List <string> ? Characters { get; set; }
       public string? Url { get; set; }
       public DateTime? Created { get; set; }
        public override string ToString()
        {
            return $" Name: {Name}";
        }
    }
}
