using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsInfo.Models
{
    public class PlanetsModel
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public PlanetModel[] Results { get; set; }
    }
}
