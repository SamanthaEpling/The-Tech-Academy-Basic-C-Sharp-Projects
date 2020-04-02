using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EplingPets.Models
{
    public class Breed
    {
        public int BreedId { get; set; }
        public string BreedName { get; set; }
        public string BreedCountryOfOrigin { get; set; }
        public string BreedDescription { get; set; }
        public virtual Species Species { get; set; }
        public virtual Pet Pets { get; set; }
    }
}