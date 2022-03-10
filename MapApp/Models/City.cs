using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapApp.Models
{
    public class City
    {
        public string Name { get; set; }
        public string countryName { get; set; }
        public string cityName { get; set; }
        public string street { get; set; }
        public float lat { get; set; }
        public float lng { get; set; }
    }
}
