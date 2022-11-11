
using System.Collections.Generic;

namespace RickAndMorty
{
    public class Location
    {
        int Id { get; set; }
        string ? Name { get; set; }
        string ? Type { get; set; }
        string ? Dimension { get; set; }
        List <string> ? Residents { get; set; }
        string ? Url { get; set; }
        string ? Created { get; set; }
        public override string ToString()
        {
            return $"{Id} - {Name}- {Url}\n";
        }
    }
}
