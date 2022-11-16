using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMorty
{
    public class Character
    {
        public int ID { get; set; }
        public string ? Name { get; set; }
        public string ? Status { get; set; }
        public string ? Species { get; set; }
        public string ? Type { get; set; }
        public string ? Gender { get; set; }
        public object ? Origin { get; set; }
        public object ? Location { get; set; }
        public string? Image { get; set; }
        public List <string> ? Episode { get; set; }
        public string ? Url { get; set; }
        public DateTime ? Created { get; set; }

        public override string ToString()
        {
            return $" ID: {ID}\n Name: {Name}\n Type: {Type}\n  Url: {Url}\n Episodes: {Episode}\n";
        }
    }
}
