using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalPartB.Models
{
    public class Planet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Climate { get; set; }
        public string Terrain { get; set; }
        public string Population { get; set; }
    }
}