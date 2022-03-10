using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MapApp.Models
{
    public class SearchByCity
    {
        [Required(ErrorMessage = "City name is empty!")]
        [StringLength(30, MinimumLength = 2 , ErrorMessage ="Invalid Input")]


        public string CityName { get; set; }
    }
}
