using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarCity.Models
{
    public class Car {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string name { get; set; }
        public Year year { get; set; }
        public Types type { get; set; }
        public City city { get; set; }
        public IList<CarOwner> CarOwners { get; set; }
    }
}
