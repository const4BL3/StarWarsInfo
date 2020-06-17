﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsInfo.Models
{
    public class FleetModel
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public StarshipModel[] Results { get; set; }
    }
}
