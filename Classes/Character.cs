using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMorty
{
    public class Character
    {
        int Id { get; set; }
        string ? Name { get; set; }
        string ? Status { get; set; }
        string ? Species { get; set; }
        string ? Type { get; set; }
        string ? Gender { get; set; }
        object ? Origin { get; set; }
        object ? Location { get; set; }
        string? Image { get; set; }
        List <string> ? Episode { get; set; }
        string ? Url { get; set; }
        string ? Created { get; set; }
    }
}
