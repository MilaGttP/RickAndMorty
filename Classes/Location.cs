
using System;
using System.Collections.Generic;

namespace RickAndMorty
{
    public class Location
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string ? Type { get; set; }
        public string ? Dimension { get; set; }
        public List <string> ? Residents { get; set; }
        public string ? Url { get; set; }
        public DateTime ? Created { get; set; }
        public override string ToString()
        {
            return $" Name: {Name}";
        }
    }
}