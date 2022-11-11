using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Resources;

namespace RickAndMorty
{
    public class Episode
    {
        public int Id { get; set; }
        string ? Name { get; set; }
        string ? AirDate { get; set; }
        string ? EpisodeCode { get; set; }
        List <string> ? Characters { get; set; }
        string? Url { get; set; }
        string? Created { get; set; }
    }
}
