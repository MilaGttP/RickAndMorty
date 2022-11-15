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
       public string ? Name { get; set; }
       public string ? AirDate { get; set; }
       public string ? EpisodeCode { get; set; }
       public List <string> ? Characters { get; set; }
       public string? Url { get; set; }
       public DateTime? Created { get; set; }
    }
}
